using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public BossController[] boss;
    // Start is called before the first frame update
    void Start()
    {
        boss = this.GetComponentsInChildren<BossController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BossController[] getBosses()
    {
        return boss;
    }

}
