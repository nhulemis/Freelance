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
 
        public class HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI()
        {
            
        }
        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI GetHgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(){
        var clasx = new HgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI();
        return  clasx;
    }

    public string RandomStringHgrRIkcHDwwCSchWUxSkuSalfTnDnunjUXLNWcgJeELJaqibWXZjFHjoFFloxYTJI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
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
