using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCf : MonoBehaviour
{
    [SerializeField] float speed=1;
     // Start is called before the first frame update
    void Start()
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
    // Update is called once per frame
    void Update()
    {
        transform.position+=transform.forward*Time.deltaTime*speed;
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Respawn"){
    		//TrafficSystemController.instance.arrivedToStart();
    		TrafficSystemController.instance.respawn(other.gameObject.transform);
               Destroy(this.gameObject);
    		}
    }
}
