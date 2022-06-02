using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;
using DG.Tweening;


public class SpawnManager : MonoBehaviour
{
    //public PlayerController player;
    // Start is called before the first frame update
    public GameObject tilePrefab;

    public Tile first, seconds;
    public Queue<GameObject> PoolObjects { get; set; }

    private Vector3 _oldPos = Vector3.zero;

    [SerializeField] private Color[] color;

    [FormerlySerializedAs("_time")] public float time = 3f;
    public Vector3 pos = new Vector3(3.72f, 4.4f);
    
   // public bool AllowInput = true;
    public void SetTile(Tile tile)
    {
        if (first == null)
        {
            first = tile;
        }
        else if (first.color == tile.color)
        {
            seconds = tile;
            //AllowInput = false;
            StartCoroutine(EarnSameColor());
            GameManager.Instance.CountScore();

            CheckWinCondition();
        }
        else
        {
            seconds = tile;
            //AllowInput = false;
            StartCoroutine(ResetColor());
        }
    }

    private void CheckWinCondition()
    {
        
    }

    IEnumerator EarnSameColor()
    {
        yield return new WaitForSeconds(1f);
        first.gameObject.SetActive(false);
        seconds.gameObject.SetActive(false);
        first = null;
        seconds = null;
        //AllowInput = true;

    }
    
    IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(1f);
        first.spriteRenderer.color = Color.white;
        seconds.spriteRenderer.color = Color.white;
        first = null;
        seconds = null;
        //AllowInput = true;
    }
    
    void Start()
    {
        PoolObjects = new Queue<GameObject>();
        for (int i = 0; i < 20; i++)
        {
            var go = Instantiate(tilePrefab,transform);
            go.SetActive(false);
            
            PoolObjects.Enqueue(go);
        }
        RePlay();
    }

    private void Update()
    {
        if (time <= 0 )
        {
            time = Random.Range(0.2f, 0.8f);
            var go = PoolObjects.Dequeue();

            var index = Random.Range(0, this.color.Length);
            
            go.GetComponent<Tile>().SetColor(this.color[index]);
            
            go.SetActive(true);

            float x = Random.Range(0f, pos.x);

            float y = Random.Range(0f, pos.y);

            go.transform.localPosition = new Vector3(x, y, 0);
            
            go.transform.localScale = Vector3.zero;

            go.transform.DOScale(Vector3.one * 1.5f, 1).onComplete = () =>
            {
                go.transform.DOScale(Vector3.zero, 1).onComplete = () =>
                {
                    go.SetActive(false);
                };
            };
            
            PoolObjects.Enqueue(go);
        }
        else
        {
            time -= Time.deltaTime;
        }
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
        // _oldPos = Vector3.zero;
        //
        // if (PoolObjects?.Count > 0)
        // {
        //     for (int i = PoolObjects.Count - 1; i >= 0; i--)
        //     {
        //         Destroy(PoolObjects[i]);
        //     }
        // }
        
        // PoolObjects = new List<GameObject>();
        //
        // var size = tilePrefab.GetComponent<BoxCollider2D>().size;
        // var scale = tilePrefab.transform.localScale.x;
        //
        // Dictionary<Color, int> colorId = new Dictionary<Color, int>();
        //
        // for (int i = 0; i < color.Length; i++)
        // {
        //     colorId.Add(color[i],4);
        // }
        //
        // for (int y = 0; y < height; y++)
        // {
        //     for (int i = 0; i < width; i++)
        //     {
        //         var go = Instantiate(tilePrefab, transform);
        //         //go.SetActive(false);
        //         go.transform.localPosition = _oldPos;
        //         go.name = $"{i} - {y}";
        //         _oldPos.x += (size.x *scale);
        //
        //         Color color = GetRandomColor(colorId);
        //         go.GetComponent<Tile>().SetColor(color);
        //         PoolObjects.Add(go);
        //     }
        //     _oldPos.x = 0;
        //     _oldPos.y += (size.y * scale);
        // }
    }
}
