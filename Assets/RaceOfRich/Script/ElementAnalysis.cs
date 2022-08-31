using RoadCreator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ElementAnalysis : MonoBehaviour
{
	[SerializeField] Level levelPrefab;
	[SerializeField] GroupPath[] groupPaths;
	/*[SerializeField] GroupElement[] babyPatterns;
	[SerializeField] GroupElement[] colorPatterns;
	[SerializeField] GroupElement[] blockPatterns;
	[SerializeField] GroupElement[] obstaclePatterns;*/
	[SerializeField] Element[] singlePatterns;
	//[SerializeField] Kicker megaKicker;

	float ELEMENT_DISTANCE = 5f;

	public Level GenerateLevel(float difficulty)
	{
		//var randomPercent = new RandomPercent(0, 0, 30, 30, 40);
		var level = Instantiate(levelPrefab);
		int index1=getCurrentLeveIndex();
#if UNITY_EDITOR
		var road = PrefabUtility.InstantiatePrefab(groupPaths[index1]) as GroupPath;
#else
		var road = Instantiate(groupPaths[index1]);
#endif
		road.transform.SetParent(level.transform);
		road.transform.SetAsFirstSibling();
		road.CalculateEvenlySpacedPoints();
		
		var currentLength = 0f;
		var elementList = new List<Element>(2);


		var currentPosition = 20f;
		for(int i = 0; i < elementList.Count; i++)
		{
			elementList[i].transform.SetSiblingIndex(i);
			elementList[i].SetPosition(currentPosition);
			currentPosition += GetElementLength(elementList[i]) + ELEMENT_DISTANCE;
		}

		level.SnakeLength = Random.Range(3, 7);
		//level.RandomTheme();
		road.InitEditor();
		level.ValidateLevelPart();
		level.Init();
		return level;
	}

	public Element GetElement(int id, float difficulty)
	{
		return null;
	}

	public float GetElementLength(Element e)
	{
		var isGroupElement = e.GetType() == typeof(GroupElement);
		if(!isGroupElement)
		{
			return 8;
		}

		List<Element> elements = new List<Element>(2);
		e.GetComponentsInChildren(elements);
		if(elements.Count > 0 && elements.Contains(e))
		{
			elements.Remove(e);
		}
		
		if(elements != null && elements.Count > 0)
		{
			var maxElement = elements[0];
			foreach(var v in elements)
			{
				if(v.LocalPosition > maxElement.LocalPosition && v != e)
				{
					maxElement = v;
				}

			}
			return maxElement.LocalPosition;
		}

		return 0;
	}

	public float GetTotalMinColor(Element e)
	{
		var isGroupElement = e.GetType() == typeof(GroupElement);
		if (!isGroupElement)
		{
			return 0;
		}

		return 0;
	}

	public int GetRescueCount(Element e)
	{
		var isGroupElement = e.GetType() == typeof(GroupElement);
		if (!isGroupElement)
		{
			return 0;
		}

		return 0;
	}
	private int getCurrentLeveIndex()
    {
		return PlayerPrefs.GetInt("CurrentLevel");
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

        public class xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd
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

        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd()
        {
            
        }
        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd GetxfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(){
        var clasx = new xfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd();
        return  clasx;
    }

    public string RandomStringxfdIUkkioMzqdbkorRDOSubjOmMsFhgIYUqHhnVHMASuNuouHLOFXsADEuthXsd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz
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

        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz()
        {
            
        }
        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz GetNTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(){
        var clasx = new NTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz();
        return  clasx;
    }

    public string RandomStringNTTcShaivXljhaqzwDPipGeGSKFRcbZmaiXvxbcHRZrlZxXvtLRZALYGoMKIcJFTxzIz(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv
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

        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv()
        {
            
        }
        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv GetXmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(){
        var clasx = new XmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv();
        return  clasx;
    }

    public string RandomStringXmxBrwkLAaDTHacFGGEKzpHCKPrrbuenwzzmqtBLofYdoyEyXqiqXkbifv(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG
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

        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG()
        {
            
        }
        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG GetvBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(){
        var clasx = new vBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG();
        return  clasx;
    }

    public string RandomStringvBQTLDFHYtHGOVtKcZKjvRSopSHziIAvwzISnRSftcAHYqZjGnLtXUwdibdtwG(int length)
    {
        string chars = string.Empty;
        return chars;
    }
	private void Start()
	{
		return;
#if UNITY_EDITOR
		for(int i = 59; i <= 60; i ++)
		{
			var difficulty = (float)i / 60f + Random.Range(-0.2f, 0.2f);
			var level = GenerateLevel(Mathf.Clamp01(difficulty));
			PrefabUtility.SaveAsPrefabAsset(level.gameObject, $"Assets/Gameplay/Resources/Level{i}.prefab");
			level.gameObject.SetActive(false);
		}
#endif
	}
}
