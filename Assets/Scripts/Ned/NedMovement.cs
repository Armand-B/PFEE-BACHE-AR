using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NedMovement : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward, Color.blue);
        Debug.DrawRay(transform.position, -transform.forward, Color.blue);
        Debug.DrawRay(transform.position, transform.right, Color.blue);
        Debug.DrawRay(transform.position, -transform.right, Color.blue);
        Debug.DrawRay(transform.position, transform.up, Color.blue);
        Debug.DrawRay(transform.position, -transform.up, Color.blue);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1f))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red);
        }
        else
            Debug.DrawRay(transform.position, transform.forward, Color.blue);

        if (Physics.Raycast(transform.position, -transform.forward, out hit, 1f))
        {
            Debug.DrawRay(transform.position, -transform.forward, Color.red);
        }
        else
            Debug.DrawRay(transform.position, -transform.forward, Color.blue);

        if (Physics.Raycast(transform.position, transform.right, out hit, 1f))
        {
            Debug.DrawRay(transform.position, transform.right, Color.red);
        }
        else
            Debug.DrawRay(transform.position, transform.right, Color.blue);

        if (Physics.Raycast(transform.position, -transform.right, out hit, 1f))
        {
            Debug.DrawRay(transform.position, -transform.right, Color.red);
        }
        else
            Debug.DrawRay(transform.position, -transform.right, Color.blue);

        if (Physics.Raycast(transform.position, transform.up, out hit, 1f))
        {
            Debug.DrawRay(transform.position, transform.up, Color.red);
        }
        else
            Debug.DrawRay(transform.position, transform.up, Color.blue);

        if (Physics.Raycast(transform.position, -transform.up, out hit, 1f))
        {
            Debug.DrawRay(transform.position, -transform.up, Color.red);
        }
        else
            Debug.DrawRay(transform.position, -transform.up, Color.blue);
    }
}
