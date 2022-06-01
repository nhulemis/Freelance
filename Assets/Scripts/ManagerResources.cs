using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="ManagerVars",menuName ="Create Manager Vars",order =0)]
public class ManagerResources : ScriptableObject
{
    [Serializable]
    public class Character
    {
        public string name;
        public Sprite imgChar;
    }


    public List<Character> characters;
    public int initObstacle;
    public Vector2 stepHigh;

    public List<GameObject> norPlatform;

}
