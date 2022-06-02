using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ayxd;

public class LoseGamePopup : MonoBehaviour
{

    public TextMeshProUGUI Score;

    public void PlayAgain()
    {
        GameManager.Instance.StartGame();
    }

    public void GoHome()
    {
        
    }
}
