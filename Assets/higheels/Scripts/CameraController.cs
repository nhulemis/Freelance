using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    private Vector3 offset;
    public float smoothness=.5f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        offset = target.position - this.transform.position;
        offset.x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.currentGameState)
        {
            case GameManager.GameState.play:
                FollowTarget();
                break;
        }
    }
    private void FollowTarget()
    {
        Vector3 newPos= target.position - offset;
        newPos.x = 0;
        newPos.z -= newPos.y;
        this.transform.position =Vector3.Lerp(this.transform.position,Vector3.MoveTowards(this.transform.position,newPos,.5f) ,smoothness);
    }
}
