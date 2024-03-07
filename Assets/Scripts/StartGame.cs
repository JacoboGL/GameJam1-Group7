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
        canvas.SetActive(true);
    }

    public void OnStartButtonClick()
    {
        // Desactivar el canvas al hacer clic en el botón de inicio
        canvas.SetActive(false);

    }
}
