using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_sincrona : MonoBehaviour
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
        Debug.Log("Iniciando proceso corto");
        yield return StartCoroutine(LongCoroutine());
        Debug.Log("Proceso largo finalizado, continuando el proceso corto");
    }

    IEnumerator LongCoroutine()
    {
        Debug.Log("Iniciando proceso terriblemente largo...");
        //...
        yield break;
    }
}
