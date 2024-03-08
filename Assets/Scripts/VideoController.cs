using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Asegúrate de que el VideoPlayer esté asignado en el Inspector
        if (videoPlayer == null)
        {
            Debug.LogError("No se ha asignado el VideoPlayer en el Inspector.");
            return;
        }

        // Suscribe el método VideoFinished() al evento de finalización del video
        videoPlayer.loopPointReached += VideoFinished;
    }

    void VideoFinished(VideoPlayer vp)
    {
        // Carga la escena principal del juego cuando el video termine
        SceneManager.LoadScene("Nivel-01");
    }
}
