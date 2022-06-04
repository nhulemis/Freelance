using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Vector3[] vertices;
    private Mesh mesh;
    private int Length;
    // Start is called before the first frame update
    void Start()
    {
        mesh=this.GetComponent<MeshFilter>().mesh;
        vertices=mesh.vertices;
        Length=vertices.Length;

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
