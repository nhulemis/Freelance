using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoadCreator;

public abstract class Element : MonoBehaviour
{
	[SerializeField] float position;
	public float Position
    {
		get
        {
			return groupElement == null ? position : position + groupElement.Position;
        }
    }
	public float LocalPosition => position;
	public void SetPosition(float p)
	{
		position = p;
	}
	public abstract void Init();
	public abstract void OnHit(GameObject collider);
	protected GroupPath groupPath;
	protected GroupElement groupElement;

	float lastPosition = 0.001f;
	float tmpPos;
	public void UpdatePosition()
    {
		groupElement = transform.parent != null ? transform.parent.GetComponent<GroupElement>() : null;
		if(groupElement == null)
		{
			groupPath = GetComponentInParent<GroupPath>();
		} else
		{
			groupPath = transform.parent != null ? transform.parent.GetComponentInParent<GroupPath>() : null;
		}

		if (groupPath == null)
        {
			return;
        }

		if (!groupPath.Initialized)
		{
			return;
		}


		if (lastPosition == position)
		{
			return;
		}

		if (groupElement != null)
		{
			//Debug.LogError(gameObject.gameObject + ", " + groupElement.name + ", " + Position + "," + groupPath.Length);
		}
			
		float tmpPos = Mathf.Clamp01(Position / groupPath.Length);
		transform.position = groupPath.GetPointAtTime(tmpPos);
		transform.rotation = groupPath.GetDirectionAtTime(tmpPos);
		lastPosition = position;
	}
	protected virtual void ManualValidate()
    {

    }

#if UNITY_EDITOR

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
		UpdatePosition();
		ManualValidate();
	}
#endif
}

[System.Serializable]
public struct ElementData
{
	public float position;
	public Element element;
}
