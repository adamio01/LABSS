using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, -0.01f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, 0.01f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0.01f, 0, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-0.01f, 0, 0));
        }

    }
}