using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingsound : MonoBehaviour
{
    CharacterController cc;
    public AudioSource audioSource;
    public GameObject escscrene;
    public GameObject blur;
    public GameObject player;
    public GameObject other;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            escscrene.SetActive(true);
            blur.SetActive(true);
            player.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            other.SetActive(false);

        }
    }
    public void onesecexit()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
  
}

