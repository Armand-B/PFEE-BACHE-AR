using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeu4 : MonoBehaviour
{
    public GameObject errors;
    private void OnTriggerEnter(Collider other) 
    {
        errors.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
