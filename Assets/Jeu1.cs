using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeu1 : MonoBehaviour
{

    public GameObject jeu1;

    private void OnTriggerEnter(Collider other) {
        if (other.name == "ned")
        {
            jeu1.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
