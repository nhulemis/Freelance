using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public enum operatoors { Plus, Minus, Devide, Multiply };

public class DoorController : MonoBehaviour
{
    public operatoors operatoor;

    private int value;
    private TextMeshPro  valueText;
    public SpriteRenderer spriteRenderer;
    [SerializeField] Color32 positiveColor;
    [SerializeField] Color negativeColor;

    // Start is called before the first frame update
    void Start()
    {
        valueText = this.GetComponentInChildren<TextMeshPro>();
        spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
        assignValue();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void assignValue()
    {
        switch (operatoor)
        {
            case operatoors.Plus:
                value = Random.Range(5, 60);
                spriteRenderer.color = positiveColor;
                valueText.text = "+" + value;
                break;
            case operatoors.Minus:
                value = Random.Range(5, 60);
                spriteRenderer.color = negativeColor;

                valueText.text = "-" + value;
                break;
            case operatoors.Devide:
                value = Random.Range(2, 5);
                spriteRenderer.color = negativeColor;

                valueText.text = "/" + value;
                break;
            case operatoors.Multiply:
                value = Random.Range(2, 6);
                spriteRenderer.color = positiveColor;
                valueText.text = "X" + value;
                break;
        }
    }
    public int getValue()
    {
        return value;
    }
}
