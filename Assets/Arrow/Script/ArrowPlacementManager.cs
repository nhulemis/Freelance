using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ArrowPlacementManager : MonoBehaviour
{
    [Range(0,1)]
    public float angleFactor=1;
    [Range(-1, 1)]
    public float radiusFactor=.3f;

    public GameObject arrowPrefab;
    public bool attackSpecialPlacement;
    [SerializeField]
    private Transform childHolder;
    [SerializeField]
    private TextMeshProUGUI currentCollecteArrowText;
    // Start is called before the first frame update
    void Start()
    {
        deleteAll();
        AddRunners(getArrowPanelLevel());
    }
    private int getArrowPanelLevel()
    {
        return PlayerPrefs.GetInt("ArrowCurrentLevelIndex") + 1;
    }
    // Update is called once per frame
    void Update()
    {
        currentCollecteArrowText.text = childHolder.childCount + "";

        FermatSpiralPlacement();
        if (attackSpecialPlacement)
        {
            attackPlace();
        }
    }
    private void attackPlace()
    {

        if (angleFactor > 0)
        {
            angleFactor -= Time.deltaTime * 2f;
            angleFactor = Mathf.Clamp(angleFactor, 0, 1);
        }
           
       
        if (radiusFactor < .2f)
        {
            radiusFactor += Time.deltaTime;
        }
    }
    private void FermatSpiralPlacement()
    {
        float goldenAngle = 137.5f * angleFactor;

        for (int i = 0; i < childHolder.childCount; i++)
        {
            float x = radiusFactor * Mathf.Sqrt(i + 1) * Mathf.Cos(Mathf.Deg2Rad * goldenAngle * (i + 1));
            float z = radiusFactor * Mathf.Sqrt(i + 1) * Mathf.Sin(Mathf.Deg2Rad * goldenAngle * (i + 1));

            Vector3 runnerLocalPosition = new Vector3(x, z, 0);
            childHolder.GetChild(i).localPosition = Vector3.Lerp(childHolder.GetChild(i).localPosition, runnerLocalPosition, 0.1f);
        }
    }
    public void AddRunners(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (this.childHolder.childCount < 600)
            {
                GameObject runnerInstance = Instantiate(arrowPrefab, childHolder);
            }
        }
        currentCollecteArrowText.text = childHolder.childCount+"";

    }
    public void devide(int amount)
    {
        int currentChild = this.childHolder.childCount;
        currentChild /= amount;
        removeChild(currentChild);
    }
    public void subs(int amount)
    {
        removeChild(amount);
    }
    public void multiply(int amount)
    {
        int currentChild = this.childHolder.childCount;
        currentChild *= amount;
        AddRunners(currentChild);
    }
    private void removeChild(int ammout)
    {
        for(int i = 0; i < ammout;i++)
        {
            int totalChild = this.childHolder.childCount;
            if (totalChild > 2 && i<totalChild-1)
            {
               
                GameObject childObj = this.childHolder.GetChild(i).gameObject;
                Destroy(childObj);
            }
            else
            {
                GameManager.instance.looseGame();
            }
            
        }
        print("Remooooooove Child");
    }
    public void deleteAll()
    {
        foreach(Transform child in this.childHolder)
        {
            Destroy(child.gameObject);
        } 
    }

}
