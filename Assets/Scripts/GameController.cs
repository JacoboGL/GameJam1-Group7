using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] grassFields;
    public GameObject[] cityOutside;
    public GameObject[] cityBlocks;
    public int zPosition = 135;
    public bool createSection = false;
    public int sectionNumber;
    public int levelCounter = 1;

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
        if (levelCounter <= 15)
        {
            sectionNumber = Random.Range(0,5);
            Instantiate(grassFields[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 45;
            levelCounter += 1;
            yield return new WaitForSeconds(2);
            createSection = false;
        }

        if (levelCounter > 15 && levelCounter <= 30)
        {
            sectionNumber = Random.Range(0,5);
            Instantiate(cityOutside[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 45;
            levelCounter += 1;
            yield return new WaitForSeconds(2);
            createSection = false;
        }

        if (levelCounter > 30 && levelCounter <= 40)
        {
            sectionNumber = Random.Range(0,5);
            Instantiate(cityBlocks[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 45;
            levelCounter += 1;
            yield return new WaitForSeconds(2);
            createSection = false;
        }
        
    }
}
