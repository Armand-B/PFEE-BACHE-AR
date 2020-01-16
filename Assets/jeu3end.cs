using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeu3end : MonoBehaviour
{
    public GameObject empty;
    public GameObject hologram4;
    public GameObject jeu3;
    private bool allInactive = false;
    public GameObject[] empties;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allInactive = true;
        foreach (var item in empties)
        {
            if(item.activeSelf)
            {
                allInactive = false;
            }

        }

        if(allInactive && empty.activeSelf)
        {
            jeu3.SetActive(false);
            hologram4.SetActive(true);
        }
    }
}
