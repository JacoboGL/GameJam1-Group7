using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraRotate : MonoBehaviour
{
    public float speed;

    public static bool rotationEnabled = true;

    void Update()
    {

        if (rotationEnabled)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
    }
}
