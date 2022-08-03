using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public CharacterController control;
    public float movespeed = 12f;
    public float gravity = -9.81f;
    public Transform groundpound;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumphight = 5f;


    Vector3 velocity;
    public bool isGrounded;
    public bool colliedup;
    public Transform headcheck;
    public float headdistacne = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundpound.position, groundDistance, groundMask);
        colliedup = Physics.CheckSphere(headcheck.position, headdistacne, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            control.slopeLimit = 45f;
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z ;
        control.Move(move * movespeed *Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            control.slopeLimit = 100f;
            velocity.y = Mathf.Sqrt(jumphight * -2f * gravity);
        }


        velocity.y += gravity * Time.deltaTime;

        control.Move(velocity * Time.deltaTime);

        if (colliedup && velocity.y > 0)
        {
            velocity.y = 0;
        }
    }
}
