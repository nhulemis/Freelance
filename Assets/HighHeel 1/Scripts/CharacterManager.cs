using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float touchSensitivity=2.5f;
    [SerializeField]
    StandsHolder standh;
    [SerializeField]
    float maxx;
    [SerializeField]
    float minx;
    [SerializeField]
    GameObject heelStandEffect;
    public static CharacterManager instance;

     Animator anim;
    //Private Var
    Vector3 firstTouch;
    Vector3 currentTouch;
   
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
 private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
        anim = this.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.currentGameState)
        {
            case GameManager.GameState.play:
                anim.SetBool("Run", true);

                Move();

                break;
        }
    }
    private void Move()
    {
        //check for inputs
        if (Input.GetMouseButtonDown(0))
        {
            firstTouch = Input.mousePosition;
            firstTouch.z = 10f;
            firstTouch = Camera.main.ScreenToWorldPoint(firstTouch);


        }
        if (Input.GetMouseButton(0))
        {
            currentTouch = Input.mousePosition;
            currentTouch.z = 10;
            currentTouch = Camera.main.ScreenToWorldPoint(currentTouch);
        }
        
        float rotx = 0;
        if ((currentTouch-firstTouch).magnitude >.5f) {
            print("hhhhhhh");
             rotx = Input.GetAxis("Mouse X") * touchSensitivity * Mathf.Deg2Rad;
             transform.position += new Vector3(rotx, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), transform.position.y, transform.position.z);

        }

        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            speed = 0;
            print("Finish");
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            GameObject effect = Instantiate(heelStandEffect, other.gameObject.transform.position+Vector3.up*5, Quaternion.identity);
            Destroy(effect, 1f);
            UiManager.instance.enablePopUp(other.gameObject.transform.position);
            AudioController.instance.heelCollect();

            Destroy(other.gameObject);
            AddHeelStand();
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            speed = 0;

            anim.SetBool("Win", true);
            print("Finish");
            UiManager.instance.winLevel();
            GameManager.instance.endPlay();

        }
        if (other.gameObject.CompareTag("Bridge"))
        {
            AudioController.instance.enableSlidingSound();
            anim.SetBool("Balance", true);
        }
        if (other.gameObject.CompareTag("Sliders"))
        {
            AudioController.instance.enableSlidingSound();
            
            anim.SetBool("Slide", true);
        }
        if (other.gameObject.CompareTag("End"))
        {
            AudioController.instance.disableSlidingSound();

            anim.SetBool("Balance", false);
            anim.SetBool("Slide", false);
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            print("Coin");
            AudioController.instance.enableCoinCollectSound();
            Vector3 startPlace = Camera.main.WorldToScreenPoint(other.transform.position);
            CoinManger.instance.animate(startPlace, 5);
            Destroy(other.gameObject);
            UiManager.instance.updateCurrentCollectedCoins();
        }
        if (other.gameObject.CompareTag("DeadArea"))
        {
            UiManager.instance.looseLevel();
            GameManager.instance.endPlay();
        }


    }
    public void loose()
    {
        GameManager.instance.endPlay();
        anim.SetBool("Dead", true);
        UiManager.instance.looseLevel();

    }
   
    private void AddHeelStand()
    {
        standh.UpdateHeelStand();
    }
}
