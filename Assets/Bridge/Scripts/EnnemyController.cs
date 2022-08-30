using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnnemyController : MonoBehaviour
{
    //Serialized Data
    [SerializeField]
    private BoxContainerController boxContainerController;
    public Transform destination;
    private NavMeshAgent agent;
    //Private Data
    private Animator anim;
    public string color;
    public int currentEtape;
    private bool canBuildStairs;
    public Transform stairToBuildTemp;
    public IndexerController[] indexC;

    // Start is called before the first frame update
   
        public class HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq
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

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq()
        {
            
        }
        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq GetHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(){
        var clasx = new HUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq();
        return  clasx;
    }

    public string RandomStringHUZqlFYAmQiAWcTognUAWmTDGHhHoaWyKBlmwKjKneIHraMSPMRlHsfVBVjdXRMMtkq(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj
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

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj()
        {
            
        }
        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj GetlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(){
        var clasx = new lFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj();
        return  clasx;
    }

    public string RandomStringlFlIRSOnBmuTngMZjJOBgQWSMoTLnJoWRtbniIaFNfCQKAnAaAPhWmBUj(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR
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

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR()
        {
            
        }
        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR GetxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(){
        var clasx = new xynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR();
        return  clasx;
    }

    public string RandomStringxynistgxgSkQmacLamcSCTMhoiWfWKLcnNEVqAKdyR(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI
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

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI()
        {
            
        }
        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI GetOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(){
        var clasx = new OzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI();
        return  clasx;
    }

    public string RandomStringOzcaikGAFwqvIUPUkpwWwOTAapByVIRWGUudwvXjTbtXuGojfUeuI(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake()
    {

        agent = this.gameObject.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
        currentEtape = 0;


    }

        public class VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk
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

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk()
        {
            
        }
        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk GetVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(){
        var clasx = new VqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk();
        return  clasx;
    }

    public string RandomStringVqgsWDJNreLMguPscIlqSWPlaaGnWSvNGkrbjUvixforqIDjIYk(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx
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

        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx()
        {
            
        }
        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx GetSwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(){
        var clasx = new SwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx();
        return  clasx;
    }

    public string RandomStringSwdzCArxYBtFZqaiIoBOFHMBSlnuHAfrGEPMx(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm
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

        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm()
        {
            
        }
        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm GetRPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(){
        var clasx = new RPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm();
        return  clasx;
    }

    public string RandomStringRPdttGvRvYNokdmGtKXBbVHIdZWGUZbzUkCwEvoPjFPm(int length)
    {
        string chars = string.Empty;
        return chars;
    }
    void Start()
    {
        indexC = FindObjectsOfType<IndexerController>();
        switchStairsToBuild();
        setNextTarget();
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.instance.currentGameState)
        {
            case GameManager.GameState.play:
                if (destination != null)
                    agent.SetDestination(destination.position);
                else
                {
                    if(stairToBuildTemp!=null)
                    {
                        destination = stairToBuildTemp;
                    }
                    else
                    {
                        switchStairsToBuild();
                        destination = stairToBuildTemp;

                    }
                }
        
               break;
            case GameManager.GameState.end:
                agent.enabled = false;
                anim.SetBool("Run",false);
                break;
        }      
         
    }
    private void collectStairPices()
    {

    }
    private void buildStairs()
    {
        destination = stairToBuildTemp;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (canPlay())
        {
            if (other.gameObject.CompareTag("CollectableStair"))
            {
                destination = null;
                StairController stairController = other.gameObject.GetComponent<StairController>();

                if (stairController.getColor() == this.color)
                {
                    stairController.canbeCollected = false;
                    boxContainerController.addNewStair(other.gameObject.transform);
                }
              
                setNextTarget();

            }
            if (other.gameObject.CompareTag("Done"))
            {
                GameManager.instance.endPlay();
                UiManager.instance.playerLoose();
                print("Yoooooo Ennemy Win");
            }
            if (other.gameObject.CompareTag("PlayerStandsStair"))
            {
                canBuildStairs = getCurrentCollectedStairs() > 0;
                if (canBuildStairs)
                {
                    boxContainerController.removeStair();
                    other.gameObject.transform.parent.GetComponent<StairBuilderController>().addNewStairByPos(other.gameObject.transform.localPosition, this.color);
                    Destroy(other.gameObject);

                }
                else
                {
                    StairsManager.instance.makecollectables(currentEtape, true, this.color);
                    setNextTarget();
                }
            }
            if (other.gameObject.CompareTag("EnnemieBuildStairs"))
            {
                if (other.gameObject.GetComponent<StandStairsManager>().color != this.color)
                {
                    canBuildStairs = getCurrentCollectedStairs() > 0;
                    if (canBuildStairs)
                    {
                        boxContainerController.removeStair();
                        other.gameObject.transform.parent.GetComponent<StairBuilderController>().addNewStairByPos(other.gameObject.transform.localPosition, this.color);
                        Destroy(other.gameObject);

                    }
                    else
                    {
                        StairsManager.instance.makecollectables(currentEtape, true, this.color);
                        setNextTarget();
                    }
                }
            }
        }
        


    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Done"))
        {
            GameManager.instance.endPlay();
        }     
    }
    private IndexerController currentIndex;
    private void OnCollisionEnter(Collision collision)
    {
        if (canPlay())
        {
            if (collision.gameObject.CompareTag("EndStaird"))
            {
                print("Yoooo Ennemy Passing new Staris");
                currentEtape = currentIndex.getCurrentBuildEtape() + 1; ;
                StairsManager.instance.makecollectables(currentEtape, true, this.color);
                setNextTarget();
                switchStairsToBuild();

            }
            if (collision.gameObject.CompareTag("index"))
            {
                currentIndex = collision.gameObject.GetComponent<IndexerController>();
                canBuildStairs = getCurrentCollectedStairs() > 0;
                if (canBuildStairs)
                {
                    boxContainerController.removeStair();
                }
                else
                {
                    StairsManager.instance.makecollectables(currentEtape, true, this.color);
                    setNextTarget();
                }
            }
        }
       
       
        
      
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("index"))
        {
            canBuildStairs = getCurrentCollectedStairs() > 0;
            if (canBuildStairs)
            {
                boxContainerController.removeStair();
            }
            else
            {
                StairsManager.instance.makecollectables(currentEtape, true, this.color);
                setNextTarget();
            }
        }
    }
    public void setNextTarget()
    {
        destination = null;
        destination = StairsManager.instance.getNextTarget(this.color,currentEtape);
        //All Collectables Are Colllected
        if (destination == null)
        {
            //Complete Stairs Building Process
            if(getCurrentCollectedStairs()>0)
              buildStairs();
            else
            {
                StairsManager.instance.makecollectables(currentEtape, true, this.color);
                destination = StairsManager.instance.getNextTarget(this.color, currentEtape);
            }
        }

    }
    public string getColor()
    {
        return color;
    }
    private void switchStairsProvider()
    {

    }
    public void switchStairsToBuild()
    {
        print("Ennemy Switch Platform");
       List<IndexerController> indexCT= new List<IndexerController>(); ;

        foreach (IndexerController index in indexC)
        {
            if (index != null)
            {
                int currentStairsLevel = index.getCurrentBuildEtape();
                if (currentStairsLevel == currentEtape)
                {
                    indexCT.Add(index);

                }
            }
            
            
            
        }
        int randomStairToBuild = Random.Range(0, indexCT.Count-1);
        if (indexCT.Count == 1)
            randomStairToBuild = 0;

        stairToBuildTemp = indexCT[randomStairToBuild].transform;
    }
    public int getCurrentCollectedStairs()
    {
        return boxContainerController.getTotalCollectedStairPices();
    }
    public bool canBuild()
    {
        return canBuildStairs;
    }
    public int getCurrentEtape()
    {
        return currentEtape;
    }
    public void classiffy(Vector3 Pos)
    {
        anim.SetBool("Run", false);
        this.agent.enabled = false;
        this.transform.position = Pos;
    }
    private bool canPlay()
    {
        if (GameManager.instance.currentGameState == GameManager.GameState.play)
            return true;
        else
            return false;
    }


}
