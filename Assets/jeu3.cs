using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeu3 : MonoBehaviour
{
    public GameObject fragments;
    public GameObject empty;

 
    private void OnTriggerEnter(Collider other) 
    {
        empty.SetActive(true);
        fragments.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
