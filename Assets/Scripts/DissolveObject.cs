using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    private MeshRenderer render;
    
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        
    }

    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        render.material.SetFloat("_Dissolution", 0.5f);
    }
}
