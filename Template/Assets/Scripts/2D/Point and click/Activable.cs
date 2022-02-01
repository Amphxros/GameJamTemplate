using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activable : MonoBehaviour
{
    [SerializeField] private Material mOutlineMaterial_;
    [SerializeField] private float mOutlineScaleFactor_;
    [SerializeField] private Color mColor_;

    private Renderer mRenderer_;
    private bool isCreated=false;

    Renderer createOutline(Material mat, float scale, Color c){
        GameObject g= Instantiate(this.gameObject, transform.position, transform.rotation, transform);
        Renderer rend= g.GetComponent<Renderer>();
        rend.material=mat;
        rend.material.SetColor("outline color", c);
        rend.material.SetFloat("outline float", scale);
        rend.shadowCastingMode= UnityEngine.Rendering.ShadowCastingMode.Off;


        g.GetComponent<Activable>().enabled= false;
        g.GetComponent<Collider>().enabled= false;

        rend.enabled=true;

        return rend;
    }

    private void OnMouseDown() {
        if(!isCreated){
            mRenderer_= createOutline(mOutlineMaterial_, mOutlineScaleFactor_, mColor_);
            isCreated=true;
        }
        else{
            Destroy(mRenderer_.gameObject);
            isCreated=false;
        }

    }
    
}
