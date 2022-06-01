using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public PlayerController player;
    // Start is called before the first frame update
    public GameObject tilePrefab;

    public int width = 6;
    public int height = 6;

    public Tile first, seconds;
    public List<GameObject> PoolObjects { get; set; }

    private Vector3 _oldPos = Vector3.zero;

    [SerializeField] private Color[] color;

    public void SetTile(Tile tile)
    {
        if (first == null)
        {
            first = tile;
        }
        else if (first.color == tile.color)
        {
            seconds = tile;
            StartCoroutine(EarnSameColor());
        }
        else
        {
            seconds = tile;
            StartCoroutine(ResetColor());
        }
        
        
    }

    IEnumerator EarnSameColor()
    {
        yield return new WaitForSeconds(1f);
        first.gameObject.SetActive(false);
        seconds.gameObject.SetActive(false);
        first = null;
        seconds = null;
    }
    
    IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(1f);
        first.spriteRenderer.color = Color.white;
        seconds.spriteRenderer.color = Color.white;
        first = null;
        seconds = null;
    }
    
    void Start()
    {
        RePlay();
    }

    private Color GetRandomColor(Dictionary<Color, int> colorId)
    {
        var color = colorId.Where(it => it.Value > 0).Select(it=>it.Key).ToList();
        var rd = Random.Range(0, color.Count);
        if (color.Count > 0)
        {
            colorId[color[rd]]--;
            return color[rd];
        }
        return Color.white;
    }


    public void RePlay()
    {
        _oldPos = Vector3.zero;

        if (PoolObjects?.Count > 0)
        {
            for (int i = PoolObjects.Count - 1; i >= 0; i--)
            {
                Destroy(PoolObjects[i]);
            }
        }
        
        PoolObjects = new List<GameObject>();

        var size = tilePrefab.GetComponent<BoxCollider2D>().size;
        var scale = tilePrefab.transform.localScale.x;

        Dictionary<Color, int> colorId = new Dictionary<Color, int>();

        for (int i = 0; i < color.Length; i++)
        {
            colorId.Add(color[i],4);
        }

        for (int y = 0; y < height; y++)
        {
            for (int i = 0; i < width; i++)
            {
                var go = Instantiate(tilePrefab, transform);
                //go.SetActive(false);
                go.transform.localPosition = _oldPos;
                go.name = $"{i} - {y}";
                _oldPos.x += (size.x *scale);

                Color color = GetRandomColor(colorId);
                go.GetComponent<Tile>().SetColor(color);
                PoolObjects.Add(go);
            }
            _oldPos.x = 0;
            _oldPos.y += (size.y * scale);
        }
    }
}
