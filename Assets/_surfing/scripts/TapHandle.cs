using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace cuber 
{
    
    public delegate void UnityAction();
    public class TapHandle : MonoBehaviour, IPointerDownHandler
    {
        public UnityEvent OnPointDownAction;

        public void OnPointerDown(PointerEventData eventData)
        {
            OnPointDownAction  ?.Invoke();
        }
    }
}