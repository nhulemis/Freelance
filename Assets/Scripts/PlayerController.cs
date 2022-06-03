using TMPro;
using UnityEngine;
using game_main;

public class PlayerController : MonoBehaviour
{
    private float count = 0f;
    public float defaultForce = 5f;
    private bool isCounting = false;
    public TextMeshProUGUI txtForce;
    [HideInInspector]
    public GameObject OldCol;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

    // Update is called once per frame
    void Update()
    {
         if (!GameMng.Instance.isGameStart)
         {
             return;
         }
         
         if (Input.touches.Length > 0 && GameMng.Instance.isGameOver == false)
         {
             var touch = Input.touches[0];
             if (touch.phase == TouchPhase.Began)
             {
                 isCounting = true;
             }

             if (isCounting)
             {
                 count += 0.3f;
                 float val = count * defaultForce;
                 txtForce.text = $"Force: {val.ToString("0.0")}";
             }

             if (touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended)
             {
                 isCounting = false;
                 Jumping();
                 count = 0f;
             }
         }
// #if UNITY_EDITOR
//
//
//         if (Input.GetKeyDown(KeyCode.Space) && GameMng.Instance.isGameOver == false)
//         {
//             isCounting = true;
//         }
//
//         if (isCounting)
//         {
//             count += 0.05f;
//             float val = count * defaultForce;
//             txtForce.text = $"Force: {val.ToString("0.0")}";
//         }
//         
//         if (Input.GetKeyUp(KeyCode.Space))
//         {
//             isCounting = false;
//             Jumping();
//             count = 0f;
//         }
// #endif
//        
        
        
    }

    private void LateUpdate()
    {
        if (transform.position.y < -5 && GameMng.Instance.isGameOver == false)
        {
            GameMng.Instance.GameLose();
        }
    }

    private void Jumping()
    {
        Vector2 force = Vector2.one * count * defaultForce;
        force.x /= 2;
        rb.AddForce(force);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (OldCol != col.gameObject)
        {
            rb.velocity = Vector2.up;            
            Debug.Log($"Count {count}");
            OldCol = col.gameObject;
            GameMng.Instance.CountScore();
        }
    }

    public void Replay()
    {
        rb.isKinematic = true;
        transform.position = Vector2.up * 3;
        rb.isKinematic = false;
    }
}
