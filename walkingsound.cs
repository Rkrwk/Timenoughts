using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingsound : MonoBehaviour
{
    CharacterController cc;
    public AudioSource audioSource;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }
}

