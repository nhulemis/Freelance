using UnityEngine;

namespace hairmaster.Scripts
{
    public class HairController : MonoBehaviour
    {
        private SkinnedMeshRenderer[] skinnedMesh;
        public SkinnedMeshRenderer hairBaseMesh;
        public int baseHairMaterialIndex=1;    
        private Material currentMaterial;
        private Color32[] hairColor;
        //References
        public static HairController instance;

        private void Awake()
        {
            if (!instance) instance = this;
            // else if (instance != this) Destroy(this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            hairColor = new Color32[7];
            hairColor[0] = new Color32(75, 38, 0, 255);
            hairColor[1] = new Color32(197, 44, 103, 255);
            
            
            hairColor[2] = new Color32(26, 184, 207, 255);
            hairColor[3] = new Color32(217, 68, 0, 255);
            hairColor[4] = new Color32(140, 255, 44, 255);
            hairColor[5] = new Color32(140, 128, 44, 255);
            skinnedMesh = this.transform.GetComponentsInChildren<SkinnedMeshRenderer>();

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public  void growHairBones(ref Material  newMaterial)
        {
        

            int indexColor=0;
            if (newMaterial.color ==hairColor[0])
            {
                indexColor = 0;
            }
            else if (newMaterial.color == hairColor[1])
            {
                
                
                indexColor = 1;
            }
            else if (newMaterial.color == hairColor[2])
            {
                indexColor = 2;
            }
            else if (newMaterial.color == hairColor[3])
            {
                indexColor = 3;
            }
            else
            {
                print("Yooo Color Yellow");
                indexColor = 4;
            }

            hairBaseMesh.materials[baseHairMaterialIndex].color = hairColor[indexColor];

            currentMaterial = newMaterial;
            changeColor(newMaterial);
            int i = 0;
            foreach (Transform child in this.transform)
            {
                HairBoneController hairBonController = child.GetComponent<HairBoneController>();
                
                
                
                

                hairBonController.growHairBone();
                i++;
                if (i > 11)
                    return;
          
            }
         
        
        }
        public void changeColor(Material newMaterial)
        {
            foreach (SkinnedMeshRenderer skinedMeshChild in skinnedMesh)
            {
                skinedMeshChild.material = newMaterial;
            }
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
        class Bookxchuwaciot
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
        class PowscqCHUW
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
        class IWUCOASWkdkow
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
        class BookxchuwaciotchxCHUW
        {
            public string Title { get; }
            public string Publisher { get; }
            public string? Isbn { get; }
            

            public void Deconstruct(out string title, out string publisher, out string? isbn)
                => (title, publisher, isbn) = (Title, Publisher, Isbn);

            public override string ToString() => Title;
        }
        public void resetHair()
        {
            foreach(Transform child in this.transform)
            {
                Vector3 childScale = child.localScale;
                childScale.y = 1;
                child.localScale = childScale;
            }
        }
        public void stretchHair()
        {
            foreach (Transform child in this.transform)
            {
                child.GetComponent<HairBoneController>().gooBackToNormalScale();
            }
        }
        public Material getCurrentMaterial()
        {
            return currentMaterial;
        }

    }
}
