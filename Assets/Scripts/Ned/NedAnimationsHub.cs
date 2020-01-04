using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NedAnimationsHub : MonoBehaviour
{
    public Transform targetVR, targetSimu;
    private Transform target;

    void Start()
    {
        if (targetVR.gameObject.activeInHierarchy)
            target = targetVR;
        else
            target = targetSimu;
    }

    void Update()
    {
        transform.LookAt(target);
    }
}
