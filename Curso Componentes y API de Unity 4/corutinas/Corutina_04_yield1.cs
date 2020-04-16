using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_04_yield1 : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("Frame actual: " + Time.frameCount);
        yield break; //Detiene la corutina
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
