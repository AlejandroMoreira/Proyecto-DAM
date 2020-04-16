using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_04_yield3 : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitForSeconds(3f); //Detiene por 3 segundos
        Debug.Log("Frame actual: " + Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
