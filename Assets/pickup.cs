﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    private int pressed = 0;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        pressed = 0;
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.tag == "fragment" && button.onClick.Equals(true))
        {
            print("ca marche");
        }
    }

}