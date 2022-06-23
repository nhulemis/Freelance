using UnityEngine;

namespace hairmaster.Scripts
{
    public class FinishMultiplierController : MonoBehaviour
    {
        public Material glossyMaterial;
        private bool passed;
        public TextMesh rewardText;
        private int rewardTextValue;
        private Transform firstChild;
        // Start is called before the first frame update
        void Start()
        {
            rewardTextValue = 0;
            firstChild = this.transform.GetChild(0);
            rewardText = firstChild.GetComponent<TextMesh>();
            firstChild.gameObject.SetActive(false);       
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        {
            
            
            
            
            
            
            
            
            if (other.gameObject.CompareTag("HairBone") && !passed)
            {
                passed = true;
                this.transform.parent.GetComponent<FinishMultiplierHolderController>().finisMultiplierController = this;
            }
        }
        class Bookxhuw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class Bookxhuwxccw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

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
        class HCWIoajciw
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class HCWIoajciwCHOAW
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
        class Owicuaow
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class OwicuaowScuwa
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class IWUCOASWkdkowCHOAW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class UCIQOAXS
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        public void setMaterial()
        {
       
            UiManager.instance.setCurrentCollectedCoin(rewardTextValue);
            
            
            
            
            
            
            
            
            
            this.transform.GetChild(3).GetComponent<MeshRenderer>().material = glossyMaterial;
        }
        public void setRewardValue(int value)
        {
            rewardTextValue = value;
        }
        public void setRewardText()
        {
            firstChild.gameObject.SetActive(true);
            
            
            rewardText.text = "$"+ rewardTextValue ;
        }
        class UCIQOAXSCHuaow1
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        class TaolaoChaox2
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    
        class TaolaoCXHiakco3
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
    }
}
