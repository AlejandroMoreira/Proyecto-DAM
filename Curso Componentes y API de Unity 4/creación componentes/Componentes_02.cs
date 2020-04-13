using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes_02 : MonoBehaviour
{

    private int contadorUpdate;
    private int contadorFixed;

    void Awake()
    {
        print("¿Quién osa despertarme a mí " + gameObject.name + "?");

        contadorFixed = 0;
        contadorUpdate = 0;
    }

    //Cada vez que se activa el objeto, inizializar recursos
    void OnEnable()
    {
        print("onEnable de " + gameObject.name);
    }

    // Start is called before the FIRST frame update
    // Sólo se ejecuta una vez, se ejecuta despues de todos los Awake y onEnable
    // Consumir recursos
    void Start()
    {
        print("Start de " + gameObject.name);
    }

    // Se ejecuta al desactivar el objeto
    // Eliminar eventos y delegados
    private void OnDisable()
    {
        print("Disable de " + gameObject.name);
    }

    // Limpiar recursos
    private void OnDestroy()
    {
        print("Destroy de " + gameObject.name);
    }

    // 50/s
    // Manejar física
    private void FixedUpdate()
    {
        //contadorFixed++;
        //print("Fixed " + contadorFixed);
    }

    // Update is called once per frame
    // El típico update vaya
    void Update()
    {
        //contadorUpdate++;
        //print("Update " + contadorUpdate);
    }

    private void LateUpdate()
    {

    }

    float newX, newY, newZ;
    private void OnGUI()
    {
        //GUI.color = Color.black;

        GUILayout.BeginHorizontal();
        GUILayout.Label("X:");
        newX = float.Parse(GUILayout.TextField(newX.ToString(), 4));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Y:");
        newY = float.Parse(GUILayout.TextField(newY.ToString(), 4));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Z:");
        newZ = float.Parse(GUILayout.TextField(newZ.ToString(), 4));
        GUILayout.EndHorizontal();

        if (GUILayout.Button("mover")) {
            transform.position = new Vector3(newX,newY,newZ);
        }
    }

    //Permite dibujar Gizmos (sólo se ve en unity evidentemente)
    private void OnDrawGizmos()
    {

    }

}
