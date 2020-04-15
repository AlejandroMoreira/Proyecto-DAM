using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_07_camara : MonoBehaviour
{

    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        if (camera == Camera.main)
        {
            Debug.Log("Coinciden");
        }
        else {
            Debug.Log("No coinciden");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
