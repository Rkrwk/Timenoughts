using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pickup : MonoBehaviour
{
    float throwForce = 600;
    Vector3 objectPos;
    public float distance;
    public bool canHold = true;
    public GameObject item;
    public GameObject temParent;
    public bool isHolding = false;
    public float itemholdingdistance =  1.5f;
    Vector3 velocity;
    public bool outlined = false;
    public GameObject tutoriUI;
    public static bool firsttimeUI = true;
    public GameObject secoUI;
    public static bool secondtimeUI = true;


    // Update is called once per frame
    private void Awake()
    {
        Physics.IgnoreLayerCollision(3, 7);
    }
    void Update()
    {
        distance = Vector3.Distance(item.transform.position, temParent.transform.position);

        if (distance >= itemholdingdistance)
        {
            isHolding = false;

            Destroy(GetComponent<Outline>());
            outlined = false;

        }


        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(temParent.transform);


            if (Input.GetMouseButtonDown(1))
            {
                item.GetComponent<Rigidbody>().AddForce(temParent.transform.forward * throwForce);
                isHolding = false;
                secoUI.SetActive(false);
                secondtimeUI = false;
            }

        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;



        }
        if (isHolding == false)
        {
            velocity.y += 40f * Time.deltaTime;

        }
        if (distance < itemholdingdistance && outlined == false)
        {
            var outline = item.AddComponent<Outline>();
            outline.OutlineMode = Outline.Mode.OutlineAll;
            outline.OutlineColor = Color.red;
            outline.OutlineWidth = 5f;
            outlined = true;
            if (firsttimeUI == true)
            {
                tutoriUI.SetActive(true);
                firsttimeUI = false;
            }
  

        }
    }
    void OnMouseDown()
    {
        if (distance <= itemholdingdistance )
        {


            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
            Debug.Log("mouse");
            tutoriUI.SetActive(false);
            item.layer = 7;



            if (secondtimeUI == true)
            {

                secoUI.SetActive(true);
            }
            StartCoroutine (Test());


       

      


        }

        Debug.Log("mouse");
    }



    void OnMouseUp()
    {
        isHolding = false;
        item.layer = 6;

    }
    IEnumerator Test()
    {
        yield return new WaitForFixedUpdate();
        item.transform.localPosition = Vector3.zero;
    }
}
