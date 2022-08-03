using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigdooropen : MonoBehaviour
{
    Animator animator;
    public AudioSource AudioSource;
    public string key;
    public bool keepdooropen;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == key)
        {
            animator.SetBool("dooropen", true);
            AudioSource.Play();

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.tag == key && keepdooropen == false)
        {
            animator.SetBool("dooropen", false);
            AudioSource.PlayDelayed(1f);
        }
    }
}
