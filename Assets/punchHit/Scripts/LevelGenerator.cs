using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [Header("Ready To Use Prefabs")]
    [SerializeField] GameObject[] levels;
    [SerializeField] float zOfsset;
    [HideInInspector]
    public int currentLevelPlayerOn;
    private int currentlyGeneratedLevels;
    private List<GameObject> levelGenerated;
    private int levelToGenrateIndex=0;

    /***************Reference******************/
    public static LevelGenerator instance;


    void Awake(){
        if(instance==null)instance=this;
        else if(instance!=this)Destroy(this.gameObject);
      
    }
    // Start is called before the first frame update
    void Start()
    {
    	levelGenerated=new List<GameObject>();
        genarateLevel(4,5.3f,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void genarateLevel(int num,float initialOffset,bool f=false){
    	
        int levelsLength=levels.Length;

    	for(int i=0;i<num;i++){
            if(levelToGenrateIndex<levelsLength-1){
                levelToGenrateIndex++;
            }else{
                levelToGenrateIndex=0;
            }
    		
    		GameObject obj=Instantiate(levels[levelToGenrateIndex],Vector3.zero,Quaternion.identity);
    		obj.transform.position=new Vector3(0,0,currentlyGeneratedLevels*zOfsset+initialOffset);
    		currentlyGeneratedLevels++;
    		if(f){
    			obj.transform.GetChild(0).gameObject.SetActive(true);
    			obj.transform.GetChild(1).gameObject.SetActive(true);
    			f=false;
    		}
    		levelGenerated.Add(obj);
    	}

    }
    public void nextLevel(){
         ++currentLevelPlayerOn;
    	print("levelGenerated "+levelGenerated.Count);
    	/*levelGenerated[0].transform.GetChild(0).gameObject.SetActive(false);
    	levelGenerated[0].transform.GetChild(1).gameObject.SetActive(false);
    	levelGenerated[1].transform.GetChild(0).gameObject.SetActive(true);
    	levelGenerated[1].transform.GetChild(1).gameObject.SetActive(true);*/
    	Destroy(levelGenerated[(currentLevelPlayerOn-1)].transform.GetChild(0).gameObject);
    	Destroy(levelGenerated[(currentLevelPlayerOn-1)].transform.GetChild(1).gameObject);
    	levelGenerated[0].SetActive(false);
        Invoke("activate",.001f);
         


    }
    private void activate(){
          levelGenerated[(currentLevelPlayerOn)].transform.GetChild(0).gameObject.SetActive(true);
    	 levelGenerated[(currentLevelPlayerOn)].transform.GetChild(1).gameObject.SetActive(true);
         //GameManager.instance.inPlayMode();

    }
}
