using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialUI : MonoBehaviour
{
    public KeyCode theKey = KeyCode.None;
    public GameObject target;
    public static int number_of_keypressed;
    public GameObject secondslide;
    public GameObject titleslide;
    static bool notactivie = true;
    public GameObject background;

    
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( theKey))
        {
            target.SetActive(false);
            Debug.Log("keypressesd");
            number_of_keypressed += 1;
        }
        if (number_of_keypressed == 4 && notactivie)
        {

            secondslide.SetActive(true);
            notactivie = false;
        }
        if (number_of_keypressed == 5)
        {
            titleslide.SetActive(false);
            background.SetActive(false);
        }


    }
}
