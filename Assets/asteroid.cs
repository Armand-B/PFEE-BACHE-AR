using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(0,-speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -0.400)
        {
            Destroy(this.gameObject);
        }  
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "bullet")
        {
            Destroy(this.gameObject);
        }  
    }
}
