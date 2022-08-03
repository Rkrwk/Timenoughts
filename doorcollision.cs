using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcollision : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;

    void Start()
    {
        //Fetch the Rigidbody component from the GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Ignore the collisions between layer 0 (default) and layer 8 (custom layer you set in Inspector window)
        Physics.IgnoreLayerCollision(8, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
