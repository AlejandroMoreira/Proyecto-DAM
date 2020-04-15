using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug log
        Debug.Log("Mensaje de infromación");
        Debug.LogWarning("Mensaje de advertencia");
        Debug.LogError("Mensaje de error");

        Debug.LogFormat("Soy el objeto {0}", name);
        Debug.LogWarningFormat("Soy el objeto {0} esto es una advertencia", name);
        Debug.LogErrorFormat("Soy el objeto {0} esto es un error", name);

        Debug.Break(); //pausa
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
