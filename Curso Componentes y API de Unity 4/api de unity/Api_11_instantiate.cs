using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_11_instantiate : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ejemplo 1
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Instantiate(prefab);
        }

        //Ejemplo 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(prefab,position,Quaternion.identity);
        }

        //Ejemplo 3
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10f;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(pos);

            Instantiate(prefab, worldPos, Quaternion.identity);
        }
    }
}
