// <<<<<<< HEAD
// using System.Collections;
// using System.Collections.Generic;
// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;
//
// [ExecuteAlways]
// public class ThemeColor : MonoBehaviour
// {
//
//     [SerializeField] private string _descript;
//     [SerializeField] private TextMeshProUGUI description;
//     [SerializeField] private Color background;
//
//     [SerializeField] private Color itemArea;
//
//     [SerializeField] private Color highlight;
//
//     [SerializeField] private Image[] sprBackgrounds;
//     [SerializeField] private Image[] sprItemAreas;
//     [SerializeField] private Image[] sprHighLights;
//     
//     // Start is called before the first frame update
//     void OnEnable()
//     {
//         description.text = _descript;
//         foreach (var bg in sprBackgrounds)
//         {
//             bg.color = background;
//         }
//
//         foreach (var sprItemArea in sprItemAreas)
//         {
//             sprItemArea.color = itemArea;
//         }
//
//         foreach (var sprHighLight in sprHighLights)
//         {
//             sprHighLight.color = highlight;
//         }
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//     }
// }
// =======
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
//
// [ExecuteAlways]
// public class ThemeColor : MonoBehaviour
// {
//     [SerializeField] private Color background;
//
//     [SerializeField] private Color itemArea;
//
//     [SerializeField] private Color highlight;
//
//     [SerializeField] private Image[] sprBackgrounds;
//     [SerializeField] private Image[] sprItemAreas;
//     [SerializeField] private Image[] sprHighLights;
//     
//     // Start is called before the first frame update
//     void OnEnable()
//     {
//         // foreach (var bg in sprBackgrounds)
//         // {
//         //     bg.color = background;
//         // }
//         //
//         // foreach (var sprItemArea in sprItemAreas)
//         // {
//         //     sprItemArea.color = itemArea;
//         // }
//         //
//         // foreach (var sprHighLight in sprHighLights)
//         // {
//         //     sprHighLight.color = highlight;
//         // }
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.A)){ // capture screen shot on left mouse button down
//
//             string folderPath = "Assets/../Screenshots/"; // the path of your project folder
//
//             if (!System.IO.Directory.Exists(folderPath)) // if this path does not exist yet
//                 System.IO.Directory.CreateDirectory(folderPath);  // it will get created
//             
//             var screenshotName =
//                 "Screenshot_" +
//                 System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + // puts the current time right into the screenshot name
//                 ".png"; // put youre favorite data format here
//             ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName),1); // takes the sceenshot, the "2" is for the scaled resolution, you can put this to 600 but it will take really long to scale the image up
//             Debug.Log(folderPath + screenshotName); // You get instant feedback in the console
//         }
//     }
// }
// >>>>>>> Sufing-812-10
