using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrafficSystemController : MonoBehaviour
{
    [SerializeField]Transform start;
    [SerializeField]Transform end;
    [SerializeField]GameObject[] cars;

    public static TrafficSystemController instance;
    private float lastxPos;

    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
    	lastxPos=start.position.x;
    	//arrivedToStart();
        //arrivedToEnd();
        respawn(start);
        respawn(end);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    [SerializeField]
    GameObject LoadingScene;
    [SerializeField]
    Sprite[] bgRands;
    

    public void LoadNextLevel()
    {
	    StartCoroutine(LoadGamePlayScene());
    }

    IEnumerator LoadGamePlayScene()
    {
	    yield return new WaitForSeconds(0.5f);
	    var loadScene =  SceneManager.LoadSceneAsync($"1", LoadSceneMode.Single);

	    int bg = Random.Range(0, bgRands.Length);

	    LoadingScene.SetActive(true);
	    while (!loadScene.isDone)
	    {
		    yield return new WaitForEndOfFrame();
	    }
	    yield return new WaitForSeconds(1f);
	    LoadingScene.SetActive(false);
    }

    public void LoadMainMenuGame()
    {
	    StartCoroutine(LoadMainMenuScene());
    }
    IEnumerator LoadMainMenuScene()
    {
	    yield return new WaitForSeconds(0.5f);

	    int bg = Random.Range(0, bgRands.Length);

	    LoadingScene.SetActive(true);
	    var loadScene = SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
	    while (!loadScene.isDone)
	    {
		    yield return new WaitForEndOfFrame();
	    }
	    yield return new WaitForSeconds(1f);
	    LoadingScene.SetActive(false);
    }
    public void respawn(Transform carforward){
         int randomCarIndex=Random.Range(0,cars.Length);
         Vector3 spawnPos=carforward.position;
         if(spawnPos.x<0)
         spawnPos.x+=10;
         else
          spawnPos.x-=10;

    	GameObject carobj=Instantiate(cars[randomCarIndex],spawnPos,Quaternion.identity);
    	carobj.transform.forward=carforward.right;
    	//lastxPos=end.position.x;
    }
}
