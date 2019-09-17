using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public Rigidbody balaPrefab, jugador;
    public Transform lanzador;
    public float VelDisparo;
    public float tiempoDisparo;
    private float inicioDisparar;
    public bool gameObject;


    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > inicioDisparar)
        {
            inicioDisparar = Time.time + tiempoDisparo;
            Rigidbody balaPrefabInstanc;

            balaPrefabInstanc = Instantiate(balaPrefab, lanzador.position, Quaternion.identity);
            balaPrefabInstanc.AddForce(lanzador.forward * 100 * VelDisparo);
        }
    }
       /* void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Bala")
            {
                Destroy.gameObject(true);
            }
        }*/
    }



