using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_enemigos : MonoBehaviour
{
    public GameObject x;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            Destroy(gameObject,0.5f);
        }
    }
  

   /* void OnTriggerEnter( object collider)
    {
        if(collider.tag == "bala")
        {
            balas_disparadas += 1;
            Destroy(collider.gameObject);
            if(balas_necesarias == balas_disparadas)
            {
                Destroy(this.collider);
            }
        }
    }

   
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Destroy(other, 3);
    }
  
    void OnCollisionEnter(Collision collision)
    {
        if(other.gameObject.tag == "bala")
        {
            Destroy(gameObject, 0.5f);
        }
      if( Input.GetButton("Fire1"))
        {
            Destroy(other, 1);
        }
    }*/
  
}
