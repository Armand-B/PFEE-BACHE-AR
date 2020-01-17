using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeu4end : MonoBehaviour
{
    private bool allInactive = false;
    public GameObject[] errors;

    public Animator animator;
    void Update()
    {
         allInactive = true;
        foreach (var item in errors)
        {
            if(item.activeSelf)
            {
                allInactive = false;
            }

        }

        if(allInactive)
        {
            animator.Play("bas droite");
            animator.Play("volant");
        }
    }
}
