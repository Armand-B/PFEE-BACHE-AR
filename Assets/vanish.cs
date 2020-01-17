using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    public float fadeSpeed = 1.0f;
    private int entered = 0;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.name == "ned")
        {
            entered = 1;
        }    
    }

    private void Update() 
    {
        if(entered == 1)
        {
            Color color = this.GetComponent<MeshRenderer>().material.color ;
            color.a -= fadeSpeed;
            this.GetComponent<MeshRenderer>().material.color = color ;
        }

        if(this.GetComponent<MeshRenderer>().material.color.a < 0.15f)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
         if(other.name == "ned")
        {
            entered = 0;
        }  
    }
}
