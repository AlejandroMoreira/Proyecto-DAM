using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Api_10_transform : MonoBehaviour
{

    public float speed;
    public float rotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(x, 0f, z,Space.World);
        transform.Rotate(0f, rotate * Time.deltaTime, 0f);
    }
}
