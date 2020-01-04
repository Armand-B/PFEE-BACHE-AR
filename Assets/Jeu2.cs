using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeu2 : MonoBehaviour
{
    public GameObject coffre;
    public GameObject tuyau;
    public GameObject spawner;
    
    private void OnTriggerEnter(Collider other) {
        if (other.name == "ned")
        {
            tuyau.SetActive(false);
            coffre.SetActive(false);
            other.transform.SetPositionAndRotation(new Vector3(0.017f,-0.355f,-0.123f), new Quaternion(0f,0f,0f,0f));
            spawner.SetActive(true);
        }
    }
}
