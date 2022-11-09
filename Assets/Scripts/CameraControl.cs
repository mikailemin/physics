using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{


    public Transform aim;
    public Vector3 offset;
    private float mouseX;
    private float mouseY;
    [SerializeField]
    private float sensivity;
  
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position,aim.position+offset,Time.deltaTime*10);
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        if (mouseY>=25)
        {
            mouseY = 25;
        }
        if (mouseY<=-40)
        {
            mouseY = -40;
        }

        this.transform.eulerAngles=new Vector3 (mouseY,mouseX,0);
        aim.transform.eulerAngles=new Vector3(0,mouseX,0);
        
    }
}
