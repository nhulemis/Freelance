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
 private void FollowTarget()
    {
        Vector3 newPos= target.position - offset;
        newPos.x = 0;
        newPos.z -= newPos.y;
        this.transform.position =Vector3.Lerp(this.transform.position,Vector3.MoveTowards(this.transform.position,newPos,.5f) ,smoothness);
    }
}
