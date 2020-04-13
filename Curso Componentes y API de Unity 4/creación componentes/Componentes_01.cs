using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Info
{
    public int num;
    public bool falso;
}

public class Componentes_01 : MonoBehaviour
{
    [HideInInspector]
    public int numero;
    public string nombre = "Rubén";
    public bool tonto = true;
    [SerializeField]
    private int numero2;
    public Info info;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject
        print("Mi nombre es: " + this.gameObject.name);
        print("Mi tag es: " + this.gameObject.tag);
        print("Mi referencia es: " + this.gameObject);
        print("Estoy en la layer: " + this.gameObject.layer);

        //transform
        print("Tengo " + this.transform.childCount + " hijo/s");
        print("Posición local: " + this.transform.localPosition);
        print("Posición: " + this.transform.position);
        print("Rotación local: " + this.transform.localRotation);
        print("Rotación: " + this.transform.rotation);
        print("Arriba: " + this.transform.up);
        print("Derecha: " + this.transform.right);
        print("Adelante: " + this.transform.forward);

        /** transform métodos
         * transform.Translate(new Vector3(0,0,0)); -> Mover objeto a posición
         * transform.Rotate(new Vector3(0,0,0)); -> Rotar el objeto
         * transform.GetChild(0); -> Obtener hijo
         * transform.LookAt(transform.GetChild(0)); -> Mirar a objeto
         * transform.SetParent(null); -> seleccionar padre
        */

        //Usos de transform en juego
        transform.position = new Vector3(0f, 2f, 0f);
        transform.localScale = Vector3.one * 2f; // 2,2,2
        transform.localRotation = Quaternion.Euler(0f, 45f, 0f); // Eurler convierte un vector a quaternion

        /** Quaterniones más comunes
        * Quaternion.LookRotation(); --> Rotación que apunta a una dirección concreta
        * Quaternion.Angle(); --> Angulo del Quaternion
        * Quaternion.Euler(); 
        * Quaternion.Slerp(); --> Interpolación esferica
        * Quaternion.FromToRotation(); --> Quaternion que rota desde una rotación from a otra to
        * Quaternion.identity(); --> Quaternion para que la rotacion permanezca
        */
    }

    // Update is called once per frame
    void Update()
    {
    }
}
