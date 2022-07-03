using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class ThemeColor : MonoBehaviour
{
    [SerializeField] private Color background;

    [SerializeField] private Color itemArea;

    [SerializeField] private Color highlight;

    [SerializeField] private Image[] sprBackgrounds;
    [SerializeField] private Image[] sprItemAreas;
    [SerializeField] private Image[] sprHighLights;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        foreach (var bg in sprBackgrounds)
        {
            bg.color = background;
        }

        foreach (var sprItemArea in sprItemAreas)
        {
            sprItemArea.color = itemArea;
        }

        foreach (var sprHighLight in sprHighLights)
        {
            sprHighLight.color = highlight;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
