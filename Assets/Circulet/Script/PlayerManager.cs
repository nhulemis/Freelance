using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    GameObject crashParticle;

    UIController _uiController;


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

    private void OnEnable()
    {
        _uiController = FindObjectOfType<UIController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            // TheGlobals.sManager.allAudio[2].Play();

            collision.gameObject.SetActive(false);
            
            crashParticle.transform.position = transform.position;
            crashParticle.SetActive(true);

            Camera.main.GetComponent<CameraShake>().ShakeCamera(0.6f);

            _uiController.GameOver();

            gameObject.SetActive(false);
        }

        if (collision.gameObject.layer == 9)
        {
            collision.enabled = false;
            // TheGlobals.sManager.allAudio[1].Play();
            collision.gameObject.GetComponent<AddInScore>().moveTowardsTarget = true;           
        }
    }
}
