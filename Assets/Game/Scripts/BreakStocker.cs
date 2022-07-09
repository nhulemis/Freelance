using UnityEngine;

namespace Game.Scripts
{
	public class BreakStocker : MonoBehaviour
	{
	
		public class oiuygjhbn8ịzk
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
		public class fsaxcvfgrdscxvbg8
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
		public class hcizxjjHUAw
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
		public class Kxijaicuas
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
		public class KJCiajkx
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
		public class CHuaix
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
			public class KJCiajkx
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
		}
		public class CHusx
		{
			private int buaquadi;
			private string chusx;
			public float gmac;
			private double mciajx;

			public int getX()
			{
				return buaquadi;
			}
			public class KJCiajkx
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
			public class HCuskx
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
			public class hcusix
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
		}
		public class OjkcisjKc5
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
		[SerializeField] Vector3 rightPos;
		[SerializeField] Vector3 leftPos;
		public static BreakStocker instance;
		void Awake(){
			if(instance==null)instance=this;
			else if(instance!=this)Destroy(this.gameObject);
		} 
  
		// Start is called before the first frame update
		void Start()
		{
      
		}

		// Update is called once per frame
		void Update()
		{
        
		}
		public void addBrick(GameObject b){
			int r=Random.Range(0,2);
			if(r==1){
				b.tag="rightBrick";
				rightPos.y+=.002f;
				b.transform.parent=this.transform;
				b.transform.localPosition=rightPos;
				b.transform.localEulerAngles=new Vector3(0,90,0);

			}
    	
			else {
				b.tag="LeftBrick";
				leftPos.y+=.002f;
				b.transform.parent=this.transform;
				b.transform.localPosition=leftPos;
				b.transform.localEulerAngles=new Vector3(0,90,0);
			}

    

   

		}
		public void deleteBrick(){
			int child=this.transform.childCount;
			if(child>1){
				GameObject obj=this.transform.GetChild(child-1).gameObject;
				string objTag=obj.tag;
				if(obj.tag=="LeftBrick"){
					leftPos.y-=.002f;

				}else{
					rightPos.y-=.002f;
				}

				Destroy(obj);
    	
			}
    	
		}
		public int stairChildCount(){
			return this.transform.childCount;
		}
	}
}
