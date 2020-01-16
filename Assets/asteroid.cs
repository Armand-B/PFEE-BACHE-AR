using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public GameObject text;
    public float speed = 10.0f;
    private Rigidbody rb;
    private static int index = 0;

    // je dois pas etre au bon endroit , je ne peux pas acceder au 3dtext depuis une instance de prefab
    private List<string> textCode = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        textCode.Add("ReactDOM");
        textCode.Add(".render'(\n");
        textCode.Add("<h1>Hello,");
        textCode.Add("world!</h1>,\n");
        textCode.Add("document");
        textCode.Add(".getElementById");
        textCode.Add("('root')\n);");
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
        text = GameObject.Find("Codetxt");
        if(other.tag == "bullet")
        {
            if(index < 7)
            {
                text.GetComponent<TextMesh>().text += textCode[index];
                index++;

            }
            Destroy(this.gameObject);
        }  
    }
}
