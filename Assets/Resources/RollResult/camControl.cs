using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour {

    Transform camTransform;
    Transform btnSwapTransform;
    Rigidbody2D camRigidBody;

    Vector3 positionChampScreen = new Vector3(-3,-1,-10);
    Vector3 positionRunesScreen = new Vector3(7, -1, -10);

    float camConstraintFixedY = -1;
    float camConstraintMinX = -3.1f;
    float camConstraintMaxX = 7.1f;

    Vector3 lastMousePosition;

    // Use this for initialization
    void Start () {
        camTransform = GetComponent<Transform>();
        camRigidBody = GetComponent<Rigidbody2D>();
        btnSwapTransform = GameObject.Find("btnSwap").GetComponent<Transform>();
        
        lastMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

    }

    // Update is called once per frame
    void Update() {

        /*      align btnSwap to right edge of screen
         * 
        btnSwapTransform.position = Camera.main.ScreenToWorldPoint(new Vector3( Camera.main.pixelWidth, Camera.main.pixelHeight/2, 0));
        btnSwapTransform.position = new Vector3(btnSwapTransform.position.x, btnSwapTransform.position.y, -5);
        */


        if (Input.GetMouseButtonDown(0))
        {
            camRigidBody.velocity -= camRigidBody.velocity;

            Transform btnSwapTransform = GameObject.Find("btnSwap").GetComponent<Transform>();

            Vector3 clickCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            if (clickCoordinates.x > btnSwapTransform.position.x - btnSwapTransform.lossyScale.x &&
                clickCoordinates.x < btnSwapTransform.position.x + btnSwapTransform.lossyScale.x &&
                clickCoordinates.y > btnSwapTransform.position.y - btnSwapTransform.lossyScale.y &&
                clickCoordinates.y < btnSwapTransform.position.y + btnSwapTransform.lossyScale.y
                )
            {
                // btn swap was clicked
                if ((camTransform.position - positionChampScreen).magnitude > (camTransform.position - positionRunesScreen).magnitude)
                {
                    camTransform.position = positionChampScreen;
                }
                else
                {
                    camTransform.position = positionRunesScreen;
                }
            }

        }
        else if (Input.GetMouseButton(0))
        {
            camTransform.position += lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        }

        if (Input.GetMouseButtonUp(0))
        {
            camRigidBody.velocity += new Vector2((lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0))).x, (lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0))).y)*5;
        }

        
        if (camRigidBody.velocity.magnitude < 0.05f)
        {
            camRigidBody.velocity -= camRigidBody.velocity;
        }
        else if (camRigidBody.velocity.magnitude < 0.5f)
        {
            camRigidBody.velocity -= camRigidBody.velocity / 5;
        }
        else if (camRigidBody.velocity.magnitude < 1f)
        {
            camRigidBody.velocity -= camRigidBody.velocity / 30;
        }
        else
        {
            camRigidBody.velocity -= camRigidBody.velocity / 100;
        }
        




        camTransform.position = new Vector3(camTransform.position.x, camConstraintFixedY, camTransform.position.z);

        if(camTransform.position.x < camConstraintMinX)
        {
            camTransform.position = new Vector3(camConstraintMinX, camTransform.position.y, camTransform.position.z);
        }
        else if(camTransform.position.x > camConstraintMaxX)
        {
            camTransform.position = new Vector3(camConstraintMaxX, camTransform.position.y, camTransform.position.z);
        }


        lastMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));


        

    }
}
