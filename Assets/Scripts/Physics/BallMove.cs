using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(Random.Range(1,3), 0, -speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
