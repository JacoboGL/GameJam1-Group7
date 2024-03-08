using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;


public class GameManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera thirdPerson;

    // Método que inicia la corrutina para cambiar a la cámara de tercera persona después de un retraso
    public void StartSwitchToThirdPersonCoroutine()
    {
        StartCoroutine(SwitchToThirdPersonAfterDelay());
    }

    IEnumerator SwitchToThirdPersonAfterDelay()
    {
        // Espera 3 segundos
        yield return new WaitForSeconds(3f);

        // Cambia a la cámara de tercera persona
        CameraSwitcher.SwitchCamera(thirdPerson);
    }
}