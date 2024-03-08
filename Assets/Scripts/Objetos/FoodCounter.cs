using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodCounter : MonoBehaviour
{
    public static int playerScore;
    public GameObject foodCounter;

    void Start()
    {
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        foodCounter.GetComponent<TextMeshProUGUI>().text = "" + playerScore;
    }
}
