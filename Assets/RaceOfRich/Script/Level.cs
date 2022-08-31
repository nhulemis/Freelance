using RoadCreator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Level : MonoBehaviour
{
	[SerializeField] int snakeLength;
	public int SnakeLength
	{
		get => snakeLength;
		set
		{
			snakeLength = value;
		}
	}
	public float Width => CurrentPart.Width;
	[SerializeField] float flySpeedMultiply = 2f;
	[SerializeField] LevelPart[] levelParts;
	[SerializeField] EnvironmentTheme theme = EnvironmentTheme.PurpleCity;
	public LevelPart CurrentPart => levelParts[Mathf.Clamp(iPath, 0, levelParts.Length - 1)];
	int iPath = 0;
	float travelDistance = GameConstanst.StartPosition;
	float totalPartTravelDistance = 0f;
	public float TravelDistance => travelDistance;
	public float TravelTime => travelDistance / CurrentPart.Length;
	public float Length { private set; get; } = 0f;
	public float GlobalTravelDistance => totalPartTravelDistance + travelDistance;
	public float speed=5f;
    public void DoFrame()
	{
		travelDistance += Time.smoothDeltaTime *speed;
		if (travelDistance > CurrentPart.Length)
		{
			travelDistance = 0;
			totalPartTravelDistance += CurrentPart.Length;
			CurrentPart.Exit();
			iPath++;
			CurrentPart.Enter();

			CurrentPart.SetActiveEnvironment(true);
			if (CurrentPart.Next != null)
			{
				CurrentPart.Next.SetActiveEnvironment(true);
			}
			if (CurrentPart.Backward != null)
			{
				CurrentPart.Backward.SetActiveEnvironment(false);
			}

		//	Gameplay.Instance.Speed = CurrentPart.Speed;
			if (iPath >= levelParts.Length)
			{
				//Gameplay.Instance.Win();
				return;
			}
			if(iPath == levelParts.Length - 2)
			{
				//Gameplay.Instance.EarnedGem += Gameplay.Instance.Character.Babies.Count * GameConstanst.BABY_VALUE;
				DOVirtual.Float(0, 1, 4f, (value) =>
				{
					RenderSettings.fogStartDistance = Mathf.Lerp(RenderSettings.fogStartDistance, GameConstanst.FogStartDistanceNear, value);
					RenderSettings.fogEndDistance = Mathf.Lerp(RenderSettings.fogEndDistance, GameConstanst.FogEndDistanceNear, value);
				});
			}
			return;
		}
		Vector3 newpos = CurrentPart.GetPointAtTime(travelDistance / CurrentPart.Length);
		//newpos.x = PlayerController.instance.transform.position.x;

		PlayerController.instance.transform.rotation = CurrentPart.GetDirectionAtTime(travelDistance / CurrentPart.Length);
		PlayerController.instance.transform.position = newpos;

		//	Gameplay.Instance.Character.transform.rotation = CurrentPart.GetDirectionAtTime(travelDistance / CurrentPart.Length);
		//	Gameplay.Instance.Character.transform.position = CurrentPart.GetPointAtTime(travelDistance / CurrentPart.Length);
	}

	public void ThrowBack(float distance)
	{
		travelDistance -= distance;
	  //   Gameplay.Instance.Character.transform.rotation = CurrentPart.GetDirectionAtTime(travelDistance / CurrentPart.Length);
		//Gameplay.Instance.Character.MoveTo(CurrentPart.GetPointAtTime(travelDistance / CurrentPart.Length));
	}

	EnvironmentPart[] environmentParts;
	public void Init()
	{
		Length = 0;
		totalPartTravelDistance = 0f;
		levelParts = GetComponentsInChildren<LevelPart>();
		for (int i = 0; i < levelParts.Length; i++)
		{
			levelParts[i].Init();
		    if(levelParts[i].GetType() != typeof(FinishLineController))
				Length += levelParts[i].Length;
		}
		iPath = 0;
		RefreshEnvironment();
		for (int i = 0; i < levelParts.Length; i++)
		{
			levelParts[i].SetActiveEnvironment(i < 2);
		}
	}

	public void RefreshEnvironment()
	{
		environmentParts = GetComponentsInChildren<EnvironmentPart>(true);
		for(int i = 0; i < environmentParts.Length; i++)
		{
			environmentParts[i].ActiveTheme(theme);
		}
	}


        public class xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC()
        {
            
        }
        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC GetxOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(){
        var clasx = new xOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC();
        return  clasx;
    }

    public string RandomStringxOrOtngFMFQREWhrCPUNvSlUpLoFozCTWWUjcheVFgTpyTXiUkixubffcXZizbRMDxuiC(int length)
    {
        string chars = string.Empty;
        return chars;
    }
	private void OnValidate()
	{
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (Application.isPlaying)
		{
			return;
		}

		ValidateLevelPart();
	}

	public void ValidateLevelPart()
	{
		levelParts = GetComponentsInChildren<LevelPart>();
		for (int i = 0; i < levelParts.Length; i++)
		{
			if (i < levelParts.Length - 1)
			{
				levelParts[i].Next = levelParts[i + 1];
			}
			if (i > 0)
			{
				levelParts[i].Backward = levelParts[i - 1];
				var dir = levelParts[i].transform.position - levelParts[i - 1].EndPoint;
				levelParts[i].transform.rotation = Quaternion.LookRotation(levelParts[i - 1].OutDirection, Vector3.up);
				levelParts[i].transform.position = levelParts[i - 1].EndPoint;
			}
		}
		RefreshEnvironment();
	}

	public void RandomTheme()
	{
		try
		{
			var themes = System.Enum.GetValues(typeof(EnvironmentTheme));
			theme = (EnvironmentTheme)Random.Range(0, themes.Length - 1);
		} catch { }
	}
	public void updateSpeedValue(float newSpeedValue)
    {
		speed = newSpeedValue;
    }

	[ContextMenu("Manual Init")]
	public void ManualInit()
	{
		ValidateLevelPart();
	}
}
