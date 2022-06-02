using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [Header("Object to follow")]
    public GameObject TargetXFollow;
    [Header("Follow speed")]
    [Range(0.0f, 50.0f)]
    public float speed = 6f;

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
    [Header("Camera Offset")]
    [Range(-10.0f, 10.0f)]
    public float xOffset;

    [Space(15)]
    public UIManager uIManager;

    float interpolation;
    Vector3 position;

    void Start()
    {
    }

    //camera follow the player
    void LateUpdate()
    {
        if (uIManager.gameState == GameState.PLAYING)
        {
            interpolation = speed * Time.deltaTime;

            position = transform.position;

            if (TargetXFollow.transform.position.x + xOffset > transform.position.x)
                position.x = Mathf.Lerp(transform.position.x, TargetXFollow.transform.position.x + xOffset, interpolation);

            transform.position = position;
        }
    }
}