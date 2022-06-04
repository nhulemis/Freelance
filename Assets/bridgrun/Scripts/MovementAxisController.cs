using UnityEngine;
using UnityEngine.EventSystems;

namespace bridgrun.Scripts
{
    public class MovementAxisController : MonoBehaviour , IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField]
        RectTransform background;
        private RectTransform baseRect = null;
        public Camera cam;
        public Canvas canvas;

        private void Awake()
        {
            canvas = GetComponentInParent<Canvas>();
            cam = null;




            if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
                cam = canvas.worldCamera;

        }
    


        public virtual void OnPointerDown(PointerEventData eventData)
        {
            print("Pointer Down");
            background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
            // background.anchoredPosition = eventData.position;

            background.gameObject.SetActive(true);
        }
    
    
        public virtual void  OnDrag(PointerEventData eventData)
        {
            print("drag Down");

            cam = null;
        
        
        
            if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
                cam = canvas.worldCamera;


        }

        private Vector2 ScreenPointToAnchoredPosition(Vector2 screenPosition)
        {
            Vector2 localPoint = Vector2.zero;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(baseRect, screenPosition, cam, out localPoint))
            {
                Vector2 pivotOffset = baseRect.pivot * baseRect.sizeDelta;
                return localPoint - (background.anchorMax * baseRect.sizeDelta) + pivotOffset;
            }
            return Vector2.zero;
        }
        public virtual void OnPointerUp(PointerEventData eventData)
        {
        
        }

    }
}
