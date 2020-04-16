using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_corutina_05 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(Coorutina(2f));
        }
    }

    IEnumerator Coorutina(float time) {
        Debug.Log("Soy una corutina, espero 2sec");
        yield return new WaitForSeconds(2f);
        Debug.Log("Adios :3");
    }
}
