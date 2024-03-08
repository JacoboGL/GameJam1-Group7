using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using System;


public class StartGame : MonoBehaviour
{
    public GameObject canvas; // Referencia al objeto del canvas
    public GameObject foodCounter;
    public bool gameStared = false;
    [SerializeField] CinemachineVirtualCamera truckView;
    [SerializeField] CinemachineVirtualCamera thirdPerson;
    public GameManager gameManager;
    public GameObject truck;
    private MonoBehaviour truckMovementScript;

    void Start()
    {
        // Busca el botón en la escena
        Button startButton = GetComponent<Button>();

        foodCounter.SetActive(false);

        // Asocia la función OnStartButtonClick() al evento onClick del botón
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    public void OnStartButtonClick()
    {
        // Desactivar el canvas al hacer clic en el botón de inicio
        canvas.SetActive(false);

        // Desactivar el botón al hacer clic en el botón de inicio
        gameObject.SetActive(false);

        foodCounter.SetActive(true);

        // Iniciar la corrutina para cambiar a la cámara de tercera persona
        gameManager.StartSwitchToThirdPersonCoroutine();
        
        // Cambiar la cámara a truckView
        CameraSwitcher.SwitchCamera(truckView);

        truckMovementScript = truck.GetComponent("MoveForward") as MonoBehaviour;
        truckMovementScript.enabled = enabled;
    }


    void ChangeCamera()
    {
        // Cambia a la cámara de camión
        CameraSwitcher.SwitchCamera(truckView);

    }



}
