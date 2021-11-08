using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObjec4 : MonoBehaviour
{
    private MeshRenderer render;
    public float duration = 2f;
    private float timer = 0 ;
    private bool running = false;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        
    }

    void Update()
    {
        if (running && timer < duration)
        {
            timer += Time.deltaTime;
            float newValue = timer/duration;
            render.material.SetFloat("_Dissolution", newValue);
        }
        
    }

    void OnMouseDown() 
    {
        running = true;
    }
   
}
