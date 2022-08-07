
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Base class for ColorBrightLogic and ColorDarkLogic
/// </summary>
public class ColorBase : MonoBehaviour 
{
	public SpriteRenderer sr;
	public Camera cam;
	public Image im;
	public Text txt;

	public float timeAnim = 0.3f;

	void Awake()
	{
		sr = GetComponent<SpriteRenderer>();
		cam = GetComponent<Camera>();
		im = GetComponent<Image>();
		txt = GetComponent<Text>();
	}

	void OnEnable()
	{
		GameManager.OnColorChanged += OnColorChanged;
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
  public class kjhzcxiouaw
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class ỌIcklaw
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class OIUCklajwio
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class OIcuklajw
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
  public class OCIujalkw
  {
    public string id;
    public Sprite icon;
    public string price;
    public string title;

  }
	void OnDisable()
	{
		GameManager.OnColorChanged -= OnColorChanged;
	}

	public virtual void OnColorChanged (AAColor c)
	{

	}

	public virtual void SetColor(Color c)
	{
		if(cam != null)
			cam.backgroundColor = c;

		if(sr != null)
			sr.color = c;

		if(im != null)
			im.color = c;

		if(txt != null)
			txt.color = c;
	}
}
