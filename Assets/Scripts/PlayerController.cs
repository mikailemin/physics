using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    private Rigidbody playerRb;
    [SerializeField]
    private float speed = 3;
    private bool isOnGround;
    public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }
    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal",horizontalInput);
        anim.SetFloat("Vertical", verticalInput);

        gameObject.transform.Translate(horizontalInput * speed*Time.deltaTime, 0, verticalInput * speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce * 10, ForceMode.Impulse);
            isOnGround = false;

        }
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
