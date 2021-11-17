using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObjectSecond : MonoBehaviour
{
    //public List<Material> dissolveMaterials;
    private MeshRenderer render;
    public float duration = 2f;
    private float finalValue = 0f;
    
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        
    }

    void Update()
    {
        float currentValue  = render.material.GetFloat("_Dissolution2");
        float newValue= Mathf.Lerp(currentValue, finalValue, Time.deltaTime);
        render.material.SetFloat("_Dissolution2", newValue);
    }

    void OnMouseDown() 
    {
        //render.material.SetFloat("_Dissolution", 0.5f);
        //StartCoroutine(Dissolve());
        finalValue = 1f;
    }

//     IEnumerator Dissolve ()
//     {
//     float dissolveValue = 0f;

//     Debug.Log("Dissolve coroutine started");
//     while (dissolveValue < 1f)
//     {
//         dissolveValue += 0.02f;
//         dissolveValue = Mathf.Clamp01(dissolveValue);
//         foreach (Material mat in dissolveMaterials)
//         {
//             mat.SetFloat("Vector1_66CEB364", dissolveValue);
//         }
//         //sum 0.02 each time takes 50 times to reach 1, so we have 50 iterations
//         yield return new WaitForSeconds(duration/50f);
//     }
// }   
}
