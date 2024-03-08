using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu; // Asigna el menú de pausa desde el editor

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void PauseButtonClicked()
    {
        TogglePause();
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Pausar el juego estableciendo el tiempo a cero
            if (pauseMenu != null)
            {
                pauseMenu.SetActive(true); // Mostrar el menú de pausa si está asignado
            }
        }
        else
        {
            Time.timeScale = 1; // Reanudar el juego estableciendo el tiempo a 1
            if (pauseMenu != null)
            {
                pauseMenu.SetActive(false); // Ocultar el menú de pausa si está asignado
            }
        }
    }
}
