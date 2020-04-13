using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = FindObjectOfType<Enemy>();
        if (enemy != null)
        {
            print("Enemigo: " + enemy.name);
        }

        Enemy[] enemies = FindObjectsOfType<Enemy>();
        print("Enemigos:");
        foreach (Enemy e in enemies) {
            print(e.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
