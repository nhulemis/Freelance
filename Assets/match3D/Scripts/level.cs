using UnityEngine;

namespace match3D.Scripts
{
    [CreateAssetMenu(fileName ="Level1", menuName ="levels")]
    public class level : ScriptableObject
    {
        public int levelIndex;
        
        
        public int levelTime;
        public GameObject[] objectsToSort;

    }
}
