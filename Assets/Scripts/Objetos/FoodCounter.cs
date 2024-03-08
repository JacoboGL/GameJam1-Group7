using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodCounter : MonoBehaviour
{
    public static int playerScore;
    public GameObject foodCounter;

    // Update is called once per frame
    void Update()
    {
        foodCounter.GetComponent<TextMeshProUGUI>().text = "" + playerScore;
    }
}
