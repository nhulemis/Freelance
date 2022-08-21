using UnityEngine.UI;

namespace PetsIO.Standard_Assets.CNControls.Scripts
{
	public class EmptyGraphic : Graphic
	{
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			vh.Clear();
		}
	}
}
