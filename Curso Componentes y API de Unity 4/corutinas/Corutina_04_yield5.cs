using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_04_yield5 : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitForFixedUpdate(); //Se espera al fixed update
        Debug.Log("Frame actual: " + Time.frameCount);
    }

    private void FixedUpdate()
    {
        Debug.Log("Soy el fixupdate");
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
