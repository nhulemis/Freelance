using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using game_main;
public class LoseGamePopup : MonoBehaviour
{
    public TextMeshProUGUI Score;

    public void PlayAgain()
    {
        GameMng.Instance.StartGame();
    }

}
