using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionalSpriteChange : MonoBehaviour
{
    [SerializeField] private List<Image> sprite;

    // Start is called before the first frame update
    void Start()
    {
        var GM = GameItemManager.Instance;

        GM.AddSprites = sprite;
        GM.SetUpColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
