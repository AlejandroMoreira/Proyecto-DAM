using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; //Para que no lo confunda con using

public class Api_12_rand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Aleatorio entre 0-1" + Random.value);
            Debug.Log("Aleatorio entre 5-9" + Random.Range(5f,10f));
            Debug.Log("Aleatorio entre 5-9 (enteros)" + Random.Range(5,10));
        }
    }
}
