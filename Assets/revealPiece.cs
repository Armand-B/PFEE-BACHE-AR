using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revealPiece : MonoBehaviour
{
    public string fragmentName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.Find(fragmentName))
        {
            this.gameObject.SetActive(false);
            other.transform.Find(fragmentName).gameObject.SetActive(false);
        }
    }
}
