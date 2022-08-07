
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

/// <summary>
/// Class in of the input (mobile, web and desktop) in the game
/// </summary>
public class InputTouch : MonoBehaviour
{
	/// <summary>
	/// Delegate subscribe by the GameManager and trigger when the player mahe a touch/click
	/// </summary>
	public delegate void TouchScreen(Vector2 position);
	public static event TouchScreen OnTouchScreen;

	/// <summary>
	/// To block input when showing the rate us popup
	/// </summary>
	public bool BLOCK_INPUT = false;

	/// <summary>
	/// Listening for inputs
	/// </summary>
	void Update () 
	{
		if(BLOCK_INPUT)
			return;

		if (Application.isMobilePlatform) 
		{
			int nbTouches = Input.touchCount;

			if(nbTouches > 0)
			{
				Touch touch = Input.GetTouch(0);

				TouchPhase phase = touch.phase;

				if (phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(0))
				{
          Log.Debug("zo");
					Vector2 pos = touch.position;

					if(OnTouchScreen != null)
						OnTouchScreen(pos);
				}


			}
		}
		else
		{
			if (Input.GetMouseButtonDown (0) && !EventSystem.current.IsPointerOverGameObject())
			{
				Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Log.Debug("zo2");

				if(OnTouchScreen != null)
					OnTouchScreen(pos);
			}

		}
	}

  public class Lkjawmvawvs
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class LIOjkkc
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class IOiucv
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
}
