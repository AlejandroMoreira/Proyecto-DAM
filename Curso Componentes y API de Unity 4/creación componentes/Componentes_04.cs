﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes_04 : MonoBehaviour
{

    public GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, enemigo.transform.position);
    }
}
