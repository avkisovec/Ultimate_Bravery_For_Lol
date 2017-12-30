using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnToggleGraphics : MonoBehaviour {


    GameObject btnToggleImage;
    public bool state = false;

    // Use this for initialization
    void Start () {

        btnToggleImage = new GameObject();
        btnToggleImage.AddComponent<SpriteRenderer>();
        btnToggleImage.gameObject.transform.position = gameObject.transform.position;
        btnToggleImage.gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 100 / 80, gameObject.transform.localScale.y * 100 / 39, 0);
        btnToggleImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnToggleOff")[0];
        btnToggleImage.gameObject.transform.position = new Vector3(btnToggleImage.gameObject.transform.position.x, btnToggleImage.gameObject.transform.position.y, -1);


    }

    // Update is called once per frame
    void Update () {
        
    }

    public void updateGraphics()
    {
        switch (state)
        {
            case true:
                btnToggleImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnToggleOn")[0];
                break;
            case false:
                btnToggleImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnToggleOff")[0];
                break;
        }
    }
    
}
