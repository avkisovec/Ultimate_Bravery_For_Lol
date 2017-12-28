using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollAll : MonoBehaviour {

    List<string> summsNamesList = new List<string>();
    int summ1;
    int summ2;

    List<champ> champsList = new List<champ>();

    List<string> bootsList = new List<string>();

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
        champsList.Add(new champ("Draven"));
        champsList.Add(new champ("DrMundo", true));
        champsList.Add(new champ("Ekko"));
        champsList.Add(new champ("Elise", true)); //dssd
        champsList.Add(new champ("Evelynn"));
        champsList.Add(new champ("Ezreal", true));
        champsList.Add(new champ("Fiddlesticks", true));
        champsList.Add(new champ("Fiora"));
        champsList.Add(new champ("Fizz"));
        champsList.Add(new champ("Galio"));
        champsList.Add(new champ("Gangplank"));
        champsList.Add(new champ("Garen"));
        champsList.Add(new champ("Gnar", true));//dsds
        champsList.Add(new champ("Gragas"));
        champsList.Add(new champ("Graves", true));
        champsList.Add(new champ("Hecarim"));
        champsList.Add(new champ("Heimerdinger", true));
        champsList.Add(new champ("Illaoi"));
        champsList.Add(new champ("Irelia"));
        champsList.Add(new champ("Ivern"));//ihukh
        champsList.Add(new champ("Janna", true));
        champsList.Add(new champ("JarvanIV"));
        champsList.Add(new champ("Jax"));
        champsList.Add(new champ("Jayce"));//dsdsd
        champsList.Add(new champ("Jhin", true));
        champsList.Add(new champ("Jinx", true));
        champsList.Add(new champ("Kalista", true));
        champsList.Add(new champ("Karma", true));
        champsList.Add(new champ("Karthus", true));
        champsList.Add(new champ("Kassadin"));
        champsList.Add(new champ("Katarina"));
        champsList.Add(new champ("Kayle", true));//sdsdsd
        champsList.Add(new champ("Kayn"));
        champsList.Add(new champ("Kennen", true));
        champsList.Add(new champ("Khazix"));
        champsList.Add(new champ("Kindred", true));
        champsList.Add(new champ("Kled"));
        champsList.Add(new champ("KogMaw", true));
        champsList.Add(new champ("LeBlanc", true));
        champsList.Add(new champ("LeeSin"));
        champsList.Add(new champ("Leona"));
        champsList.Add(new champ("Lissandra", true));
        champsList.Add(new champ("Lucian", true));
        champsList.Add(new champ("Lulu", true));
        champsList.Add(new champ("Lux", true));
        champsList.Add(new champ("Malphite"));
        champsList.Add(new champ("Malzahar", true));
        champsList.Add(new champ("Maokai"));
        champsList.Add(new champ("MasterYi"));
        champsList.Add(new champ("MissFortune", true));
        champsList.Add(new champ("Mordekaiser"));
        champsList.Add(new champ("Morgana", true));
        champsList.Add(new champ("Nami", true));
        champsList.Add(new champ("Nasus"));
        champsList.Add(new champ("Nautilus"));
        champsList.Add(new champ("Nidalee", true));//dsaduswhd
        champsList.Add(new champ("Nocturne"));
        champsList.Add(new champ("Nunu"));
        champsList.Add(new champ("Olaf"));
        champsList.Add(new champ("Orianna", true));
        champsList.Add(new champ("Ornn"));
        champsList.Add(new champ("Pantheon"));
        champsList.Add(new champ("Poppy", true));
        champsList.Add(new champ("Quinn", true));
        champsList.Add(new champ("Rakan", true));
        champsList.Add(new champ("Rammus"));
        champsList.Add(new champ("RekSai"));
        champsList.Add(new champ("Renekton"));
        champsList.Add(new champ("Rengar"));
        champsList.Add(new champ("Riven"));
        champsList.Add(new champ("Rumble"));
        champsList.Add(new champ("Ryze", true));
        champsList.Add(new champ("Sejuani"));
        champsList.Add(new champ("Shaco"));
        champsList.Add(new champ("Shen"));
        champsList.Add(new champ("Shyvana"));
        champsList.Add(new champ("Singed"));
        champsList.Add(new champ("Sion"));
        champsList.Add(new champ("Sivir", true));
        champsList.Add(new champ("Skarner"));
        champsList.Add(new champ("Sona", true));
        champsList.Add(new champ("Soraka", true));
        champsList.Add(new champ("Swain", true));
        champsList.Add(new champ("Syndra", true));
        champsList.Add(new champ("TahmKench"));
        champsList.Add(new champ("Taliyah", true));
        champsList.Add(new champ("Talon"));
        champsList.Add(new champ("Taric"));
        champsList.Add(new champ("Teemo", true));
        champsList.Add(new champ("Thresh"));//jsdhgjdsd
        champsList.Add(new champ("Tristana", true));
        champsList.Add(new champ("Trundle"));
        champsList.Add(new champ("Tryndamere"));
        champsList.Add(new champ("TwistedFate", true));
        champsList.Add(new champ("Twitch", true));
        champsList.Add(new champ("Udyr"));
        champsList.Add(new champ("Urgot", true));
        champsList.Add(new champ("Varus", true));
        champsList.Add(new champ("Vayne", true));
        champsList.Add(new champ("Veigar", true));
        champsList.Add(new champ("VelKoz", true));
        champsList.Add(new champ("Vi"));
        champsList.Add(new champ("Viktor", true, true)); //   <-- Viktor
        champsList.Add(new champ("Vladimir", true));
        champsList.Add(new champ("Volibear"));
        champsList.Add(new champ("Warwick"));
        champsList.Add(new champ("Wukong"));
        champsList.Add(new champ("Xayah", true));
        champsList.Add(new champ("Xerath", true));
        champsList.Add(new champ("XinZhao"));
        champsList.Add(new champ("Yasuo"));
        champsList.Add(new champ("Yorick"));
        champsList.Add(new champ("Zac"));
        champsList.Add(new champ("Zed"));
        champsList.Add(new champ("Ziggs", true));
        champsList.Add(new champ("Zilean", true));
        champsList.Add(new champ("Zoe", true));
        champsList.Add(new champ("Zyra", true));

        bootsList.Add("BerserkersGreaves");
        bootsList.Add("BootsOfMobility");
        bootsList.Add("BootsOfSwiftness");
        bootsList.Add("IonianBootsOfLucidity");
        bootsList.Add("MercurysThreads");
        bootsList.Add("NinjaTabi");
        bootsList.Add("SorcerersShoes");

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



        GameObject champIcon = new GameObject();
        champIcon.AddComponent<SpriteRenderer>();

        champIcon.gameObject.tag = "icon";

        champIcon.gameObject.transform.position = GameObject.Find("champBg").gameObject.transform.position;
        
        champIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Champions/" + champsList[Random.Range(0, champsList.Count)].name)[0];



        GameObject itemBootsIcon = new GameObject();
        itemBootsIcon.AddComponent<SpriteRenderer>();

        itemBootsIcon.gameObject.tag = "icon";

        itemBootsIcon.gameObject.transform.position = GameObject.Find("itemBootsBg").gameObject.transform.position;

        itemBootsIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/Boots/" + bootsList[Random.Range(0, bootsList.Count)])[0];


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

public class item
{
    public string name;
    public string restriction;
    public item(string name, string restriction = "")
    {
        this.name = name;
        this.restriction = restriction;
    }
}