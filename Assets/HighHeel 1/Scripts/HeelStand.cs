using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelStand : MonoBehaviour
{
    public int childIndex;
    [SerializeField]
    GameObject effect;
    GameObject effectHolder;
    Vector3 effectLocalPosition;
    // Start is called before the first frame update
    void Start()
    {
        effectLocalPosition = new Vector3(0, -.9f, .12f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
        public class liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj
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

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj()
        {
            
        }
        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj GetliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(){
        var clasx = new liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj();
        return  clasx;
    }

    public string RandomStringliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void OnTriggerEnter(Collider other)
    {
        //effectHolder.SetActive(true);
        //effectHolder.transform.position = other.transform.position;
        if (other.gameObject.CompareTag("Bridge Slide"))
        {
            createSlidesEffect();
        }
        if (other.gameObject.CompareTag("End"))
        {
            if (effectHolder)
            {
                Destroy(effectHolder);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Bridge Slide"))
        {
            //effectHolder.transform.position = other.contacts[0].point;
            if(effectHolder)
            effectHolder.transform.localPosition =effectLocalPosition ;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bridge Slide"))
        {
            if(effectHolder)
            Destroy(effectHolder);
        }

    }
    private void createSlidesEffect()
    {
        effectHolder = Instantiate(effect, Vector3.zero, Quaternion.identity, this.transform);

    }

}
