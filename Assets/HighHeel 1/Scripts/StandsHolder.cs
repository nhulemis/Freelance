using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandsHolder : MonoBehaviour
{
    [SerializeField]
    GameObject stand;
    [SerializeField]
    Transform rightChild;
    [SerializeField]
    Transform leftChild;
    private float yOffset = 0.009f;
    private Vector3 standCurrentPos;
    public static StandsHolder instance;
    int childsCount;
   
        public class liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj
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

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj()
        {
            
        }
        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj GetliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(){
        var clasx = new liqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj();
        return  clasx;
    }

    public string RandomStringliqpnDTHuaUhoVAeAZVZhssmkFTGmfMEtwvxpCSLajqyFhgRuKCj(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        standCurrentPos = Vector3.zero;
        childsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHeelStand()
    {
        GameObject newStanRightChild = Instantiate(stand, Vector3.zero, Quaternion.identity);
        GameObject newStandLeftChild = Instantiate(stand, Vector3.zero, Quaternion.identity);
        newStanRightChild.transform.parent = rightChild;
        newStandLeftChild.transform.parent = leftChild;
        newStandLeftChild.transform.localPosition = standCurrentPos;
        newStanRightChild.transform.localPosition = standCurrentPos;
        newStandLeftChild.transform.localEulerAngles = Vector3.zero;
        newStanRightChild.transform.localEulerAngles = Vector3.zero;
        newStandLeftChild.GetComponent<HeelStand>().childIndex = childsCount;
        newStanRightChild.GetComponent<HeelStand>().childIndex = childsCount;
        this.transform.parent.transform.position =Vector3.Lerp(this.transform.parent.transform.position, this.transform.parent.transform.position+Vector3.up*3,.5f);

        childsCount++;


        standCurrentPos.y -= yOffset;


    }
    public void removeChild(int childIndex)
    {
        int currentChilds = rightChild.childCount;
        if (childIndex < currentChilds)
        {
            for(int i = childIndex; i <currentChilds; i++)
            {
                if (rightChild.GetChild(childIndex).gameObject != null && leftChild.GetChild(childIndex).gameObject != null)
                {
                    Destroy(rightChild.GetChild(childIndex).gameObject);
                    Destroy(leftChild.GetChild(childIndex).gameObject);
                    //rightChild.GetChild(childIndex).parent=null;
                    //leftChild.GetChild(childIndex).parent = null;
                    if (childsCount > 0)
                        childsCount--;
                    if (standCurrentPos.y < 0)
                        standCurrentPos.y += yOffset;

                }
            }
            

        }
    }
}
