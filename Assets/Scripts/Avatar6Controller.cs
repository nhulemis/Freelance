using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar6Controller  :  MainPlayerAvatarController
{
    public Image fill1;
    public Image fill2;
    public Image fill3;
    public Image fill4;
    public Image fill5;
    public Image fill6;
    private Animator anim;
    public bool fil1;
    private bool fil2;
    public bool fil3;
    private bool fil4;
    public bool fil5;
    private bool fil6;
   

    // Start is called before the first frame update
    void Start()
    {
        anim=this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fil1){
        	fill1.fillAmount+=Time.deltaTime*1.7f;
        	      anim.SetBool("First",true);


        }if(fil2)
            fill2.fillAmount+=Time.deltaTime*1.9f;
            if(fil3){
            	anim.SetBool("seconde",true);
            	fill3.fillAmount+=Time.deltaTime*1.9f;

            }
            if(fil4)
            fill4.fillAmount+=Time.deltaTime*1.9f;
            if(fil5){
            	anim.SetBool("last",true);
               fill5.fillAmount+=Time.deltaTime*1.9f;
            }
            
            if(fil6)
            fill6.fillAmount+=Time.deltaTime*1.9f;

    }
    public override void firstMove(){
    	fil1=true;
       anim.SetBool("First",true);
    }
    public  void secondeMove(){
    	fil2=true;
    	
    }public override void thirdeMove(){
    	anim.SetBool("seconde",true);
    	fil3=true;
    }
    public void fourthmove(){
    	fil4=true;
    }
    public void fiveMove(){
    	anim.SetBool("last",true);
    	fil5=true;
    }
    public void Lastmove(){
    	fil6=true;
    }
}
