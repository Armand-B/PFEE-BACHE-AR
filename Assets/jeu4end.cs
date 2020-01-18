using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeu4end : MonoBehaviour
{
    private bool allInactive = false;
    public GameObject[] errors;
    public GameObject error;

    public Animator animator;
    
    private int animationPlayed = 0;
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

        if(allInactive && error.activeSelf && animationPlayed == 0)
        {
            animationPlayed = 1;
            animator.Play("bas gauche");
            StartCoroutine(Wait());
        }
    }
     IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        animator.Play("volant");
        yield return new WaitForSeconds(1);
        animator.Play("ouverture");
         
    }
    
}
