using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;


public class GameManager : MonoBehaviour
{
    private MonoBehaviour playerMovementScript;
    private MonoBehaviour generateLevel;
    public GameObject player;
    public GameObject gameOverScreen;
    public PlayerMovement playerCollision;
    [SerializeField] CinemachineVirtualCamera thirdPerson;

    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if(playerCollision.gameOver == true)
        {
            gameOverScreen.SetActive(true);
        }
    }

    // Método que inicia la corrutina para cambiar a la cámara de tercera persona después de un retraso
    public void StartSwitchToThirdPersonCoroutine()
    {
        StartCoroutine(SwitchToThirdPersonAfterDelay());
    }

    IEnumerator SwitchToThirdPersonAfterDelay()
    {
        // Espera 3 segundos
        yield return new WaitForSeconds(2f);

        // Cambia a la cámara de tercera persona
        CameraSwitcher.SwitchCamera(thirdPerson);

        // Activa el movimiento del jugador
        playerMovementScript = player.GetComponent("PlayerMovement") as MonoBehaviour;
        playerMovementScript.enabled = enabled;

        generateLevel = GetComponent("LevelSpawner") as MonoBehaviour;
        generateLevel.enabled = enabled;

        Animator playerAnim = player.GetComponent<Animator>();
        playerAnim.SetBool("galope", true);

    }
}