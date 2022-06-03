using System.Collections;
using System.Collections.Generic;
using GleyMobileAds;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    [SerializeField]Transform target;
    [SerializeField]Transform car;
    public static CameraController instance;
    void Awake(){
    	if(instance==null)instance=this;
    	else if(instance!=this)Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position=new Vector3(target.position.x,1.1f,target.position.z);
        

    }
    public void rotateCamera(Vector3 amount){
        // transform.localEulerAngles=Vector3.Lerp(transform.localEulerAngles,amount,.1f);
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
}
