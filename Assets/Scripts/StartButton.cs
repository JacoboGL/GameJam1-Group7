using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    // Referencia al botón
    public Button startButton;

    // Método que se ejecuta cuando se hace clic en el botón
    public void OnStartButtonClick()
    {
        // Desactiva el botón
        startButton.gameObject.SetActive(false);
    }
}
