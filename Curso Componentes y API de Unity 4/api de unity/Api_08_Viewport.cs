using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_08_Viewport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ejemplo 4: Limites de pantalla
        Debug.Log("Limites: " + Camera.main.ViewportToWorldPoint(Vector3.one));
    }

    // Update is called once per frame
    void Update()
    {
        //Ejemplo 1 dividir pantalla
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 viewportPosition = Camera.main.ScreenToViewportPoint(
                Input.mousePosition); //Convertimos la posicion del raton a viewport
            string horizontal = "";
            string vertical = "";

            if (viewportPosition.x > 0.5f)
            {
                horizontal = "Derecha";
            }
            else
            {
                horizontal = "Izquierda";
            }

            vertical = viewportPosition.y > 0.5f ? "Arriba" : "Abajo";

            Debug.LogFormat("Pinchaste en {0} - {1}",horizontal,vertical);
        }

        //Ejemplo 2 mover objeto
        if (Input.GetMouseButton(1)) {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f;
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
    }

    private void OnGUI()
    {
        //Ejemplo 3: Localizar objeto
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        string horizontal = "";
        string vertical = "";

        if (viewportPosition.x > 0.5f)
        {
            horizontal = "Derecha";
        }
        else
        {
            horizontal = "Izquierda";
        }

        vertical = viewportPosition.y > 0.5f ? "Arriba" : "Abajo";

        GUILayout.Label(string.Format("Estoy en {0} - {1}", horizontal, vertical));
    }
}
