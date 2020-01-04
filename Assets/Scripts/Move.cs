using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject niveau;
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction =  transform.up * variableJoystick.Vertical + transform.right/4 * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        if (direction == Vector3.zero)
        {
            this.GetComponent<Rigidbody>().drag = 30;
        }
        else if(variableJoystick.Vertical < 0)
        {
            this.GetComponent<Rigidbody>().drag = 30;
        }
        else
        {
             this.GetComponent<Rigidbody>().drag = 5;
        }
    }
}
