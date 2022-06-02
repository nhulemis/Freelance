using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using game_main;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    public GameObject btnTouchMe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void convert()
    {
        float fValue = 0.123456f;
        int iValue = (int)fValue;
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.FloorToInt(fValue);
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.CeilToInt(fValue);
        Debug.Log("int val: " +iValue);
         
        iValue = Mathf.RoundToInt(fValue);
        Debug.Log("int val: " +iValue);
    }

    public void TouchMe()
    {
        var hafScreenWidth = Screen.width /2 ;
        var hafScreenHeight = Screen.height /2 ;

        var y = Random.Range(-hafScreenHeight, hafScreenHeight);
        var x = Random.Range(-hafScreenWidth, hafScreenWidth);

        btnTouchMe.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
    }

    public void GameStart()
    {
        GameManager.Instance.StartGame();
        gameObject.SetActive(false);
    }

    public void StartGameX()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SaySomething(string message)
    {
        showToast(message,1);
    }
    
    public void SayHello()
    {
        showToast("Hello! What's your name",1);
    }
    
    public TextMeshProUGUI txt;

    void showToast(string text,
        int duration)
    {
        StartCoroutine(showToastCOR(text, duration));
    }

    private IEnumerator showToastCOR(string text,
        int duration)
    {
        Color orginalColor = txt.color;

        txt.text = text;
        txt.enabled = true;

        //Fade in
        yield return fadeInAndOut(txt, true, 0.5f);

        //Wait for the duration
        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            yield return null;
        }

        //Fade out
        yield return fadeInAndOut(txt, false, 0.5f);

        txt.enabled = false;
        txt.color = orginalColor;
    }

    IEnumerator fadeInAndOut(TextMeshProUGUI targetText, bool fadeIn, float duration)
    {
        //Set Values depending on if fadeIn or fadeOut
        float a, b;
        if (fadeIn)
        {
            a = 0f;
            b = 1f;
        }
        else
        {
            a = 1f;
            b = 0f;
        }

        Color currentColor = Color.clear;
        float counter = 0f;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            float alpha = Mathf.Lerp(a, b, counter / duration);

            targetText.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
            yield return null;
        }
    }
}
