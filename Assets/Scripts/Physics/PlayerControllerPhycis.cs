using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPhycis : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, Input.GetAxis("Vertical")*speed*Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer =  collision.gameObject.transform.position -transform.position ;

        enemyRigidbody.AddForce(awayFromPlayer * 5f, ForceMode.Impulse);
    }
}
