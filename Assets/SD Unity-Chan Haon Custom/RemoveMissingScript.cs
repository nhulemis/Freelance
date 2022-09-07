using System.Collections;
using System.Collections.Generic;

using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class RemoveMissingScript : MonoBehaviour
{
#if UNITY_EDITOR

    [Button]
    public void RemoveMissing()
    {
        int count = Remove(transform);
        Debug.Log($"Removed {count} missing scripts");
    }

    private int Remove(Transform go)
    {
        int count = GameObjectUtility.RemoveMonoBehavioursWithMissingScript(go.gameObject);

        foreach (Transform child in go)
        {
            count += Remove(child);
        }

        return count;
    }
#endif

}
