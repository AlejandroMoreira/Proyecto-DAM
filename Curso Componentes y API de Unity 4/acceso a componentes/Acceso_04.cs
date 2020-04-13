using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        print("masa " + rb.mass);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
