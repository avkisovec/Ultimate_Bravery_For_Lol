using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl2 : MonoBehaviour {

    Transform camTransform;
    Transform btnSwapTransform;
    Rigidbody2D camRigidBody;

    Vector3 positionChampScreen = new Vector3(-3, -1, -10);
    Vector3 positionRunesScreen = new Vector3(7, -1, -10);

    float camConstraintFixedX = 0;
    float camConstraintMinX = -7.1f;
    float camConstraintMaxX = 7.1f;
    float camConstraintMinY = 5.5f;
    float camConstraintMaxY = 54.5f;

    Vector3 lastMousePosition;
    
    Transform background;

    Vector3 mouseHoldBegin;

    // Use this for initialization
    void Start()
    {
        camTransform = GetComponent<Transform>();
        camRigidBody = GetComponent<Rigidbody2D>();
        btnSwapTransform = GameObject.Find("btnSwap").GetComponent<Transform>();

        lastMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        mouseHoldBegin = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        
        background = GameObject.Find("background").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        /*      align btnSwap to right edge of screen
         * 
        btnSwapTransform.position = Camera.main.ScreenToWorldPoint(new Vector3( Camera.main.pixelWidth, Camera.main.pixelHeight/2, 0));
        btnSwapTransform.position = new Vector3(btnSwapTransform.position.x, btnSwapTransform.position.y, -5);
        */

        
        if (Input.GetMouseButtonDown(0))
        {
            //camRigidBody.velocity -= camRigidBody.velocity;

            Vector3 clickCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            
            mouseHoldBegin = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        }
        else if (Input.GetMouseButton(0))
        {
            //camTransform.position += lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        }
        
        if (Input.GetMouseButtonUp(0))
        {
            //camRigidBody.velocity += new Vector2((lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0))).x, (lastMousePosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0))).y) * 10;

            /*
            if (checkBtnClick("btnSwap"))
            {
                camTransform.position = positionChampScreen;
            }
            */
            checkAnchorBtns();
        }



        updateBackground();
        slowDownCamera();
        checkConstraints();

        lastMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));


        //checkAnchorBtns();


    }

    void checkConstraints()
    {
        camTransform.position = new Vector3(camConstraintFixedX, camTransform.position.y, camTransform.position.z);
        
        if (camTransform.position.x < camConstraintMinX)
        {
            camTransform.position = new Vector3(camConstraintMinX, camTransform.position.y, camTransform.position.z);
        }
        else if (camTransform.position.x > camConstraintMaxX)
        {
            camTransform.position = new Vector3(camConstraintMaxX, camTransform.position.y, camTransform.position.z);
        }
        
        if (camTransform.position.y < camConstraintMinY)
        {
            camTransform.position = new Vector3(camTransform.position.x, camConstraintMinY, camTransform.position.z);
        }
        else if (camTransform.position.y > camConstraintMaxY)
        {
            camTransform.position = new Vector3(camTransform.position.x, camConstraintMaxY, camTransform.position.z);
        }
    }

    void checkAnchorBtns()
    {
        /*      CODE FOR ADDING NOW ANCHOR BUTTON AND ANCHOR
        if (checkBtnClick("anchorBtnName"))
        {
            camTransform.position = new Vector3(anchorX,anchorY,-10);
        }
        */
        


        if (checkBtnClick("btnMenuRoll"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 42, -10);
            GetComponent<rollAll>().roll();
        }
        if (checkBtnClick("btnAbout"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 6, -10);
        }
        if (checkBtnClick("btnRoll"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 42, -10);
            GetComponent<rollAll>().roll();
        }
        if (checkBtnClick("btnDontHave"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 18, -10);
        }
        if (checkBtnClick("btnRunes"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 30, -10);
        }
        if (checkBtnClick("btnBuild"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 42, -10);
        }
        if (checkBtnClick("btnBuild2"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 42, -10);
        }
        if (checkBtnClick("btnToMenu"))
        {
            camTransform.position = new Vector3(camConstraintFixedX, 54, -10);
        }
        if (checkBtnClick("btnJungle"))
        {
            switch (GameObject.Find("btnJungle").GetComponent<btnToggleGraphics>().state)
            {
                case true:
                    GameObject.Find("btnJungle").GetComponent<btnToggleGraphics>().state = false;
                    GameObject.Find("btnJungle").GetComponent<btnToggleGraphics>().updateGraphics();
                    break;
                case false:
                    GameObject.Find("btnJungle").GetComponent<btnToggleGraphics>().state = true;
                    GameObject.Find("btnJungle").GetComponent<btnToggleGraphics>().updateGraphics();
                    break;
            }
        }




    }

    bool checkBtnClick(string button)
    {
        
        GameObject btn = GameObject.Find(button);
        Vector3 clickCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        if (clickCoordinates.x > btn.transform.position.x - btn.transform.lossyScale.x / 2 &&
            clickCoordinates.x < btn.transform.position.x + btn.transform.lossyScale.x / 2 &&
            clickCoordinates.y > btn.transform.position.y - btn.transform.lossyScale.y / 2 &&
            clickCoordinates.y < btn.transform.position.y + btn.transform.lossyScale.y / 2 &&
            clickCoordinates.x > mouseHoldBegin.x - btn.transform.lossyScale.x / 2 &&
            clickCoordinates.x < mouseHoldBegin.x + btn.transform.lossyScale.x / 2 &&
            clickCoordinates.y > mouseHoldBegin.y - btn.transform.lossyScale.y / 2 &&
            clickCoordinates.y < mouseHoldBegin.y + btn.transform.lossyScale.y / 2 &&
            (clickCoordinates - mouseHoldBegin).magnitude < 0.1f
            )
        {
            return true;
        }

            return false;
    }

    void slowDownCamera()
    {
        
        if (camRigidBody.velocity.magnitude < 0.05f)
        {
            camRigidBody.velocity -= camRigidBody.velocity;
        }
        else if (camRigidBody.velocity.magnitude < 0.5f)
        {
            camRigidBody.velocity -= camRigidBody.velocity / 2;
        }
        else if (camRigidBody.velocity.magnitude < 1f)
        {
            camRigidBody.velocity -= camRigidBody.velocity / 30;
        }
        else
        {
            camRigidBody.velocity -= camRigidBody.velocity / 70;
        }
        
    }

    void updateBackground()
    {
        float camMinY = 6;
        float camMaxY = 54;
        float bgMinY = 12;
        float bgMaxY = 45;

        background.position = new Vector3(background.position.x,
            camTransform.position.y / ((camMaxY - camMinY) + camMinY) * (bgMaxY - bgMinY) + bgMinY
            ,6);
    }
}
