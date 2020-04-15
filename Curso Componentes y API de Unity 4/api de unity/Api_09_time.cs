using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_09_time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("0.2x")) {
            Time.timeScale = 0.2f;
        }

        if (GUILayout.Button("1x"))
        {
            Time.timeScale = 1f;
        }

        if (GUILayout.Button("2x"))
        {
            Time.timeScale = 2f;
        }

        GUILayout.EndHorizontal();

        GUILayout.Label("Tiempo: " + Time.time);
        GUILayout.Label("Tiempo sin escala: " + Time.unscaledTime);
        GUILayout.Label("Tiempo desde arranque: " + Time.realtimeSinceStartup);
        GUILayout.Label("Tiempo desde carga del nivel: " + Time.timeSinceLevelLoad);
        GUILayout.Label("Tiempo desde el último render/update: " + Time.deltaTime);
        GUILayout.Label("Tiempo desde el último render/fixupdate: " + Time.fixedDeltaTime);
        GUILayout.Label("Escala de tiempo: " + Time.timeScale);
    }
}
