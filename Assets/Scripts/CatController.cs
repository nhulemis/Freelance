using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CatController : MonoBehaviour
{
    private bool isGoal = false;
    // Start is called before the first frame update
    public bool isPlayer;

    public Vector3 startPos;
    void Awake()
    {
        startPos = transform.position;
    }

    private bool isAllowJump = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length > 0)
        {
            var touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began)
            {
                CatJump();
            }
        }
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CatJump();
        }
#endif
    }

    private void CatJump()
    {
        if (!isAllowJump || isGoal)
        {
            return;
        }

        isAllowJump = false;
        var y = Random.Range(0.1f, 0.7f);
        var pos = new Vector3(transform.position.x, transform.position.y + y, 0);
        transform.DOJump(pos, y+0.15f, 1, 0.5f).onComplete = OnJumpComplete;
    }

    private void OnJumpComplete()
    {
        isAllowJump = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (isPlayer && col.CompareTag("Goal"))
        {
            Debug.Log("complete");
            GameManager.Instance.sceneMng.LoseGame();
        }

        if (col.CompareTag("Goal"))
        {
            isGoal = true;
        }
        
        
    }

    public void ReplayGame()
    {
        isGoal = false;
        transform.position = startPos;
    }
}
