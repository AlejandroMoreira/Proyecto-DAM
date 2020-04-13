using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes_03 : MonoBehaviour
{
    public float rango = 5f;

    private void OnDrawGizmos()
    {
        
    }

    //Igual que gizmos pero cuando seleccionas el objeto
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,rango);
    }
}
