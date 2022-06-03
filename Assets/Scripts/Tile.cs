using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour , IPointerDownHandler
{
    public Color color;

    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!GameManager.Instance.spawnMng.AllowInput)
        {
            return;
        }
        spriteRenderer.color = color;
        
        GameManager.Instance.spawnMng.SetTile(this);
    }

    public void SetColor(Color color)
    {
        this.color = color;
    }
    public void convert()
    {
        float fValue = 0.123456f;
        int iValue = (int)fValue;
        // Debug.Log("int val: " +iValue);
        //  
        // iValue = Mathf.FloorToInt(fValue);
        // Debug.Log("int val: " +iValue);
        //  
        // iValue = Mathf.CeilToInt(fValue);
        // Debug.Log("int val: " +iValue);
        //  
        // iValue = Mathf.RoundToInt(fValue);
        // Debug.Log("int val: " +iValue);
    }
}
