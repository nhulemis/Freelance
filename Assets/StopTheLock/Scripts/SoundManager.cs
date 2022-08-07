﻿
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/



using UnityEngine;
using System.Collections;

namespace AppAdvisory.StopTheLock
{
	public class SoundManager : MonoBehaviourHelper 
	{
    public class ProductItem
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class ProductItemOIUca
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class OIUzxckljaw
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class QIUciou
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class KLJHalwjkkxlc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
    public class Lkjawioxklc
    {
      public string id;
      public Sprite icon;
      public string price;
      public string title;

    }
		AudioSource _audioSource;
		AudioSource audioSource
		{
			get
			{
				if(_audioSource == null)
					_audioSource = FindObjectOfType<AudioSource>();

				return _audioSource;
			}
		}
		[SerializeField] private AudioClip soundSuccess;
		[SerializeField] private AudioClip soundFail;
		[SerializeField] private AudioClip soundTouch;

		public void PlaySuccess()
		{
			audioSource.PlayOneShot (soundSuccess,1f);
		}

		public void PlayFail()
		{
			audioSource.PlayOneShot (soundFail,1f);
		}

		public void PlayTouch()
		{
			audioSource.PlayOneShot (soundTouch,1f);
		}
	}
}