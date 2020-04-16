using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Mensaje",5f);
        InvokeRepeating("Mensaje",5f,2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Mensaje(){
        Debug.Log("Hola");
    }
}
