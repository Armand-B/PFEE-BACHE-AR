using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLettre : MonoBehaviour
{
    public GameObject[] lettres;

    private void OnTriggerEnter(Collider other) {
        if (other.name == "ned")
        {
            foreach (var item in lettres)
            {
                item.SetActive(false);
            }
            this.gameObject.SetActive(false);
        }
    }
}
