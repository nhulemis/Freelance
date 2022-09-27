using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SettingButton : MonoBehaviour
{
    Button mainButton;
    SettingItemButton[] menuItem;
    int childCount=0;
    Vector2 mainButtonPosition;
    bool isExpanded=false;
    [SerializeField]Vector2 spacing;
    [Header("main Button Rotation")]
     [SerializeField]float rotationDuraTion;
     [SerializeField]Ease rotationEase;
     [Header("Animation")]
     [SerializeField]float expandDuraTion;
     [SerializeField]float collapseDuraTion;
     [SerializeField]Ease expandEase;
      [SerializeField]Ease collapseEase;
     [Header("Fading")]
     [SerializeField]float expandFadeDuraTion;
     [SerializeField]float collapseFadeDuraTion;
    
    // Start is called before the first frame update
    void Start()
    {
        

        childCount=this.transform.childCount-1;
        menuItem=new SettingItemButton[childCount];
        for(int i=0;i<childCount;i++){
        	menuItem[i]=this.transform.GetChild(i+1).GetComponent<SettingItemButton>();
        }
        mainButton=this.transform.GetChild(0).GetComponent<Button>();
      mainButton.transform.SetAsLastSibling(); 
        mainButton.onClick.AddListener(toogleMenu);
          
        mainButtonPosition=mainButton.transform.position;
       
      // mainButton.transform.SetAsLastSibling();
        resetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void resetPosition(){

    	for(int i=0;i<childCount;i++){
    		// menuItem[i].trans.DOMove(mainButtonPosition,collapseDuraTion).SetEase(collapseEase);
    		//  menuItem[i].img.DOFade(0f,collapseFadeDuraTion);
    	}      
    }
    private void toogleMenu(){
    	isExpanded=!isExpanded;
    	print("expand");
    	if(isExpanded){
    		
    		for(int i=0;i<childCount;i++){
               // menuItem[i].trans.position=mainButtonPosition+spacing*(i+1);
                   menuItem[i].trans.DOMove(mainButtonPosition+spacing*(i+1),expandDuraTion).SetEase(expandEase);
                   //menuItem[i].img.DOFade(1f,expandFadeDuraTion).From(0f);
    		}
    	}else {
    		resetPosition();
    	}
    	mainButton.transform.DORotate(Vector3.up*180f,rotationDuraTion)
    	.From(Vector3.zero)
    	.SetEase(rotationEase);

    }
    private void OnDestroy(){
    	mainButton.onClick.RemoveListener(toogleMenu);
    }
}
