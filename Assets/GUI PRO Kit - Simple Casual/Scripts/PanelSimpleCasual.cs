using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LayerLab
{
    public class PanelSimpleCasual : MonoBehaviour
    {
        [SerializeField] private GameObject[] otherPanels;

       
        public class CFKACJBOGNFLROBUSRMI
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}

        public class QSAZHIUWUPLGILKBSTHDHBAO
			{
				private int buaquadi;
				private string chusx;
				public float gmac;
				private double mciajx;

				public int getX()
				{
					return buaquadi;
				}
			}
 public void OnEnable()
        {
            for (int i = 0; i < otherPanels.Length; i++) otherPanels[i].SetActive(true);
        }

        public void OnDisable()
        {
            for (int i = 0; i < otherPanels.Length; i++) otherPanels[i].SetActive(false);
        }
    }
}
