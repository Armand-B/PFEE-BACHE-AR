using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeu2 : MonoBehaviour
{
    public GameObject coffre;
    public GameObject tuyau;
    public GameObject spawner;

    public GameObject ordinateur;
    public TextMesh text;

    public GameObject Hologram;
    public GameObject ned;
    
    private void OnTriggerEnter(Collider other) {
        if (other.name == "ned")
        {
            ordinateur.SetActive(true);
            tuyau.SetActive(false);
            coffre.SetActive(false);
            other.transform.SetPositionAndRotation(new Vector3(0.017f,-0.355f,-0.123f), new Quaternion(0f,0f,0f,0f));
            spawner.SetActive(true);
        }
    }

    private void Update() 
    {
        if(text.text == "ReactDOM.render'(\n<h1>Hello,world!</h1>,\ndocument.getElementById('root')\n);")
        {
            ned.transform.SetPositionAndRotation(new Vector3(0.017f,-0.184f,-0.123f), new Quaternion(0f,0f,0f,0f));
            ordinateur.SetActive(false);
            spawner.SetActive(false);
            coffre.SetActive(true);
            tuyau.SetActive(true);
            Hologram.SetActive(true);
            this.gameObject.SetActive(false);
        }    
    }
}
