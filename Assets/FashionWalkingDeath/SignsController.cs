using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignsController : MonoBehaviour
{
    private bool popUp;
    private float yPos;
    private int selectedBadge;
    // Start is called before the first frame update
    void Start()
    {
        selectedBadge = 0;
        yPos = 1.55f;
    }

    // Update is called once per frame
    void Update()
    {
        if (popUp)
        {
            Vector3 newPos =this.transform.position;
            newPos.y +=(yPos-newPos.y)*Time.deltaTime;

            this.transform.position = Vector3.Lerp(this.transform.position, newPos, 1f);


        }else if (!popUp)
        {
            Vector3 newPos = this.transform.position;
            newPos.y =0;
            this.transform.position = Vector3.Lerp(this.transform.position, newPos, 1f);

        }

    }
    public void updatePopUpState(bool isPopUpMode,int outfitScore)
    {
        this.transform.GetChild(selectedBadge).gameObject.SetActive(false);

        popUp = isPopUpMode;
         selectedBadge  = Random.Range(0, outfitScore);
        this.transform.GetChild(selectedBadge).gameObject.SetActive(true);
    }
    
}
