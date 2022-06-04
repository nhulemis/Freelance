using System.Collections;
using System.Collections.Generic;
using FashionWalkingDeath.Scripts;
using UnityEngine;

public class DateOutfitController : MonoBehaviour
{
    //Serialized Data
    public LevelConceptsController[] galaLevels;
    [SerializeField]
    public GameObject bikinniTop;
    [SerializeField]
    public GameObject bikinniBottom;
    // Start is called before the first frame update
    void Start()
    {
        galaLevels = this.GetComponentsInChildren<LevelConceptsController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void selectTshirtOutfits(int levelIndex, int hairIndex)
    {
        disableTopOutfit();
        print("Changing Gala Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
        galaLevels[0].selectTshirtItem(levelIndex);
    }
    public void selectHairOutfits(int levelIndex, int hairIndex)
    {
        print("Changing Gala Hair levele index : " + levelIndex + " & selected hair is :" + hairIndex);
        galaLevels[0].selectHairItem(levelIndex);
    }
    public void selectShoeOutfits(int levelIndex, int hairIndex)
    {
        print("Changing Gala Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);

        galaLevels[0].selectShoeItem(levelIndex);
    }
    public void selectDressOutfits(int levelIndex, int hairIndex)
    {
        disableBottomOutfit();
        disableTopOutfit();
        print("Changing Gala Dress levele index : " + levelIndex + " & selected Dress is :" + hairIndex);
        galaLevels[0].selectDressItem(levelIndex);
    }
    public void selectBottomOutfits(int levelIndex, int hairIndex)
    {
        print("Changing Gala Shoe levele index : " + levelIndex + " & selected shoe is :" + hairIndex);
        disableBottomOutfit();
        galaLevels[0].selectBottomItem(levelIndex);
    }
    public void selectGlovesOutfits(int levelIndex, int hairIndex)
    {
        print("Changing Gala Gloves levele index : " + levelIndex + " & selected shoe is :" + hairIndex);
        galaLevels[0].selectGlovesItem(levelIndex);
    }
    private void disableBottomOutfit()
    {
        bikinniBottom.SetActive(false);
    }
    private void disableTopOutfit()
    {
        bikinniTop.SetActive(false);

    }
}
