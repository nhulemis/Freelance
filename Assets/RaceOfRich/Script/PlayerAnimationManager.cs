using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Init()
    {
        anim.SetFloat("Speed", 1f);

    }
    
    public void enablePoorAnimation()
    {
        anim.SetFloat("Rich", 0f);

    }
    public void enablePoorLityAnimation()
    {
        anim.SetFloat("Rich", .1f);
    }
    public void enableNormalAnimation()
    {
        anim.SetFloat("Rich", .4f);

    }
    public void enableBuisinessAnimation()
    {
        anim.SetFloat("Rich", .5f);
    }
    public void enableRichAnimation()
    {
        anim.SetFloat("Rich", .6f);

    }
    public void enableRichBillingAnimation()
    {
        anim.SetFloat("Rich", .8f);

    }
    public void enableCocktailAnimation()
    {
        anim.SetFloat("Rich", 1f);
    }
    public void enableWinAnimation()
    {
        anim.SetTrigger("Win");

    }
    public void badStateChanger(bool state)
    {
        anim.SetBool("bad",state);

    }public void enableLooseAnimation()
    {
        anim.SetTrigger("Lose");

    }
}
