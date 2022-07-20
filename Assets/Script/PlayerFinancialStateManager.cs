using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerFinancialStateManager : MonoBehaviour
{

    public FinancialState financialState;
    [SerializeField]
    TextMesh statusText;
    [SerializeField]
    Image statusfill;

    //Private Data
    private PlayerAnimationManager playerAnimation;
    private BodyPartController bodyPart;
    private float currentCollectedCoin;
    private int currentState;
    // Start is called before the first frame update
    private void Awake()
    {
        if (!playerAnimation)
        {
            playerAnimation = this.GetComponent<PlayerAnimationManager>();

        }
        bodyPart = this.GetComponentInChildren<BodyPartController>();
    }


    void Start()
    {
        currentCollectedCoin = .1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public enum FinancialState
    {
        poorLity,
        poor,
        normal,
        buisiness,
        rich,
        richBilling,
        cocktail
    }
    public void switchState(FinancialState financeState)
    {

        switch (financeState)
        {
            case FinancialState.poorLity:
                //Switch to poorlity animation
                playerAnimation.enablePoorLityAnimation();
                statusText.text = "PoorLity";
                break;
            case FinancialState.poor:
                //Switch to poor animation
                playerAnimation.enablePoorAnimation();
                statusText.text = "Poor";
                break;
            case FinancialState.normal:
                //Switch to normal animation
                playerAnimation.enableNormalAnimation();
                statusText.text = "Normal";
                break;
            case FinancialState.buisiness:
                //Switch to normal animation
                playerAnimation.enableBuisinessAnimation();
                statusText.text = "Buisiness";
                break;
            case FinancialState.rich:
                //Switch to rich animation
                playerAnimation.enableRichAnimation();
                statusText.text = "Rich";
                break;
            case FinancialState.richBilling:
                //Switch to richBilling animation
                playerAnimation.enableRichBillingAnimation();
                statusText.text = "RichBilling";
                break;
            case FinancialState.cocktail:
                //Switch to normal animation
                playerAnimation.enableCocktailAnimation();
                statusText.text = "Cocktail";
                break;
        }
       
        statusfill.fillAmount = currentCollectedCoin;

    }
    public void updateNewCollected(float collectedVal=.03f)
    {
        if (currentCollectedCoin <= 0)
        {
            playerAnimation.enableLooseAnimation();
            Gameplay.Instance.finish();
            UiManager.instance.loose();
            return;

        }
        if (currentCollectedCoin>0f && currentCollectedCoin<1f)
        currentCollectedCoin += collectedVal;
        int stateIndex = 0;
         if (currentCollectedCoin > .9f)
        {
            switchState(FinancialState.cocktail);
            stateIndex = 6;

        }
        else if (currentCollectedCoin > .7f)
        {
            switchState(FinancialState.richBilling);
            stateIndex = 5;
        }else if (currentCollectedCoin>.55f)
        {
            switchState(FinancialState.rich);
            stateIndex = 4;
        }
        
        else if (currentCollectedCoin > .4f)
        {
            switchState(FinancialState.buisiness);
            stateIndex = 3;

        }
        else if (currentCollectedCoin > .3f)
        {
            switchState(FinancialState.normal);
            stateIndex = 2;

        }
        else if (currentCollectedCoin > .1f)
        {
            switchState(FinancialState.poorLity);
            stateIndex = 1;

        }
        else
        {
            switchState(FinancialState.poor);
            stateIndex = 0;

        }
        if(currentState!=stateIndex)
        bodyPart.enableBodyPart(stateIndex);
        currentState = stateIndex;

    }
    
}
