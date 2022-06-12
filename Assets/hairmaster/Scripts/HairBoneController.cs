using UnityEngine;

namespace hairmaster.Scripts
{
    public class HairBoneController : MonoBehaviour
    {

        public BonesRootController bns;
        public Vector3 currentHairScale;
        private bool startStretching;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            /*if (startStretching)
        {
            Vector3 reachScale =this.transform.localScale;
            reachScale.y=this.transform.localScale.y+( (currentHairScale.y *2)-this.transform.localScale.y);

            this.transform.localScale = Vector3.Lerp(this.transform.localScale, reachScale, 1f); ;
        }*/

        }
        public void growHairBone()
        {
            //bns.addNewHairPices();
            float yScale = this.transform.localScale.y;
            if (yScale > 3f)
            {
                bns.addNewHairPices();
            }
            
            
            if (yScale < 15)
                this.transform.localScale += new Vector3(0, .5f, 0);
            else
            
            
            
            currentHairScale = this.transform.localScale;
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
        class Bookxchuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchuwaciotchx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwaxhua
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxchcuwaxhuachx
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Powscq
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciwCHOAWowis
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        public void cutHair(int value)
        {
            Vector3 newHairScale= this.transform.localScale- new Vector3(0, .5f, 0) * value;
            if (newHairScale.y < 1)
                newHairScale.y = 1;
            
            
            
            this.transform.localScale = newHairScale;
            currentHairScale = this.transform.localScale;

        }
        public void resertHairJiggleConfig()
        {
            bns.resetJiggleSatate();
        }
        public void gooBackToNormalScale()
        {
            // disableJiggle();
            // startStretching = true;
            currentHairScale.y *= 2;
            this.transform.localScale = currentHairScale;
            Invoke("disableJiggle", 1f);
            Invoke("finishMultiplier", 2f);
            Invoke("playerWin", 3f);
            Vector3 rotation = this.transform.localEulerAngles;
            rotation.x = 25;
            this.transform.localEulerAngles = rotation;
       
        }
        public void disableJiggle()
        {
            bns.disable();

        }
        private void finishMultiplier()
        {
            FinishMultiplierHolderController.instance.setNewMat();

        }
        private void playerWin()
        {

            UiManager.instance.playerWin();
        }

    }
}
