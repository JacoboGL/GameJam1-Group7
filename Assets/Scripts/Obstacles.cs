using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    public GameObject player;
    //public GameObject gameOverScreen;
    private bool playerAlive = true;

    void Start()
    {
        player = GameObject.Find("Player");
    }    

    void Update()
    {
        if (playerAlive == false && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Animator>().enabled = false;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        
        //gameOverScreen.SetActive(true);

        playerAlive = false;
    }
}
