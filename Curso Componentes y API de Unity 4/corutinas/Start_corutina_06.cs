using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_corutina_06 : MonoBehaviour
{
    Coroutine cr;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            cr = StartCoroutine(Coorutina(2f));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine(cr); //Detiene la coorutina

            //Detiene todas las coorutinas
            //StopAllCoroutines();
        }
    }

    IEnumerator Coorutina(float time) {
        Debug.Log("Soy una corutina, espero 2sec");
        yield return new WaitForSeconds(time);
        Debug.Log("Adios :3");
    }
}
