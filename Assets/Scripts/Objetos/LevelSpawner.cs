using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSpawner : MonoBehaviour
{
    public GameObject[] grassFields;
    public GameObject[] cityOutside;
    public GameObject[] cityBlocks;
    public GameObject metaBlock;
    private int zPosition = 150;
    public bool createSection = false;
    public int sectionNumber;
    public int levelCounter = 1;

    void Start()
    {

    }

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
        if (levelCounter <= 8)
        {
            sectionNumber = Random.Range(0,5);
            Instantiate(grassFields[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 50;
            levelCounter += 1;
            yield return new WaitForSeconds(4);
            createSection = false;
        }

        if (levelCounter > 8 && levelCounter <= 15)
        {
            sectionNumber = Random.Range(0,3);
            Instantiate(cityOutside[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 50;
            levelCounter += 1;
            yield return new WaitForSeconds(4);
            createSection = false;
        }

        if (levelCounter > 15 && levelCounter <= 20)
        {
            sectionNumber = Random.Range(0,4);
            Instantiate(cityBlocks[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 50;
            levelCounter += 1;
            yield return new WaitForSeconds(4);
            createSection = false;
        }

        if (levelCounter > 20)
        {
            Instantiate(metaBlock, new Vector3(0, 0, zPosition), Quaternion.identity);
            zPosition += 50;
            levelCounter += 1;
            yield return new WaitForSeconds(20);
            createSection = false;
        }
        
    }
}
