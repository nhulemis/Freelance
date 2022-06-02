using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SceneManager : MonoBehaviour
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
    public static void ExampleAsync()
    {
        // string[] lines = { "First line", "Second line", "Third line" };
        // using StreamWriter file = new("WriteLines2.txt");
        //
        // foreach (string line in lines)
        // {
        //     if (!line.Contains("Second"))
        //     {
        //         await file.WriteLineAsync(line);
        //     }
        // }
    }
}
