using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalSpeed;
    public float horizontalMovementInput;

    public static float leftSide = -5.5f;
    public static float rightSide = 5.5f;

    // Update is called once per frame
    void Update()
    {
        horizontalMovementInput = Input.GetAxis("Horizontal");

        // Movimiento del jugador hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed, Space.World);

        // Movimiento del jugador hacia los lados
        if(horizontalMovementInput > 0 && transform.position.x < rightSide)
        {
            transform.Translate(horizontalMovementInput * Time.deltaTime * horizontalSpeed, 0, 0);
        }

        if(horizontalMovementInput < 0 && transform.position.x > leftSide)
        {
            transform.Translate(horizontalMovementInput * Time.deltaTime * horizontalSpeed, 0, 0);
        }
        
    }
}
