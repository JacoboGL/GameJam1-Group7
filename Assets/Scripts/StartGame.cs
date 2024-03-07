using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject canvas; // Referencia al objeto del canvas
    public Transform view1; // Referencia al transform de la vista 1

    void Start()
    {
        // Desactivar el canvas al inicio del juego
        canvas.SetActive(false);
    }

    public void OnStartButtonClick()
    {
        // Desactivar el canvas al hacer clic en el botón de inicio
        canvas.SetActive(false);

        // Mover la cámara a view1
        Camera.main.transform.position = view1.position;
        Camera.main.transform.rotation = view1.rotation;
    }
}
