using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController34 : MonoBehaviour
{

    public float speed = 4;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Input.GetAxis("Horizontal") * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

        enemyRigidbody.AddForce(awayFromPlayer * 1f, ForceMode.Force);
    }
}
