using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    private int pressed = 0;
    public Button button;

    private int attached = 0;
    // Start is called before the first frame update
    void Start()
    {
         button.onClick.AddListener(MyAction);
    }

    // Update is called once per frame
    void Update()
    {   
        pressed = 0;
    }

    private void OnTriggerStay(Collider other) 
    {
       
        if(other.tag == "fragment" && attached == 1)
        {
            attached = 0;
            other.transform.parent = this.transform;
        }
    }

      void MyAction()
    {
        attached = 1;
    }

}
