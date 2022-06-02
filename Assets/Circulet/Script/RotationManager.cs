using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        if (TheGlobals.playingMode)
        {
            if (Input.GetMouseButtonDown(0) && Time.timeScale > 0f)
            {
                rotationSpeed = rotationSpeed * -1;
            }

            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
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
}
