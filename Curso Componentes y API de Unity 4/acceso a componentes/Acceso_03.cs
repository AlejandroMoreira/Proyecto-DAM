using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = GetComponent<Enemy>();
        if (enemy != null)
        {
            print("Componente " + enemy + " encontrado");
        }
        else {
            print("No se ha encontrado el componente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
