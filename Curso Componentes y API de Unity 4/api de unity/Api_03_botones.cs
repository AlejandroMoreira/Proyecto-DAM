using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_03_botones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("Botón Fire1 pulsado");
        }

        if (Input.GetButtonUp("Fire1")) {
            Debug.Log("Botón Fire1 liberado");
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("Fire1: " + Input.GetButton("Fire1"));
        GUILayout.Label("Eje X: " + Input.GetAxis("Horizontal"));
        GUILayout.Label("Eje Y: " + Input.GetAxis("Vertical"));
    }
}
