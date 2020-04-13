using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceso_01 : MonoBehaviour
{

    public Transform other;
    public float vel;
    public int newZ;

    // Start is called before the first frame update
    void Start()
    {
        print("Transform de " + other.name);
    }

    // Update is called once per frame
    void Update()
    {
        other.position = Vector3.Lerp(other.position,new Vector3(0,0,newZ),vel);
    }
}
