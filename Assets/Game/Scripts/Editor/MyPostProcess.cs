using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

namespace Game.Scripts.Editor
{
    public class MyPostProcess
    {
        [PostProcessBuildAttribute(999)]
        public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) {
            Debug.Log( pathToBuiltProject );

            

            string appName = Application.productName.Split('-')[1].Split(" ")[0];
            
           // var apks = Directory.GetFiles(pathToBuiltProject , "*.aab | *.apk");

           //foreach (var apk in apks)
            {
                string extension = Path.GetExtension(pathToBuiltProject);
                string newPath = Application.dataPath + "/../ScreenShots/" + appName + extension;
                
                File.Copy(pathToBuiltProject,newPath,true);
            }
            
        }

        //[PreProcessBuildAttribute()]
        public static void OnPreProcessBuild()
        {
            
        }
    }
}