using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_03 : MonoBehaviour
{
    float count = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("1 HOLIS");
            StartCoroutine(CounterCoroutine());
            Debug.Log("2 HOLIS");
        }

    }

    IEnumerator CounterCoroutine()
    {
        count = 0f;
        while (count < 1f)
        {
            count += .1f;
            Debug.Log("Counter: " + count);
            yield return new WaitForSeconds(1f); //Hasta un segundo no se vuelve a ejecutar
        }
    }
}
