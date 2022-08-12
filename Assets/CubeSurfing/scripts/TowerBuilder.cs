using System.Collections;
using UnityEngine;

namespace CubeSurfing.scripts
{
    public class TowerBuilder : MonoBehaviour
    {
        public float y_offset=0f;
        public Material color;
        public GameObject baseo;
        public AudioSource cubeCollectSound;
        public AudioSource cubeDropSound;
        public AudioSource speedUp;
        public AudioSource coin;
        public GameObject magnetTool;
        public GameObject coinCollectEffect;
        public GameObject towerBuildEffect;
        private CoinManger coinM;
        [SerializeField] Transform  charactereStand;
        private Vector3 towerBuildEffectPositio;
        GameObject current_up;
        public static TowerBuilder instance;

        public class Timea
        {
            // public methods
            public void DisplayCurrentTime(  )
            {
                    
            }

            // private variables
            int Year;
            int Month;
            int Date;
            int Hour;
            int Minute;
            int Second;


        }
        class BookSUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class ABCUXLA
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SJIQlakow
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMAhxjuoa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWU
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQ
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSƯxaw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsss
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQ
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQSOAAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQaaw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQriaisWUXIQSSsssSUQaawSxiws
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
		class USOZJAHUWhusw
		{
			public string Title { get; }
			public string Publisher { get; }
			public string? Isbn { get; }
			

			public void Deconstruct(out string title, out string publisher, out string? isbn)
				=> (title, publisher, isbn) = (Title, Publisher, Isbn);

			public override string ToString() => Title;
		}
        class USOZJAHUWxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        // public GameObject player;
        void Awake(){
            if(instance==null)instance=this;
        }
        // Start is called before the first frame update
        void Start()
        {
            coinM=GameObject.FindGameObjectWithTag("CoinAnimator").GetComponent<CoinManger>();
            current_up = baseo;
            towerBuildEffectPositio=charactereStand.localPosition;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "towerbuild")
            {

                if (color.color == other.gameObject.GetComponent<MeshRenderer>().material.color)
                {
                    cubeCollectSound.Play();
                    player.Instances.jump();
                    current_up.tag = "Untagged";

                    current_up = other.gameObject;
                    //add 1 units to each child
                    GameManager.Instance.addScore(other.gameObject.transform.position);

                    //add the cube to the build
                    addToBuilding(other.gameObject);
        
                }
                else
                {
                    int childSize = transform.childCount;
                    if (childSize > 1)
                    {

                        this.transform.GetChild(childSize - 1).transform.parent = null;
                    }
                    else
                    {

                        CharactereController.state = CharactereController.gameState.stop;
                        GameManager.Instance.gameloose();
                    }
                
                }
            } if (other.gameObject.tag == "SpeedUp")
            {
                //print("Yeahhh More Speed");
                speedUp.Play();
                CharactereController.instance.changeSpped(10);
                CamController.instance.activateSpeed();
            }if (other.gameObject.tag == "Coin")
            {
                // print("Yeahhh More Money");
                print("coin");
                Instantiate(coinCollectEffect,other.gameObject.transform.position,Quaternion.identity);
                coinM.animate(Camera.main.WorldToScreenPoint(other.transform.position),1);
                GameManager.Instance.increementMoney();
                Destroy(other.gameObject);
                coin.Play();
           
            }if (other.gameObject.tag == "Barriere" ||other.gameObject.tag == "Finish" )
            {
                cubeDropSound.Play();
           
            }if (other.gameObject.tag == "Magnet")
            {
                Destroy(other.gameObject);
                StartCoroutine("activateMagnet");
           
            }
           
        }
        IEnumerator activateMagnet(){
            magnetTool.SetActive(true);
            yield return new WaitForSeconds(2.5f);
            magnetTool.SetActive(false);

        }
        public void addToBuilding(GameObject cube)
        {
        
       
            for (int i=0; i < cube.transform.childCount; i++)
            {
            
                makeGap();
                    
            }
       
            makeGap();
            cube.transform.parent = this.transform;
            cube.transform.localPosition = new Vector3(0f, y_offset, -.4f);
            GameObject effect= Instantiate(towerBuildEffect,new Vector3(0f, y_offset, 0f),Quaternion.identity,this.transform);
            effect.transform.localPosition=charactereStand.localPosition;
            Destroy(effect,4f);
            print(cube.transform.childCount);
            for (int i = cube.transform.childCount-1; i >=0 ; i--)
            {

                GameManager.Instance.addScore(cube.transform.GetChild(i).gameObject.transform.position);
                cube.transform.GetChild(i).gameObject.transform.parent = this.transform;
     
            }


      
        }
        private void remouveChild(GameObject other)
        {
            Destroy(other);
       
            Destroy(this.transform.GetChild(0).gameObject);
        }
        private void hasChildes(GameObject obj)
        {
            if (obj.gameObject.transform.childCount > 0)
            {
                obj.tag = "Untagged";
                int childnum = obj.gameObject.transform.childCount;
                for (int i = 0; i < childnum; i++)
                {
                    if (i  == childnum-1)
                    {

                        obj.gameObject.transform.GetChild(childnum - 1).transform.gameObject.tag = "up";
                        current_up = obj.gameObject.transform.GetChild(childnum - 1).transform.gameObject;
                    }
                    else
                    {
                        obj.gameObject.transform.GetChild(i).transform.gameObject.tag = "Untagged";
                    }
                }
            
            }
            else
            {
                current_up = obj;
                current_up.tag = "up";
            }
        }
        private void makeGap()
        {
       
            for(int i = 0; i < this.transform.childCount; i++)
            {
                this.transform.GetChild(i).gameObject.transform.Translate( new Vector3(0,1,0));
            }
        }
    }
}
