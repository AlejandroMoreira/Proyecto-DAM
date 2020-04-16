using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutina_02 : MonoBehaviour
{
    bool doCount = false;
    float count = 0f;
    float nextCount = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !doCount)
        {
            doCount = true;
            count = 0f;
        }

        if (doCount && Time.time > nextCount)
        {
            count += .1f;
            Debug.Log("Counter: " + count);
            nextCount = Time.time + 1f;
            if (count > 1f)
            {
                doCount = false;
            }
        }
    }
}
