using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinoject : MonoBehaviour
{
    public float speed = 0.79f;
    public float height = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 20f * Time.deltaTime, 0 );


        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(8, 9+(newY * height), -4) ;
    }
}

