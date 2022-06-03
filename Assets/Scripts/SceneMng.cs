using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMng : MonoBehaviour
{
    public Canvas mainCanvas;

    public GameObject LoseGamePopup;

    private void Start()
    {
        mainCanvas = FindObjectOfType<Canvas>();
    }

    public void LoseGame()
    {
        LoseGamePopup.SetActive(true);
    }
}
