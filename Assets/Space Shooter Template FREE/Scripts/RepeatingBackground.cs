using UnityEngine;

/// <summary>
/// This script attaches to ‘Background’ object, and would move it up if the object went down below the viewport border. 
/// This script is used for creating the effect of infinite movement. 
/// </summary>

public class RepeatingBackground : MonoBehaviour
{
    [Tooltip("vertical size of the sprite in the world space. Attach box collider2D to get the exact size")]
    public float verticalSize;
    
    private void Update()
    {
        if (transform.position.y < -verticalSize) //if sprite goes down below the viewport move the object up above the viewport
        {
            RepositionBackground();
        }
    }

    public class zchjkxjkoasdjkl
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class xzcojviojas
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    public class JCoiaklwOJCJK
    {
      private int a;
      public int b;
      public float c;
      public float d;
      public bool x;
    }
    void RepositionBackground() 
    {
        Vector2 groundOffSet = new Vector2(0, verticalSize * 2f);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
