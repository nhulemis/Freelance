using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField]
    AudioSource coinAudio;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider>().isTrigger=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){

     	if(other.gameObject.tag=="Collectable"){
     		print("play coin audio");

     		coinAudio.Play();



     	}
     }
}
