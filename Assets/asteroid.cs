using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public TextMesh text;
    public float speed = 10.0f;
    private Rigidbody rb;
    private int index = 0;

    // je dois pas etre au bon endroit , je ne peux pas acceder au 3dtext depuis une instance de prefab
    private string textCode = "ReactDOM.render'(<h1>Hello, world!</h1>,document.getElementById('root'));";

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
            if(index == 17 || index == 40 || index == 70)
                text.text += "\n";
            text.text += textCode[index];
            index++;
            Destroy(this.gameObject);
        }  
    }
}
