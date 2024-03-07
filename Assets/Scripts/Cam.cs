using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CamaraRotate;

public class Cam : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;



    void Start()
    {
        currentView = transform;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            CamaraRotate.rotationEnabled = false;
            // Detener la rotación y posicionar la cámara en la rotación de la vista 0
            transform.rotation = views[0].rotation;
            currentView = views[0];
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            CamaraRotate.rotationEnabled = false;
            // Detener la rotación y posicionar la cámara en la rotación de la vista 0
            transform.rotation = views[0].rotation;
            currentView = views[1];
        }
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
    }
}
