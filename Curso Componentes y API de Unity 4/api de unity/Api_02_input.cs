using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_02_input : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Se ha pulsado la tecla " + KeyCode.Space);
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            Debug.Log("Se ha soltado la tecla" + KeyCode.Space);
        }

    }

    private void OnGUI()
    {
        GUILayout.Label("Tecla pulsada "+ Input.GetKey(KeyCode.Space));
        GUILayout.Label("Tecla pulsada "+ Input.anyKey);
    }
}
