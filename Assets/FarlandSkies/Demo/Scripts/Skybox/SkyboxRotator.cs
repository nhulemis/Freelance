using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float RotationPerSecond = 1;
 
        public class AXXXSPYSVCLKVHDRKGDINHQXFAVYHYVBTD
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

        public class RSCTHGDSCSIRXELEKJUZLXXCZIGXMVK
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
   private bool _rotate;

    protected void Update()
    {
        if (_rotate) RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }

    public void ToggleSkyboxRotation()
    {
        _rotate = !_rotate;
    }
}