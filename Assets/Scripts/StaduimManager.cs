using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaduimManager : MonoBehaviour
{
    public Material[] materials;
    private MeshRenderer meshR;
    // Start is called before the first frame update
    void Start()
    {
        meshR=GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setMaterial(){
         meshR=GetComponent<MeshRenderer>();
    	int materialLength=materials.Length-1;
    	int selectedMaterialIndex=Random.Range(0,materialLength);
    	meshR.material=materials[selectedMaterialIndex];

    }
}
