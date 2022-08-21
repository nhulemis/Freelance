using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace Imposter.Scripts
{
    public class NpcController : MonoBehaviour
    {
        private NavMeshAgent agent;
        public Transform[] destination;
        private int nextTaskIndex;
        private Animator anim;
        public bool tasksEnded;
        public Image img;
        private int totalTasks;
        public GameObject dead;
        public GameObject killPanel;
        public GameObject scarePanel;
        public GameObject tasksPanel;
        public GameObject killButton;
        public GameObject hatObject;
        private Transform imposter;
        public bool isDead;
        public SkinnedMeshRenderer mainMesh;
        public SkinnedMeshRenderer bagMesh;


        // Start is called before the first frame update

        public class khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj
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

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj()
        {
            
        }
        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj GetkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(){
        var clasx = new khsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj();
        return  clasx;
    }

    public string RandomStringkhsqINrJWZCpPZAYnDujlDoJPpiISKaZKlOhBpUXCbbgZGekDsVPNaFhsj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            totalTasks=destination.Length;
            tasksEnded=false;
            nextTaskIndex=0;
            isDead=false;
            agent=this.GetComponent<NavMeshAgent>();
            anim=this.GetComponent<Animator>();
            imposter=PlayerController.instance.getReference();

        }

        // Update is called once per frame
        void Update()
        {
            switch(GameManager.instance.currentState){
                case GameManager.GameState.play:
                    //killButton.transform.LookAt(Camera.main.transform); 
                    killPanel.transform.LookAt(Camera.main.transform);   
  
                    showKillPanel();
                    if(!tasksEnded)
                        gooNextTask();
                    break;
                case GameManager.GameState.end:
                    enableScarePanel();
                    break;
            }

    	

        }

       
        public class eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr
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

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr()
        {
            
        }
        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr GeteBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(){
        var clasx = new eBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr();
        return  clasx;
    }

    public string RandomStringeBrFEtqSkJsZPTUffdWCumKjsMjUthUczOugckulyGcvtKERJSIJr(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void gooNextTask(){
            if(Vector3.Distance(this.transform.position,destination[nextTaskIndex].position)>1 && !isDead){
                move();
            }else{
                if(nextTaskIndex<totalTasks){
                    anim.SetFloat("Speed",-1f);
                    performeTask();

                }
    		 

            }
        }
        private void move(){
            anim.SetFloat("Speed",1f);
            agent.SetDestination(destination[nextTaskIndex].position);
        }
        private void performeTask(){
            tasksPanel.SetActive(true);
            float cuurentProgress=img.fillAmount;

            if(cuurentProgress<1){
                cuurentProgress+=Time.deltaTime/10;
                img.fillAmount=cuurentProgress;

                print("Performing Task N:"+nextTaskIndex);

            }else{
                if(!tasksEnded && nextTaskIndex<totalTasks-1){
                    img.fillAmount=0f;
                    nextTaskIndex++;
                    print("Task Index : "+nextTaskIndex+"Ended");
                } else{

                    tasksEnded=true;
                    CrewMateManager.instance.taskEnded();

             
                }              
            }
        }
        public void performDead(){
            tasksPanel.SetActive(false);

            agent.Stop();
            dead.transform.position=this.transform.position;
            dead.SetActive(true);
            isDead=true;
            mainMesh.enabled=false;
            bagMesh.enabled=false;
            if(hatObject){
                hatObject.SetActive(false);
            }
            this.gameObject.GetComponent<NpcController>().enabled=false;
            killPanel.SetActive(false);
            CrewMateManager.instance.deadCrew();
    
        }
        private void showKillPanel(){
            if(Vector3.Distance(this.transform.position,imposter.position)<3){
                killPanel.SetActive(true);

            }else{
                killPanel.SetActive(false);

            }


        }
        private void OnTriggerStay(Collider other){
            if(other.gameObject.CompareTag("Crewmate")){
                bool isDead=false;

                isDead=other.gameObject.GetComponent<NpcController>().isDead;
                if(isDead){
                    // UiManager.instance.loose();
                    GameManager.instance.endGame();
                    tasksPanel.SetActive(false);
                    CamerController.instance.changeTarget(this.transform);
                    agent.Stop();
                    Invoke("looseDelay",3f);
                    anim.SetTrigger("Scare");
                    killPanel.SetActive(false);
                    scarePanel.SetActive(true);
                    print("Yooooooo Imposter");
                }

            }

        }
        private void looseDelay(){
            UiManager.instance.loose();

        }
        private void enableScarePanel(){
            killPanel.SetActive(false);
            scarePanel.SetActive(true);
            tasksPanel.SetActive(false);

        }

    }
}
