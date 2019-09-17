using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardardatos : MonoBehaviour
{
    public string nombre;
    private void Start()
    {
        nombre = "gato";
        PlayerPrefs.SetString("valor", nombre); 

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(PlayerPrefs.GetString("valor"));
        }
        
    }
}
