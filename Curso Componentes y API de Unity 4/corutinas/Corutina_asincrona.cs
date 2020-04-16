using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_asincrona : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(Shortcoroutine());
        }

    }

    IEnumerator Shortcoroutine()
    {
        Debug.Log("Iniciando proceso corto de forma paralela");
        Coroutine longProcess = StartCoroutine(LongCoroutine());

        Debug.Log("Haciendo las cosas del proceso corto de forma simultánea");
        // ...
        Debug.Log("Proceso corto finalizado, esperando a que termine el largo");
        yield return longProcess;
        Debug.Log("Proceso largo también finalizado, fin de la corutina");

    }

    IEnumerator LongCoroutine()
    {
        Debug.Log("Iniciando proceso terriblemente largo...");
        //...
        yield break;
    }
}
