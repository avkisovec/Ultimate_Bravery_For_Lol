using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summSpawner : MonoBehaviour {
    
    List<string> summsNamesList = new List<string>();

	// Use this for initialization
	void Start () {
        summsNamesList.Add("Barrier");
        summsNamesList.Add("Cleanse");
        summsNamesList.Add("Exhaust");
        summsNamesList.Add("Flash");
        summsNamesList.Add("Ghost");
        summsNamesList.Add("Heal");
        summsNamesList.Add("Ignite");
        summsNamesList.Add("Smite");
        summsNamesList.Add("Teleport");
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject summIcon = new GameObject();
            summIcon.AddComponent<SpriteRenderer>();
            SpriteRenderer summIconSR = summIcon.GetComponent<SpriteRenderer>();
            summIconSR.sprite = Resources.LoadAll<Sprite>("summSpells/"+summsNamesList[Random.Range(0,summsNamesList.Count)])[0];
        }
	}
}
