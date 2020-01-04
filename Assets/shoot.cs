using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject Bullet_Emitter;

    public GameObject Bullet;

    public float Bullet_Forward_Force;


    public void Shoot()
    {
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
       
        Destroy(Temporary_Bullet_Handler, 5.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
