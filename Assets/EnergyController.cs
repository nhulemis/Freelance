using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergyController : MonoBehaviour
{
    private float _interval = 1f;

    private TextMeshProUGUI energy;
    // Start is called before the first frame update
    void Start()
    {
        energy = GetComponent<TextMeshProUGUI>();
        StartCoroutine(UpdateEnergy());
    }

    IEnumerator UpdateEnergy()
    {
        while (true)
        {
            energy.text = GameItemManager.Instance.GetEnergy().ToString();
            yield return new WaitForSeconds(_interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
