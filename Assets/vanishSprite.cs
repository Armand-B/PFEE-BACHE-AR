using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanishSprite : MonoBehaviour
{
    public float fadeSpeed = 0.005f;
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
            Color color = this.GetComponent<SpriteRenderer>().color ;
            color.a -= fadeSpeed;
            this.GetComponent<SpriteRenderer>().color = color ;
        }

        if(this.GetComponent<SpriteRenderer>().color.a < 0.15f)
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
