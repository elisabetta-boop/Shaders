using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObjec3 : MonoBehaviour
{
    private MeshRenderer render;
    public float duration = 2f;
    
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        //render.material.SetFloat("_Dissolution", 0.5f);
        StartCoroutine(Dissolve());
    }
    IEnumerator Dissolve()
    {
        float startTime = Time.time;
        while(Time.time -startTime <duration)
        {
            float newValue = (Time.time - startTime)/duration;
            render.material.SetFloat("_Dissolution", newValue);
            yield return true;
        }
    }
}
