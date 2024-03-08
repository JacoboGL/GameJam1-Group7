using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyDelay());
    }

    IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(50);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
