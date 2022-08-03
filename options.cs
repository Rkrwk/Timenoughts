using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {

        
    }
    public void sensativityslide(float newsensativity)
    {
        StarterAssets.FirstPersonController.RotationSpeed = newsensativity;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
