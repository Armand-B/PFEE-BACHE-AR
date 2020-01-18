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

    public Animator animator;

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
            animator.Play("bas droite");
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        hologram4.SetActive(true);
        jeu3.SetActive(false);
    }
}
