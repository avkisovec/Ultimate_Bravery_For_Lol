using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollAll : MonoBehaviour {

    List<string> summsNamesList = new List<string>();
    int summ1;
    int summ2;

    List<champ> champsList = new List<champ>();

    // Use this for initialization
    void Start()
    {

        summsNamesList.Add("Barrier");
        summsNamesList.Add("Cleanse");
        summsNamesList.Add("Exhaust");
        summsNamesList.Add("Flash");
        summsNamesList.Add("Ghost");
        summsNamesList.Add("Heal");
        summsNamesList.Add("Ignite");
        summsNamesList.Add("Smite");
        summsNamesList.Add("Teleport");

        champsList.Add(new champ(""));
        champsList.Add(new champ("Aatrox"));
        champsList.Add(new champ("Ahri", true));
        champsList.Add(new champ("Akali"));
        champsList.Add(new champ("Alistar"));
        champsList.Add(new champ("Amumu"));
        champsList.Add(new champ("Anivia", true));
        champsList.Add(new champ("Annie", true));
        champsList.Add(new champ("Ashe", true));
        champsList.Add(new champ("AurelionSol", true));
        champsList.Add(new champ("Azir", true));
        champsList.Add(new champ("Bard", true));
        champsList.Add(new champ("Blitzcrank"));
        champsList.Add(new champ("Brand", true));
        champsList.Add(new champ("Braum"));
        champsList.Add(new champ("Caitlyn", true));
        champsList.Add(new champ("Camille"));
        champsList.Add(new champ("Cassiopeia", true));
        champsList.Add(new champ("ChoGath"));
        champsList.Add(new champ("Corki", true));
        champsList.Add(new champ("Darius"));
        champsList.Add(new champ("Diana"));

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) || detectClickBtnRoll())
        {
            roll();
        }

    }

    void roll()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("icon"))
        {
            Destroy(item.gameObject);
        }

        summ1 = Random.Range(0, summsNamesList.Count);
        do
        {
            summ2 = Random.Range(0, summsNamesList.Count);
        } while (summ1 == summ2);

        GameObject summIcon1 = new GameObject();
        GameObject summIcon2 = new GameObject();
        summIcon1.AddComponent<SpriteRenderer>();
        summIcon2.AddComponent<SpriteRenderer>();

        summIcon1.gameObject.tag = "icon";
        summIcon2.gameObject.tag = "icon";

        summIcon1.gameObject.transform.position = GameObject.Find("summ1bg").gameObject.transform.position;
        summIcon2.gameObject.transform.position = GameObject.Find("summ2bg").gameObject.transform.position;

        summIcon1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("summSpells/" + summsNamesList[summ1])[0];
        summIcon2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("summSpells/" + summsNamesList[summ2])[0];
    }

    bool detectClickBtnRoll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform btnRollTransform = GameObject.Find("btnRoll").GetComponent<Transform>();

            Vector3 clickCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            if (clickCoordinates.x > btnRollTransform.position.x - btnRollTransform.lossyScale.x &&
                clickCoordinates.x < btnRollTransform.position.x + btnRollTransform.lossyScale.x &&
                clickCoordinates.y > btnRollTransform.position.y - btnRollTransform.lossyScale.y &&
                clickCoordinates.y < btnRollTransform.position.y + btnRollTransform.lossyScale.y
                )
            {
                return true;
            }
        }
        else
        {
            return false;
        }
        return false;
    }

}

public class champ
{
    public string name;
    public bool ranged;
    public bool isVictor;

    public champ(string name, bool ranged = false, bool isVictor = false)
    {
        this.name = name;
        this.ranged = ranged;
        this.isVictor = isVictor;
    }
}
