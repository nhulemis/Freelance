using UnityEngine;
using UnityEngine.Purchasing;
using Product = UnityEngine.Purchasing.Product;

namespace Game
{
    public class StoreManager : MonoBehaviour
    {
        private string buyNotThing = "com.DefaultCompany.StepJump.BuySomething";

        private string unlockLevel = "com.DefaultCompany.StepJump.UnlockLevel";

        private Toast _toast;
        // Start is called before the first frame update
        void Start()
        {
            _toast = FindObjectOfType<Toast>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void OnPurchaseComplete(Product prod)
        {
            _toast.SaySomething(prod.definition.id );
        }

        public void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
        {
            _toast.SaySomething($"{product.definition.id} failed 'coz {reason}");
        }
    
    }
}
