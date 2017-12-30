using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bntBlueGraphics : MonoBehaviour {
    
    GameObject btnRollImage;

    // Use this for initialization
    void Start () {
        btnRollImage = new GameObject();
        btnRollImage.AddComponent<SpriteRenderer>();
        btnRollImage.gameObject.transform.position = gameObject.transform.position;
        btnRollImage.gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 100 / 219, gameObject.transform.localScale.y * 100 / 53, 0);
        btnRollImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnBlue")[0];
        btnRollImage.gameObject.transform.position = new Vector3(btnRollImage.gameObject.transform.position.x, btnRollImage.gameObject.transform.position.y, -1);

    }
	
	// Update is called once per frame
	void Update () {
        btnRollImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnBlue")[0];
        Vector3 mouseCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        if (mouseCoordinates.x > transform.position.x - transform.lossyScale.x / 2 &&
            mouseCoordinates.x < transform.position.x + transform.lossyScale.x / 2 &&
            mouseCoordinates.y > transform.position.y - transform.lossyScale.y / 2 &&
            mouseCoordinates.y < transform.position.y + transform.lossyScale.y / 2 &&
            Input.GetMouseButton(0)
            )
        {
            btnRollImage.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("RollResult/btnBlueHover")[0];
        }
    }
    
}
