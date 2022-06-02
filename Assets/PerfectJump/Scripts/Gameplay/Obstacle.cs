using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int index;
    public bool hit;

    void OnBecameInvisible()
    {
        if (GameManager.Instance.cam != null)
            if (transform.position.x < GameManager.Instance.cam.transform.position.x || transform.position.y < -10)
                Destroy(gameObject);
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
