using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngularvelocityScript : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Rotate(0, 45*Time.deltaTime, 0);
       rb.angularVelocity=new Vector3(0,45,0);
    }
}
