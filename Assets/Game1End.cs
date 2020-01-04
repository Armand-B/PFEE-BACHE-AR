using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1End : MonoBehaviour
{
    public GameObject jeu1;
    public GameObject jeu2;
    public GameObject hologram1;
    public GameObject hologram2;
    public GameObject[] letters;
    private bool allInactive = false;
    void Update()
    {
        allInactive = true;
        foreach (var item in letters)
        {
            if(item.activeSelf)
            {
                allInactive = false;
            }

        }

        if(allInactive)
        {
            jeu1.SetActive(false);
            jeu2.SetActive(true);
            hologram1.SetActive(false);
            hologram2.SetActive(true);
        }
    }
}
