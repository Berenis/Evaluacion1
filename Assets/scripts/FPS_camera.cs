using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_camera : MonoBehaviour
{
    public Camera FPSCamera;

    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPSCamera.transform.Rotate(v, 0, 0);

       /* if(Input.GeyKey(keyCode.W))
        {
            transform.traslate(0, 0, 0.1f);
        }
        else
        {
            if (Input.GetKey(keyCode.S))
            {
                transform.Traslate(0, 0, -0.1f);
            }
            else
            {
                if(Input.GetKey(keyCode.A))
                {
                    transform.Traslate(-0.1f, 0, 0);
                }
                else
                {
                    if (Input.GetKey(keyCode.D))
                    {
                        transform.Traslate(0.1f, 0, 0);
                    }
                }
            }
        }*/
    }
    
}
