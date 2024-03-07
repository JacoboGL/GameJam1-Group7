using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionesAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

  void Update()
    {
        
       if(Input.GetKey(KeyCode.Space))
       {
        anim.SetBool("galope", true);
       }

        if(!Input.GetKey(KeyCode.Space))
      {
        anim.SetBool("galope", false);
      }  
    
    }
    
}
