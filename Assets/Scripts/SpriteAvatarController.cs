using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAvatarController : MonoBehaviour
{
    public RectTransform rightAvatar1;
    public RectTransform[] rightAvatar1Path;
    public bool rightAvatar1StartMove;
    bool firstPlacePassed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(rightAvatar1StartMove){
          rightAvatar1FirstMove();
       } 
    }
    private void rightAvatar1FirstMove(){
     float distance=Vector2.Distance(rightAvatar1Path[0].anchoredPosition,rightAvatar1.anchoredPosition);
     
            
    if(distance>=0){
        if(distance==0) {
print("First");
        Vector2 direction=rightAvatar1Path[0].anchoredPosition-rightAvatar1.anchoredPosition;
        rightAvatar1.anchoredPosition+=direction*Time.deltaTime;
        } else{
        firstPlacePassed=true;
        print("secomde");
        Vector2 direction=rightAvatar1Path[1].anchoredPosition-rightAvatar1.anchoredPosition;
        rightAvatar1.anchoredPosition+=direction*Time.deltaTime;
    }
        
    }
        
    	
    }
}
