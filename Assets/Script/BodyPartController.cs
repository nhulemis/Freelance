using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartController : MonoBehaviour
{
    //Serialized Data
    [Tooltip("Body Part Data Holder")]
    [SerializeField]
    private GameObject[] poorBodyPart;
    [SerializeField]
    private GameObject[] middleBodyPart;
    [SerializeField]
    private GameObject[] bllingBodyPart;
    [SerializeField]
    private GameObject[] buisinessBodyPart;
    [SerializeField]
    private GameObject[] casualBodyPart;
    [SerializeField]
    private GameObject[] cocktailBodyPart;
    [SerializeField]
    private GameObject[] richBodyPart;

    private int currentSelectedOutfitIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enableBodyPart(int outfitIndex)
    {
        disableCurrentSelectedOutfit();
        currentSelectedOutfitIndex = outfitIndex;
        if (currentSelectedOutfitIndex == 0)
        {
            foreach (GameObject child in poorBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 1)
        {
            foreach (GameObject child in  casualBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 2)
        {
            foreach (GameObject child in middleBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 3)
        {
            foreach (GameObject child in buisinessBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 4)
        {
            foreach (GameObject child in richBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 5)
        {
            foreach (GameObject child in bllingBodyPart)
            {
                child.SetActive(true);
            }
        }
        else if (currentSelectedOutfitIndex == 6)
        {
            foreach (GameObject child in cocktailBodyPart)
            {
                child.SetActive(true);
            }
        }

    }
    private void disableCurrentSelectedOutfit()
    {
        if (currentSelectedOutfitIndex == 0)
        {
            foreach (GameObject child in poorBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 1)
        {
            foreach (GameObject child in casualBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 2)
        {
            foreach (GameObject child in middleBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 3)
        {
            foreach (GameObject child in buisinessBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 4)
        {
            foreach (GameObject child in richBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 5)
        {
            foreach (GameObject child in bllingBodyPart)
            {
                child.SetActive(false);
            }
        }
        else if (currentSelectedOutfitIndex == 6)
        {
            foreach (GameObject child in cocktailBodyPart)
            {
                child.SetActive(false);
            }
        }
    }
}
