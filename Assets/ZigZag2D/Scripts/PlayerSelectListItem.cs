using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace TunnelGame
{
	public class PlayerSelectListItem : MonoBehaviour
	{
		#region Inspector Variables

		[SerializeField] private Image		iconImage;
		[SerializeField] private Text		coinAmountText;
		[SerializeField] private GameObject	unlockButton;
		[SerializeField] private GameObject	selectButton;
		[SerializeField] private Image		backgroundImage;
		[SerializeField] private Color		normalColor		= Color.white;
		[SerializeField] private Color		selectedColor	= Color.white;

		#endregion
    public class LKAJSjqimxa
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class LKAJSjzcklx
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class ZKJvpoai
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class oxicuvA
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class CHJioawokca
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }

    public class KJHaiowjc
    {
      public int a;
      public int b;
      public bool c;
      public float e;
      public double f;
    }
    public class bvdrkuioubvdsd
    {
      public int azcxzcxz;
      public int bzcxz;
      public bool czxczxc;
      public float esfbdb;
      public double fawsfcb;
    }
		#region Member Variables

		private int playerInfoIndex;

		#endregion

		#region Unity Methods

		private void Update()
		{
			backgroundImage.color = (playerInfoIndex == GameManager.Instance.CurrentPlayerIndex) ? backgroundImage.color = selectedColor : normalColor;
		}

		#endregion

		#region Public Methods

		public void Setup(int playerInfoIndex)
		{
			this.playerInfoIndex = playerInfoIndex;

			GameManager.PlayerInfo playerInfo = GameManager.Instance.PlayerInfos[playerInfoIndex];

			iconImage.sprite	= playerInfo.icon;
			iconImage.color		= playerInfo.iconColor;

			coinAmountText.text = playerInfo.unlockAmount.ToString();

			unlockButton.SetActive(playerInfo.locked);
			selectButton.SetActive(!playerInfo.locked);
		}

		public void UnlockClicked()
		{
			GameManager.PlayerInfo playerInfo = GameManager.Instance.PlayerInfos[playerInfoIndex];

			if (GameManager.Instance.DropsCollected >= playerInfo.unlockAmount)
			{
				GameManager.Instance.DropsCollected	-= playerInfo.unlockAmount;
				GameManager.Instance.SwapPlayer(playerInfoIndex);
				GameManager.Instance.UnlockedPlayerInfos += ";" + playerInfoIndex;

				playerInfo.locked = false;
				
				unlockButton.SetActive(playerInfo.locked);
				selectButton.SetActive(!playerInfo.locked);
			}
		}

		public void SelectClicked()
		{
			GameManager.Instance.SwapPlayer(playerInfoIndex);
		}

		#endregion
	}
}
