using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
	public bool efx;

	public Sprite musicOnSprite;

	public Sprite musicOffSprite;

	public Sprite efxOnSprite;

	public Sprite efxOffSprite;

	public Image spriteButton;

	private void Start()
	{
		SetButton();
	}

	public void convert()
	{
		float fValue = 0.123456f;
		int iValue = (int)fValue;
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.FloorToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.CeilToInt(fValue);
		Debug.Log("int val: " +iValue);
         
		iValue = Mathf.RoundToInt(fValue);
		Debug.Log("int val: " +iValue);
	}
	public void MusicButtonClicked()
	{
		AudioManager.Instance.MuteMusic();
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		SetButton();
	}

	public void EfxButtonClicked()
	{
		AudioManager.Instance.MuteEfx();
		AudioManager.Instance.PlayEffects(AudioManager.Instance.buttonClick);
		SetButton();
	}

	private void SetButton()
	{
		if ((!AudioManager.Instance.IsMusicMute() && !efx) || (!AudioManager.Instance.IsEfxMute() && efx))
		{
			if (efx)
			{
				spriteButton.sprite = efxOnSprite;
			}
			else
			{
				spriteButton.sprite = musicOnSprite;
			}
		}
		else if (efx)
		{
			spriteButton.sprite = efxOffSprite;
		}
		else
		{
			spriteButton.sprite = musicOffSprite;
		}
	}
}
