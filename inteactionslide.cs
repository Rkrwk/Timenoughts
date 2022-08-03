using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inteactionslide : MonoBehaviour
{
    public static bool is_tutorial_finished = false;
    public GameObject secondslide;
    public GameObject movementpannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (is_tutorial_finished == true)
        {
            secondslide.SetActive(true);
        }
    }
}
