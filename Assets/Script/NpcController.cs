using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public Collider trigger;
    public bool patroll;
    //Serialized Data
    [SerializeField]
    private Transform right;
    [SerializeField]
    private Transform left;
    [SerializeField]
    private Animator anim;

    private bool rightDirection;
    // Start is called before the first frame update
    void Start()
    {
        trigger = this.GetComponentInChildren<Collider>();
        rightDirection = true;
        if (patroll)
            anim.SetFloat("Speed", .8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (patroll)
        {
            if (rightDirection)
            {
                Vector3 direction = right.localPosition - this.transform.localPosition;
                this.transform.LookAt(right);
                transform.Translate(direction.normalized*Time.deltaTime);
                float distanceToreach = Vector3.Distance(this.transform.localPosition, right.localPosition);
                if (distanceToreach < .1f)
                {
                    rightDirection = false;
                }
            }
            else
            {
                Vector3 direction = this.transform.localPosition-left.localPosition ;
                this.transform.LookAt(left);
                transform.Translate(direction.normalized * Time.deltaTime);
                float distanceToreach = Vector3.Distance(this.transform.localPosition, left.localPosition);
                if (distanceToreach <.1f)
                {
                    rightDirection = true;
                }
            }
        }
    }
    public void crached()
    {
        trigger.enabled = false;
    }
}
