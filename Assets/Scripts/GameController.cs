using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] section;
    public int zPosition = 90;
    public bool createSection = false;
    public int sectionNumber;

    // Update is called once per frame
    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0,5);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 45;
        yield return new WaitForSeconds(4);
        createSection = false;
    }
}
