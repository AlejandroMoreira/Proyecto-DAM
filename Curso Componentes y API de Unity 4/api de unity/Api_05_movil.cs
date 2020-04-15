using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_05_movil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
            Touch currentTouch = Input.GetTouch(0);
            if (currentTouch.phase == TouchPhase.Began) {
                Debug.Log("Se acaba de tocar en " + currentTouch.position);
            } else if (currentTouch.phase == TouchPhase.Ended) {
                Debug.Log("Se acaba de levantar en " + currentTouch.position);
            }
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("Toques " + Input.touchCount);
        foreach (Touch t in Input.touches) {
            GUILayout.Label("Toque posición: " + t.position);
        }
    }
}
