using System.Collections;
using UnityEngine;

namespace CubeSurfing.scripts
{
    public class player : MonoBehaviour
    {
        public Animator anim;
        public static player Instances;
        public Texture mTexture;
        public Material mat;
        Renderer render;
        // Start is called before the first frame update
        void Start()
        {
            if (Instances == null)
                Instances = this;
            else
            {
                if (Instances != this)
                    Destroy(this);
            }
            render=this.GetComponent<Renderer>();
            mat.mainTexture =mTexture;
            activateCharactere();
        }

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


        }class Book
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            public Book(string title, string publisher, string? isbn)
                => (Title, Publisher, Isbn) = (title, publisher, isbn);

            public Book(string title, string publisher)
                : this(title, publisher, null) { }

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
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
        class SHUQAOXMAhxjuoa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
			

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class SHUQAOXMAhxjuoaUQLA
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
        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Barriere"  || collision.gameObject.tag == "water")
            {
                CharactereController.state = CharactereController.gameState.stop;
                GameManager.Instance.gameloose();
            }else if (collision.gameObject.tag == "Finish")
            {
                CamController.instance.startTurning();
                anim.SetBool("Dance", true);
                CharactereController.state = CharactereController.gameState.stop;
                GameManager.Instance.gameWin();
                GameManager.Instance.addLevel();

            }
        }
        public void jump()
        {
            StartCoroutine("start_jump");

        }
        private IEnumerator start_jump()
        {
            anim.SetBool("Fall", true);
            yield return new WaitForSeconds(0.3f);
            anim.SetBool("Fall", false);

        }
        private void activateCharactere(){
            int  charactereLength=this.transform.childCount;
            int selectedChatactere=PlayerPrefs.GetInt("SelectedCharactere");
            for(int i=0;i<charactereLength;i++){
                this.transform.GetChild(i).gameObject.SetActive(false);

            }
            GameObject obj =    this.transform.GetChild(selectedChatactere).gameObject;
            obj.SetActive(true);
            anim=obj.GetComponent<Animator>();


        }
    }
}
