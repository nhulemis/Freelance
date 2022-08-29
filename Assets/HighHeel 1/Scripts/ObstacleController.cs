using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
 private void OnCollisionEnter(Collision other)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HeelStand"))
        {
            Destroy(other.gameObject);
            AudioController.instance.enabledropHeelSound();
            //other.gameObject.transform.parent = null;
            int childIndex = other.gameObject.GetComponent<HeelStand>().childIndex;
            StandsHolder.instance.removeChild(childIndex);
        }
        if (other.gameObject.CompareTag("PlayerHips"))
        {
            
            CharacterManager.instance.loose();
        }

    }
}
