using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (speed<100)
        {
            speed+=1*Time.deltaTime;
        }
        
    }
    IEnumerator hızlanma()
    {
       
            yield return new WaitForSeconds(3);
            
        
       
    }

}
