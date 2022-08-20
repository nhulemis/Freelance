using System;
using UnityEngine;
using UnityEngine.Purchasing;

namespace PetsIO._Scripts.other
{
	public class InAppManager : MonoBehaviour, IStoreListener
	{
		private static IStoreController m_StoreController;
		private static IExtensionProvider m_StoreExtensionProvider;
		
		
		public const string pgold2000 = "gold20000";
		public const string pgold5000 = "gold100000";
		public const string pgold15000 = "gold15000";
		public const string pgem20 = "randomskin";
		public const string pgem50 = "gem50";
		public const string pgem500 = "gem500";
		public const string pNoAds = "gp_no_ads";
		
		void Start()
		{
			DontDestroyOnLoad(this.gameObject);
			if (m_StoreController == null)
			{
				InitializePurchasing();
			}

			
		}
		
		
		public void InitializePurchasing()
		{
			if (IsInitialized())
			{
				return;
			}
			
			var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
			builder.AddProduct(pgold2000, ProductType.Consumable, new IDs() { { pgold2000, GooglePlay.Name } });
			builder.AddProduct(pgold5000, ProductType.Consumable, new IDs() {  { pgold5000, GooglePlay.Name } });
			builder.AddProduct(pgold15000, ProductType.Consumable, new IDs() {  { pgold15000, GooglePlay.Name } });
			builder.AddProduct(pgem20, ProductType.Consumable, new IDs() { { pgem20, GooglePlay.Name } });
			builder.AddProduct(pgem50, ProductType.Consumable, new IDs() {  { pgem50, GooglePlay.Name } });
			builder.AddProduct(pgem500, ProductType.Consumable, new IDs() {  { pgem500, GooglePlay.Name } });
			builder.AddProduct(pNoAds, ProductType.NonConsumable, new IDs() {  { pNoAds, GooglePlay.Name } });

			
			UnityPurchasing.Initialize(this, builder);
		}
		
		private bool IsInitialized()
		{
			return m_StoreController != null && m_StoreExtensionProvider != null;
		}
		
		public void BuyProductID(string productId)
		{
			try
			{
				if (IsInitialized())
				{
					Product product = m_StoreController.products.WithID(productId);
					
					if (product != null && product.availableToPurchase)
					{
						Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));// ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed asynchronously.
						m_StoreController.InitiatePurchase(product);
					}
					else
					{
						Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
					}
				}
				else
				{
					Debug.Log("BuyProductID FAIL. Not initialized.");
				}
			}
			catch (Exception e)
			{
				Debug.Log("BuyProductID: FAIL. Exception during purchase. " + e);
			}
		}
		
		public void RestorePurchases()
		{
			if (!IsInitialized())
			{
				Debug.Log("RestorePurchases FAIL. Not initialized.");
				return;
			}
			
			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
			{
				Debug.Log("RestorePurchases started ...");
				
				var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
				apple.RestoreTransactions((result) =>
				                          {
					Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
				});
			}
			else
			{
				Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
			}
		}
		
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
			Debug.Log("OnInitialized: Completed!");
			
			m_StoreController = controller;
			m_StoreExtensionProvider = extensions;
		}
		
		public void OnInitializeFailed(InitializationFailureReason error)
		{
			Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
		}
		
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			if (String.Equals(args.purchasedProduct.definition.id, pgold2000, StringComparison.Ordinal))
			{
				if (GameObject.Find("GUI"))
				{
					GameObject.Find("GUI").SendMessage("SetGold", 20000);
					GameObject.Find("GUI").SendMessage("GoldEffect");
				}

				//PlayerPrefs.SetInt("gem", PlayerPrefs.GetInt("gem")+5);
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pgold5000, StringComparison.Ordinal))
			{
				
				if (GameObject.Find("GUI"))
				{
					GameObject.Find("GUI").SendMessage("SetGold", 100000);
					GameObject.Find("GUI").SendMessage("GoldEffect");
				}
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pgold15000, StringComparison.Ordinal))
			{
				
				//PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold")+50000);
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pgem20, StringComparison.Ordinal))
			{
				
				if (GameObject.Find("GUI"))
				{
					GameObject.Find("GUI").SendMessage("RandomSkin", 20);
				}
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pgem50, StringComparison.Ordinal))
			{
				
				PlayerPrefs.SetInt("gem", PlayerPrefs.GetInt("gem")+100);
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pgem500, StringComparison.Ordinal))
			{
				
				PlayerPrefs.SetInt("gem", PlayerPrefs.GetInt("gem")+800);
			}
			else if (String.Equals(args.purchasedProduct.definition.id, pNoAds, StringComparison.Ordinal))
			{
				PlayerPrefs.SetInt("noads", 1);
			}
			

			return PurchaseProcessingResult.Complete;
		}
		
		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
			Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
		}
	}
}