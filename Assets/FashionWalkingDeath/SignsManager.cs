using System.Collections;
using System.Collections.Generic;
using FashionWalkingDeath.Scripts;
using UnityEngine;

public class SignsManager : MonoBehaviour
{
    private SignsController[] signsController;
    private int resetYPos;
    public Vector3 playerPos;
    //Private Data
    private int  currentSelectedCharcterOutfitScore;
    //Reference


    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        signsController = this.GetComponentsInChildren<SignsController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetChildPos()
    {
        foreach(Transform child in this.transform)
        {
            Vector3 childPos = child.transform.localPosition;
            childPos.y = resetYPos;
            child.localPosition = childPos;
        }
    }
    public void showUpSigns(int currentCharacterScore)
    {
        currentSelectedCharcterOutfitScore = currentCharacterScore;
        StartCoroutine("delayedSigns", 1f);
    }
    private IEnumerator delayedSigns()
    {
        foreach (SignsController signs in signsController)
        {
            signs.updatePopUpState(true,currentSelectedCharcterOutfitScore);
            yield return new WaitForSeconds(.2f);
        }
    }
    public void changePosToPlayerPos()
    {
        this.transform.localPosition = playerPos;
        int playerOutfitScore = CharacterOutfitManager.instance.getScorevalue();
        showUpSigns(playerOutfitScore);
    }
}
