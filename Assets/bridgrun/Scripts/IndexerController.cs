using UnityEngine;

namespace bridgrun.Scripts
{
    public class IndexerController : MonoBehaviour
    {
        private Vector3 indexerOffset=new Vector3(0f,.3f,1f);
        //Serialized Data
        [SerializeField]
        private StairBuilderController stairBuilderControllerl;
        [SerializeField]
        private int currentStairEtape;
        private EnnemyController ennemyController;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))




            {
                CharacterManager characterManager = collision.gameObject.GetComponent<CharacterManager>();
                bool canBuild = characterManager.canBuild();
                string characterColor = characterManager.getColor();
                if (canBuild)
                {
                    build(characterColor);
                }

            }
            if (collision.gameObject.CompareTag("EndStaird"))
            {
                Destroy(this.gameObject);
            }
            if (collision.gameObject.CompareTag("Ennemie"))
            {
                ennemyController = collision.gameObject.GetComponent<EnnemyController>();
                string ennemyColor = ennemyController.getColor();
                bool canEnemyBuild = ennemyController.canBuild();
                if (canEnemyBuild)
                {
                    build(ennemyColor);

                }
            }
            if (collision.gameObject.CompareTag("index")){
                if (collision.gameObject.transform.position.y > this.transform.position.y)
                {
                
                    Destroy(this.gameObject);

                }

           

            }
        }
        private void moveIndexer()
        {
            this.transform.localPosition += indexerOffset;
        }
        private void build(string color)
        {
            moveIndexer();
            stairBuilderControllerl.addNewStair(color);
        }
        public int getCurrentBuildEtape()
        {
            return currentStairEtape;
        }
    }
}
