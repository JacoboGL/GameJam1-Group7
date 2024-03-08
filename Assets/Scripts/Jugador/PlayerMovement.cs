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
    public bool gameOver = false;
    public bool winner = false;
    private Rigidbody playerRb;
    public bool isGrounded = true;
    public float jumpForce;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

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

        // Salto del jugador
        if(Input.GetKeyDown("space") && isGrounded == true && gameOver == false)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;

            //playerAnim.SetTrigger("Jump_trig");

            //dirtParticle.Stop();
            //audioPlayer.PlayOneShot(jumpSound, 1.0f);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            //dirtParticle.Play();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Food")
        {
            gameOver = true;
        }

        if(other.tag != "Meta")
        {
            winner = true;

            // Mostar cinematica de fin
        }
        
    }
}
