using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_06_screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Resolución inicial " + Screen.currentResolution);
        Debug.Log("Puntos por pulgada " + Screen.dpi);
        foreach (var r in Screen.resolutions) {
            Debug.Log(r);
        }
    }

    int currentRes = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Screen.fullScreen = !Screen.fullScreen;
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            currentRes = (currentRes + 1) % Screen.resolutions.Length;
            Screen.SetResolution(Screen.resolutions[currentRes].width,
                Screen.resolutions[currentRes].height,
                Screen.fullScreen);
        }
    }

    private void OnGUI()
    {
        GUILayout.Label(string.Format("{0}x{1}",Screen.width,Screen.height));
        GUILayout.Label("FullScreen: " + Screen.fullScreen);
    }
}
