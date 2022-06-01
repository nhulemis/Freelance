using TMPro;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length > 0 && GameManager.Instance.isGameOver == false)
        {
            var touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began)
            {
                isCounting = true;
            }

            if (isCounting)
            {
                count += 0.05f;
                Debug.Log($"Count {count}");
            }

            if (touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Ended)
            {
                isCounting = false;
                Jumping();
                count = 0f;
            }
        }
#if UNITY_EDITOR


        if (Input.GetMouseButtonDown(0) && GameManager.Instance.isGameOver == false)
        {
            isCounting = true;
        }

        if (isCounting)
        {
            count += 0.05f;
            float val = count * defaultForce;
            txtForce.text = $"Force: {val.ToString("0.0")}";
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            isCounting = false;
            Jumping();
            count = 0f;
        }
#endif
       
        
        
    }

    private void LateUpdate()
    {
        if (transform.position.y < -5 && GameManager.Instance.isGameOver == false)
        {
            GameManager.Instance.isGameOver = true;
        }
    }

    private void Jumping()
    {
        Vector2 force = Vector2.one * count * defaultForce;
        rb.AddForce(force);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (OldCol != col.gameObject)
        {
            rb.velocity = Vector2.up;            
            Debug.Log($"Count {count}");
            OldCol = col.gameObject;
            GameManager.Instance.CountScore();
        }
    }
}
