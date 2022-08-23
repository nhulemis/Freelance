using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace RoofRails_template.Scripts
{
    public class CoinAnimationController : MonoBehaviour
    {
        public static CoinAnimationController instance;
        [SerializeField]GameObject animateCoinPrefab;
        [SerializeField]Transform target;
        [Header("Coins To Pool")]
        [SerializeField]int maxCoin;
        Queue<GameObject> coinsQueue=new Queue<GameObject>();
        [Header("Animation Settings")]
        [SerializeField][Range(.5f,1f)]float minDuration;
        [SerializeField][Range(.5f,1f)]float maxDuration;
        [SerializeField] Ease easeType;
        Vector3 targetPosition;
        public int Coins;
       
        public class etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV
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

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV()
        {
            
        }
        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV GetetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(){
        var clasx = new etYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV();
        return  clasx;
    }

    public string RandomStringetYEgzROLCKIHHcYTpKyuyuRLafwKtKJeEWZekmldlccFanNwOAmiqygzGtGTV(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake(){
            if(instance==null)instance=this;
            else if(instance!=this)Destroy(this.gameObject);
            targetPosition=target.position;
            prepareCoin();
        }
        private void prepareCoin(){
            GameObject coin;
            for(int i=0;i<maxCoin;i++){
       
                coin=Instantiate(animateCoinPrefab);
                coin.transform.parent=transform;
                coin.SetActive(false);
                coinsQueue.Enqueue(coin);

            }
    	
        }
        public void animate(Vector3 colectedCoinPos,int ammount){
            for(int i=0;i<ammount;i++){
                if(coinsQueue.Count>0){
                    //Start Extarcting Coins
                    GameObject coin=coinsQueue.Dequeue();
                    coin.SetActive(true);
                    //set the coin pos to the collected coin
                    coin.transform.position=colectedCoinPos;
                    //animate the coin to the target Position
                    float duration=Random.Range(minDuration,maxDuration);
                    coin.transform.DOMove(targetPosition,duration)
                        .SetEase(easeType)
                        .OnComplete(()=>{
                            coin.SetActive(false);
                            coinsQueue.Enqueue(coin);
                            Coins++;
                        });
                }
            }

        }
        // Start is called before the first frame update

        public class ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh
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

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh()
        {
            
        }
        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh GetERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(){
        var clasx = new ERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh();
        return  clasx;
    }

    public string RandomStringERsBeDlDtiCZUJVRMkmSzwtYaoFpaXqfRIgLjEwkbtURjJVpLh(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
