using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {

        
    }
    public void sensativityslide(float newsensativity)
    {
        StarterAssets.FirstPersonController.RotationSpeed = Mathf.Round(newsensativity/10);
        text.text = newsensativity.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
