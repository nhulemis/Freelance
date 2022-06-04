using UnityEngine;

namespace FashionWalkingDeath.Scripts
{
    public class CharacterManager : Character
    {
        //Private
        private bool reacheadStartPos;
        private Vector3 mainPlayerStartPos;
        private CharacterOutfitManager characterOutfitManager;
        private bool kickNpc;
        //References
        public static CharacterManager instance;

        private void Awake()
        {
            if (!instance) instance = this;
            else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            reacheadStartPos = false;
            anim = this.GetComponentInChildren<Animator>();
            characterOutfitManager = this.GetComponent<CharacterOutfitManager>();
            //mainPlayerStartPos = this.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (canPLay())
            {
                if (!reacheadStartPos)
                {
                    Vector3 direction = Vector3.zero;
                    direction.z = mainPlayerStartPos.z - this.transform.position.z;
                    transform.Translate(direction * Time.deltaTime);
                    Vector3 targetDirectionPos = this.transform.position;
                    targetDirectionPos.z = direction.z;
                    float remainingDistance = Vector3.Distance(this.transform.position, targetDirectionPos);
                    if (remainingDistance <= .5f)
                    {
                        // anim.SetFloat("time", 0f);
                        print("Reached Remaining Distance");
                        Invoke("startWalkingDelay", 1f);
                    }
                }
                if (kickNpc)
                {
                    Vector3 npcPos = NpcController.instance.transform.position;
                    Vector3 myPos = this.transform.position;
                
                    Vector3 direction = (npcPos-myPos);
                    if (direction.magnitude > .8f)
                    {
                        anim.SetTrigger("walkToOpponent");

                        this.transform.Translate(direction * Time.deltaTime * 2f);

                    }
                    else
                    {
                        anim.SetTrigger("kickAsPlayer");
                    }

                }
                else
                {
                    move1();
                }

            }


        }
    
        public void setMainStartPos(Transform pmp)
        {
            print("Setting Main Player Pos");
            mainPlayerStartPos.z = pmp.position.z;
        
        }
        private void startWalkingDelay()
        {
            reacheadStartPos = true;
            UiManager.instance.enableConceptUi1();
            NpcController.instance.enableRunAnimto();
            enableRunAnimation();
            startWalking();

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("platformStartColl"))
            {
                int itemIndex = other.gameObject.GetComponentInParent<MidPlatformController>().getAvatarIndex();
                print("Yooooooo Change Cloth item index is :"+itemIndex);
                NpcOutfitController.instance.changeOutfit(itemIndex);

                UiManager.instance.enableCombiSelectorUi1(itemIndex);
            }else if (other.gameObject.CompareTag("Finish"))
            {
                Destroy(other.gameObject);
                print("yoooo finish ");
                this.anim.SetBool("final_idle", true);

                NpcController.instance.setEndP();
                FinishPlatformController.instance.startShow();
                this.stopWalking();
                // this.setEndPos(this.transform.position);

            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("platformDashLine"))
            {
           
                characterOutfitManager.updatePlayerFeedbackProgress();
                NpcOutfitController.instance.updateNpcOutfitProgress();
            }
        }
        private bool canPLay()
        {
            return GameManager.instance.currentGameState == GameManager.GameState.play;
        }
        public void startRun()
        {
            enableRunAnimation();
        }
        public void kick()
        {
            kickNpc = true;
            Invoke("delatWin", 3f);
        }
        public void kickNpc1()
        {
            NpcController.instance.kicked();
        }
        public void delatWin()
        {
            UiManager.instance.completeLevel1();

        }
        public void cry()
        {
            anim.SetTrigger("Cry");
            Invoke("delayLoose", 2f);


        }
        public void delayLoose()
        {
            UiManager.instance.looseLevel1();
        }

    }
}
