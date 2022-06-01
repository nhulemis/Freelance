using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public List<GameObject> enableList;
    public List<GameObject> disableList;

    private void OnEnable()
    {
        foreach (var item in enableList)
        {
            item.SetActive(true);
        }

        foreach (var item in disableList)
        {
            item.SetActive(false);
        }
    }

}
