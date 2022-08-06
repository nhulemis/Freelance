
/***********************************************************************************************************
 * Produced by App Advisory	- http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/



using UnityEngine;
using System.Collections;
using UnityEditor;
using System;

namespace AppAdvisory.AmazingBrick
{

    /// <summary>
    /// Loop between layers, and only create "Layer Name" if doesn't exist 
    /// and also is slot are null or empty.
    /// </summary>
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif

    public class TagLayerClass
    {

        internal const string ShadowLayer = "ShadowLayer";
        internal const string Background1Layer = "Background1Layer";
        internal const string Background2Layer = "Background2Layer";
        internal const string ForegroundLayer = "ForegroundLayer";
        internal const string msg = "Gravity Ball is trying to set the Shadow Layer: " + ShadowLayer + " . Do you allow to Gravity Ball create a new layer in a empty slot?";


        static TagLayerClass()
        {
            findLayer(ShadowLayer);
            createLayer();

        }

        static bool layerHasBeenCreated()
        {
            int r = PlayerPrefs.GetInt("gravityballlLayerCreated", 0);
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void SaveNoLayerExist()
        {
            PlayerPrefs.SetInt("gravityballlLayerCreated", 0);
        }
        static void SaveWhenCreateLayer()
        {
            PlayerPrefs.SetInt("gravityballlLayerCreated", 1);//
        }

        static void findLayer(string layerName)
        {
            SerializedObject SerializedObjectTagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
            bool showChildren = true;
            bool layerWasCreated = false;

            SerializedProperty layers = SerializedObjectTagManager.FindProperty("layers");
            if (layers == null || !layers.isArray)
            {
                Debug.LogWarning("Can't set up the layers.  It's possible the format of the layers and tags data has changed in this version of Unity.");
                Debug.LogWarning("Layers is null: " + (layers == null));
                return;
            }

            while (layers.NextVisible(showChildren))
            {
                if (layers.displayName.Contains("Elem") && layers.stringValue.Contains(layerName))
                {
                    layerWasCreated = true;//
                    break;
                }

            }

            if (!layerWasCreated)
            {//
                SaveNoLayerExist();
            }

        }

        static void createLayer()
        {


            SerializedObject SerializedObjectTagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
            bool showChildren = true;
            bool layerWasCreated = layerHasBeenCreated();

            if (layerWasCreated)
                return;

#if UNITY_5_3_OR_NEWER

            //		if(EditorUtility.DisplayDialog("Gravity Ball",msg,"Yes", "Cancel")){


            SerializedProperty layers = SerializedObjectTagManager.FindProperty("layers");
            if (layers == null || !layers.isArray)
            {
                Debug.LogWarning("Can't set up the layers.  It's possible the format of the layers and tags data has changed in this version of Unity.");
                Debug.LogWarning("Layers is null: " + (layers == null));
                return;
            }

            int countLayer = 0;
            while (layers.NextVisible(showChildren))
            {
                if (countLayer > 8)
                {
                    if (layers.displayName.Contains("Elem") && string.IsNullOrEmpty(layers.stringValue))
                    {
                        //Debug.Log(layers.displayName);
                        //Debug.Log(layers.stringValue);//
                        layers.stringValue = ShadowLayer;
                        layers.NextVisible(showChildren);
                        layers.stringValue = Background1Layer;
                        layers.NextVisible(showChildren);
                        layers.stringValue = Background2Layer;
                        layers.NextVisible(showChildren);
                        layers.stringValue = ForegroundLayer;
                        SaveWhenCreateLayer();
                        // display ok
                        //						EditorUtility.DisplayDialog("Gravity Ball", "Layer [" + ShadowLayer + "] has been created in User Layer Slot " + (countLayer-1), "Ok");
                        break;
                    }
                }

                if (layers.editable)
                    countLayer++;
            }
            //		}



#else


		    if(EditorUtility.DisplayDialog("gravityballL Setup Layer Name",msg,"Yes", "Cancel")){

		    SerializedProperty it = SerializedObjectTagManager.GetIterator();

		    while(it.NextVisible (showChildren)){


		    string a = it.displayName;
		    bool canLoop = a.Contains("User Layer");
		    if(canLoop && layerWasCreated == false){
		    if(string.IsNullOrEmpty(it.stringValue)){
		    it.stringValue = LayerName;
		    SaveWhenCreateLayer();
		    break;
		    }
		    }

		    }
		    }
#endif

            SerializedObjectTagManager.ApplyModifiedProperties();

        }
    }
}
