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

    public Animator animator;
    private int end = 1;

    
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
        if(text.text == "ReactDOM.render'(\n<h1>Hello,world!</h1>,\ndocument.getElementById('root')\n);" && end == 1)
        {
            coffre.SetActive(true);
            ned.transform.SetPositionAndRotation(new Vector3(0.017f,-0.184f,-0.123f), new Quaternion(0f,0f,0f,0f));
            ordinateur.SetActive(false);
            spawner.SetActive(false);
            tuyau.SetActive(true);
            Hologram.SetActive(true);
            this.gameObject.SetActive(false);
            ned.GetComponent<pickup>().attached = 0;
            ned.GetComponent<shoot>().enabled = false;
            StartCoroutine(Animation());
            coffre.GetComponent<Animator>().Play("haut droite");
            end = 0;
           
        }    
    }
   IEnumerator Animation()
    {
         
         yield return new WaitForSeconds(2); 
         
         //animator.Play("haut droite");
    }
    
 
}
