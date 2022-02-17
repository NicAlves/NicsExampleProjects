using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController CC;
    Vector3 V3;
    float ZMove;
    float XMove;
    float YMove;
    float ZmoveSprint;
    public Transform RotationOrigin;

    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Gravity();
        CameraMovement();
        Movement();
        SprintingMachanic();
        Jumping();
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

            Debug.Log("Fucking closed");
        }
    }

    void Movement()
    {
        //This is to set up the controlls for forward and back movent
        if (Input.GetKey("w"))
        {
            ZMove = 0.1f;
        }
        else
        {
            ZMove = 0f;
        }

        if (Input.GetKey("s"))
        {
            ZMove = -0.1f;
        }
        else if (!Input.GetKey("w"))
        {
            ZMove = 0f;
        }

       
        //this is to set the controlls up for side to side movement
        if (Input.GetKey("d"))
        {
            XMove = 0.1f; // sets the value while the key is being pressed
        }
        else // sets the value back to default when it isnt being pressed
        {
            XMove = 0f;
        }

        if (Input.GetKey("a"))
        {
            XMove = -0.1f;
        }
        else if (!Input.GetKey("d"))
        {
            XMove = 0f;
        }

       
    } //sets the controls for WASD movement

    void SprintingMachanic() //Sets up the sprint Key
    {
        if (Input.GetKey("left shift"))
        {
            ZMove = 0.5f;
        }
    }

    void Gravity()
    {
        

        if (CC.isGrounded == false)
        {
            YMove = YMove - 0.5f * Time.deltaTime;
        }
        else
        {
            YMove = 0;
        }

        
    } //Sets up the gravity for falling and future jumping

    void Jumping()
    {
        if (Input.GetKey(KeyCode.Space) && CC.isGrounded == true)
        {
            YMove = YMove + 0.5f;

            //Debug.Log("Jump is being called");
         
        }
    } //Sets up the jumping

    void CameraMovement() //this is to set the controlls up for the mouse movement
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0)); //transform as everything rotates on this axis

        RotationOrigin.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0)); // rotation bc the camera needs to move on this axis

        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        CC.Move(transform.rotation * new Vector3(XMove, YMove, ZMove));

    }
}
