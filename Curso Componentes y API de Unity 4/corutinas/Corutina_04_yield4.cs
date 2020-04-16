using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_04_yield4 : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Time.timeScale = 0.2f;
        Debug.Log("Frame actual: " + Time.frameCount);
        yield return new WaitForSecondsRealtime(1f); //Espera 1segundo real
        // Independiente de la scala de tiempo
        Debug.Log("Frame actual: " + Time.frameCount);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
