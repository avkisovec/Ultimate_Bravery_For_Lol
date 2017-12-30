using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollAll : MonoBehaviour
{

    List<string> summsNamesList = new List<string>();

    int champ;

    int summ1;
    int summ2;

    int item1;
    int item2;
    int item3;
    int item4;
    int item5;

    List<Champ> champsList = new List<Champ>();

    List<string> bootsList = new List<string>();

    List<Item> itemsList = new List<Item>();

    List<Rune> runesList = new List<Rune>();


    Vector3 mouseHoldBegin;


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

        champsList.Add(new Champ("Aatrox"));
        champsList.Add(new Champ("Ahri", true));
        champsList.Add(new Champ("Akali"));
        champsList.Add(new Champ("Alistar"));
        champsList.Add(new Champ("Amumu"));
        champsList.Add(new Champ("Anivia", true));
        champsList.Add(new Champ("Annie", true));
        champsList.Add(new Champ("Ashe", true));
        champsList.Add(new Champ("AurelionSol", true));
        champsList.Add(new Champ("Azir", true));
        champsList.Add(new Champ("Bard", true));
        champsList.Add(new Champ("Blitzcrank"));
        champsList.Add(new Champ("Brand", true));
        champsList.Add(new Champ("Braum"));
        champsList.Add(new Champ("Caitlyn", true));
        champsList.Add(new Champ("Camille"));
        champsList.Add(new Champ("Cassiopeia", true));
        champsList.Add(new Champ("ChoGath"));
        champsList.Add(new Champ("Corki", true));
        champsList.Add(new Champ("Darius"));
        champsList.Add(new Champ("Diana"));
        champsList.Add(new Champ("Draven"));
        champsList.Add(new Champ("DrMundo", true));
        champsList.Add(new Champ("Ekko"));
        champsList.Add(new Champ("Elise", true)); //dssd
        champsList.Add(new Champ("Evelynn"));
        champsList.Add(new Champ("Ezreal", true));
        champsList.Add(new Champ("Fiddlesticks", true));
        champsList.Add(new Champ("Fiora"));
        champsList.Add(new Champ("Fizz"));
        champsList.Add(new Champ("Galio"));
        champsList.Add(new Champ("Gangplank"));
        champsList.Add(new Champ("Garen"));
        champsList.Add(new Champ("Gnar", true));//dsds
        champsList.Add(new Champ("Gragas"));
        champsList.Add(new Champ("Graves", true));
        champsList.Add(new Champ("Hecarim"));
        champsList.Add(new Champ("Heimerdinger", true));
        champsList.Add(new Champ("Illaoi"));
        champsList.Add(new Champ("Irelia"));
        champsList.Add(new Champ("Ivern"));//ihukh
        champsList.Add(new Champ("Janna", true));
        champsList.Add(new Champ("JarvanIV"));
        champsList.Add(new Champ("Jax"));
        champsList.Add(new Champ("Jayce"));//dsdsd
        champsList.Add(new Champ("Jhin", true));
        champsList.Add(new Champ("Jinx", true));
        champsList.Add(new Champ("Kalista", true));
        champsList.Add(new Champ("Karma", true));
        champsList.Add(new Champ("Karthus", true));
        champsList.Add(new Champ("Kassadin"));
        champsList.Add(new Champ("Katarina"));
        champsList.Add(new Champ("Kayle", true));//sdsdsd
        champsList.Add(new Champ("Kayn"));
        champsList.Add(new Champ("Kennen", true));
        champsList.Add(new Champ("Khazix"));
        champsList.Add(new Champ("Kindred", true));
        champsList.Add(new Champ("Kled"));
        champsList.Add(new Champ("KogMaw", true));
        champsList.Add(new Champ("LeBlanc", true));
        champsList.Add(new Champ("LeeSin"));
        champsList.Add(new Champ("Leona"));
        champsList.Add(new Champ("Lissandra", true));
        champsList.Add(new Champ("Lucian", true));
        champsList.Add(new Champ("Lulu", true));
        champsList.Add(new Champ("Lux", true));
        champsList.Add(new Champ("Malphite"));
        champsList.Add(new Champ("Malzahar", true));
        champsList.Add(new Champ("Maokai"));
        champsList.Add(new Champ("MasterYi"));
        champsList.Add(new Champ("MissFortune", true));
        champsList.Add(new Champ("Mordekaiser"));
        champsList.Add(new Champ("Morgana", true));
        champsList.Add(new Champ("Nami", true));
        champsList.Add(new Champ("Nasus"));
        champsList.Add(new Champ("Nautilus"));
        champsList.Add(new Champ("Nidalee", true));//dsaduswhd
        champsList.Add(new Champ("Nocturne"));
        champsList.Add(new Champ("Nunu"));
        champsList.Add(new Champ("Olaf"));
        champsList.Add(new Champ("Orianna", true));
        champsList.Add(new Champ("Ornn"));
        champsList.Add(new Champ("Pantheon"));
        champsList.Add(new Champ("Poppy", true));
        champsList.Add(new Champ("Quinn", true));
        champsList.Add(new Champ("Rakan", true));
        champsList.Add(new Champ("Rammus"));
        champsList.Add(new Champ("RekSai"));
        champsList.Add(new Champ("Renekton"));
        champsList.Add(new Champ("Rengar"));
        champsList.Add(new Champ("Riven"));
        champsList.Add(new Champ("Rumble"));
        champsList.Add(new Champ("Ryze", true));
        champsList.Add(new Champ("Sejuani"));
        champsList.Add(new Champ("Shaco"));
        champsList.Add(new Champ("Shen"));
        champsList.Add(new Champ("Shyvana"));
        champsList.Add(new Champ("Singed"));
        champsList.Add(new Champ("Sion"));
        champsList.Add(new Champ("Sivir", true));
        champsList.Add(new Champ("Skarner"));
        champsList.Add(new Champ("Sona", true));
        champsList.Add(new Champ("Soraka", true));
        champsList.Add(new Champ("Swain", true));
        champsList.Add(new Champ("Syndra", true));
        champsList.Add(new Champ("TahmKench"));
        champsList.Add(new Champ("Taliyah", true));
        champsList.Add(new Champ("Talon"));
        champsList.Add(new Champ("Taric"));
        champsList.Add(new Champ("Teemo", true));
        champsList.Add(new Champ("Thresh"));//jsdhgjdsd
        champsList.Add(new Champ("Tristana", true));
        champsList.Add(new Champ("Trundle"));
        champsList.Add(new Champ("Tryndamere"));
        champsList.Add(new Champ("TwistedFate", true));
        champsList.Add(new Champ("Twitch", true));
        champsList.Add(new Champ("Udyr"));
        champsList.Add(new Champ("Urgot", true));
        champsList.Add(new Champ("Varus", true));
        champsList.Add(new Champ("Vayne", true));
        champsList.Add(new Champ("Veigar", true));
        champsList.Add(new Champ("VelKoz", true));
        champsList.Add(new Champ("Vi"));
        champsList.Add(new Champ("Viktor", true, true)); //   <-- Viktor
        champsList.Add(new Champ("Vladimir", true));
        champsList.Add(new Champ("Volibear"));
        champsList.Add(new Champ("Warwick"));
        champsList.Add(new Champ("Wukong"));
        champsList.Add(new Champ("Xayah", true));
        champsList.Add(new Champ("Xerath", true));
        champsList.Add(new Champ("XinZhao"));
        champsList.Add(new Champ("Yasuo"));
        champsList.Add(new Champ("Yorick"));
        champsList.Add(new Champ("Zac"));
        champsList.Add(new Champ("Zed"));
        champsList.Add(new Champ("Ziggs", true));
        champsList.Add(new Champ("Zilean", true));
        champsList.Add(new Champ("Zoe", true));
        champsList.Add(new Champ("Zyra", true));

        bootsList.Add("BerserkersGreaves");
        bootsList.Add("BootsOfMobility");
        bootsList.Add("BootsOfSwiftness");
        bootsList.Add("IonianBootsOfLucidity");
        bootsList.Add("MercurysThreads");
        bootsList.Add("NinjaTabi");
        bootsList.Add("SorcerersShoes");

        itemsList.Add(new Item("Abyssal_Mask_item"));
        itemsList.Add(new Item("Adaptive_Helm_item"));
        itemsList.Add(new Item("Archangel's_Staff_item"));
        itemsList.Add(new Item("Ardent_Censer_item"));
        itemsList.Add(new Item("Athene's_Unholy_Grail_item"));
        itemsList.Add(new Item("Banner_of_Command_item"));
        itemsList.Add(new Item("Banshee's_Veil_item"));
        itemsList.Add(new Item("Blade_of_the_Ruined_King_item"));
        itemsList.Add(new Item("Dead_Man's_Plate_item"));
        itemsList.Add(new Item("Death's_Dance_item"));
        itemsList.Add(new Item("Duskblade_of_Draktharr_item"));
        itemsList.Add(new Item("Edge_of_Night_item"));
        itemsList.Add(new Item("Essence_Reaver_item"));
        itemsList.Add(new Item("Eye_of_the_Equinox_item", "gold"));
        itemsList.Add(new Item("Eye_of_the_Oasis_item", "gold"));
        itemsList.Add(new Item("Eye_of_the_Watchers_item", "gold"));
        itemsList.Add(new Item("Face_of_the_Mountain_item", "gold"));
        itemsList.Add(new Item("Frost_Queen's_Claim_item", "gold"));
        itemsList.Add(new Item("Frozen_Heart_item"));
        itemsList.Add(new Item("Frozen_Mallet_item"));
        itemsList.Add(new Item("Gargoyle_Stoneplate_item"));
        itemsList.Add(new Item("Guardian_Angel_item"));
        itemsList.Add(new Item("Guinsoo's_Rageblade_item"));
        itemsList.Add(new Item("Hextech_GLP-800_item"));
        itemsList.Add(new Item("Hextech_Gunblade_item"));
        itemsList.Add(new Item("Hextech_Protobelt-01_item"));
        itemsList.Add(new Item("Iceborn_Gauntlet_item"));
        itemsList.Add(new Item("Infinity_Edge_item"));
        itemsList.Add(new Item("Knight's_Vow_item"));
        itemsList.Add(new Item("Liandry's_Torment_item"));
        itemsList.Add(new Item("Lich_Bane_item"));
        itemsList.Add(new Item("Locket_of_the_Iron_Solari_item"));
        itemsList.Add(new Item("Lord_Dominik's_Regards_item"));
        itemsList.Add(new Item("Luden's_Echo_item"));
        itemsList.Add(new Item("Manamune_item"));
        itemsList.Add(new Item("Maw_of_Malmortius_item"));
        itemsList.Add(new Item("Mejai's_Soulstealer_item"));
        itemsList.Add(new Item("Mercurial_Scimitar_item"));
        itemsList.Add(new Item("Mikael's_Crucible_item"));
        itemsList.Add(new Item("Morellonomicon_item"));
        itemsList.Add(new Item("Mortal_Reminder_item"));
        itemsList.Add(new Item("Muramana_item"));
        itemsList.Add(new Item("Nashor's_Tooth_item"));
        itemsList.Add(new Item("Ohmwrecker_item"));
        itemsList.Add(new Item("Phantom_Dancer_item"));
        itemsList.Add(new Item("Rabadon's_Deathcap_item"));
        itemsList.Add(new Item("Randuin's_Omen_item"));
        itemsList.Add(new Item("Rapid_Firecannon_item"));
        itemsList.Add(new Item("Ravenous_Hydra_item", "melee"));
        itemsList.Add(new Item("Redemption_item"));
        itemsList.Add(new Item("Righteous_Glory_item"));
        itemsList.Add(new Item("Rod_of_Ages_item"));
        itemsList.Add(new Item("Ruby_Sightstone_item"));
        itemsList.Add(new Item("Runaan's_Hurricane_item", "ranged"));
        itemsList.Add(new Item("Rylai's_Crystal_Scepter_item"));
        itemsList.Add(new Item("Seraph's_Embrace_item"));
        itemsList.Add(new Item("Spirit_Visage_item"));
        itemsList.Add(new Item("Statikk_Shiv_item"));
        itemsList.Add(new Item("Sterak's_Gage_item", "melee"));
        itemsList.Add(new Item("Sunfire_Cape_item"));
        itemsList.Add(new Item("Talisman_of_Ascension_item", "gold"));
        itemsList.Add(new Item("The_Black_Cleaver_item"));
        itemsList.Add(new Item("The_Bloodthirster_item"));
        itemsList.Add(new Item("Thornmail_item"));
        itemsList.Add(new Item("Titanic_Hydra_item", "melee"));
        itemsList.Add(new Item("Trinity_Force_item"));
        itemsList.Add(new Item("Void_Staff_item"));
        itemsList.Add(new Item("Warmog's_Armor_item"));
        itemsList.Add(new Item("Wit's_End_item"));
        itemsList.Add(new Item("Youmuu's_Ghostblade_item"));
        itemsList.Add(new Item("Zeke's_Convergence_item"));
        itemsList.Add(new Item("Zhonya's_Hourglass_item"));
        itemsList.Add(new Item("Zz'Rot_Portal_item"));



        runesList.Add(new Rune("Press_the_Attack_rune", "P", "K", 1));
        runesList.Add(new Rune("Lethal_Tempo_rune", "P", "K", 2));
        runesList.Add(new Rune("Fleet_Footwork_rune", "P", "K", 3));
        runesList.Add(new Rune("Overheal_rune", "P", "1", 1));
        runesList.Add(new Rune("Triumph_rune", "P", "1", 2));
        runesList.Add(new Rune("Presence_of_Mind_rune", "P", "1", 3));
        runesList.Add(new Rune("Legend-_Alacrity_rune", "P", "2", 1));
        runesList.Add(new Rune("Legend-_Tenacity_rune", "P", "2", 2));
        runesList.Add(new Rune("Legend-_Bloodline_rune", "P", "2", 3));
        runesList.Add(new Rune("Coup_de_Grace_rune", "P", "3", 1));
        runesList.Add(new Rune("Cut_Down_rune", "P", "3", 2));
        runesList.Add(new Rune("Last_Stand_rune", "P", "3", 3));

        runesList.Add(new Rune("Electrocute_rune", "D", "K", 1));
        runesList.Add(new Rune("Predator_rune", "D", "K", 2));
        runesList.Add(new Rune("Dark_Harvest_rune", "D", "K", 3));
        runesList.Add(new Rune("Cheap_Shot_rune", "D", "1", 1));
        runesList.Add(new Rune("Taste_of_Blood_rune", "D", "1", 2));
        runesList.Add(new Rune("Sudden_Impact_rune", "D", "1", 3));
        runesList.Add(new Rune("Zombie_Ward_rune", "D", "2", 1));
        runesList.Add(new Rune("Ghost_Poro_rune", "D", "2", 2));
        runesList.Add(new Rune("Eyeball_Collection_rune", "D", "2", 3));
        runesList.Add(new Rune("Ravenous_Hunter_rune", "D", "3", 1));
        runesList.Add(new Rune("Ingenious_Hunter_rune", "D", "3", 2));
        runesList.Add(new Rune("Relentless_Hunter_rune", "D", "3", 3));

        runesList.Add(new Rune("Summon_Aery_rune", "S", "K", 1));
        runesList.Add(new Rune("Arcane_Comet_rune", "S", "K", 2));
        runesList.Add(new Rune("Phase_Rush_rune", "S", "K", 3));
        runesList.Add(new Rune("Nullifying_Orb_rune", "S", "1", 1));
        runesList.Add(new Rune("Manaflow_Band_rune", "S", "1", 2));
        runesList.Add(new Rune("The_Ultimate_Hat_rune", "S", "1", 3));
        runesList.Add(new Rune("Transcendence_rune", "S", "2", 1));
        runesList.Add(new Rune("Celerity_rune", "S", "2", 2));
        runesList.Add(new Rune("Absolute_Focus_rune", "S", "2", 3));
        runesList.Add(new Rune("Scorch_rune", "S", "3", 1));
        runesList.Add(new Rune("Waterwalking_rune", "S", "3", 2));
        runesList.Add(new Rune("Gathering_Storm_rune", "S", "3", 3));

        runesList.Add(new Rune("Grasp_of_the_Undying_rune", "R", "K", 1));
        runesList.Add(new Rune("Aftershock_rune", "R", "K", 2));
        runesList.Add(new Rune("Guardian_rune", "R", "K", 3));
        runesList.Add(new Rune("Unflinching_rune", "R", "1", 1));
        runesList.Add(new Rune("Demolish_rune", "R", "1", 2));
        runesList.Add(new Rune("Font_of_Life_rune", "R", "1", 3));
        runesList.Add(new Rune("Iron_Skin_rune", "R", "2", 1));
        runesList.Add(new Rune("Mirror_Shell_rune", "R", "2", 2));
        runesList.Add(new Rune("Conditioning_rune", "R", "2", 3));
        runesList.Add(new Rune("Overgrowth_rune", "R", "3", 1));
        runesList.Add(new Rune("Revitalize_rune", "R", "3", 2));
        runesList.Add(new Rune("Second_Wind_rune", "R", "3", 3));

        runesList.Add(new Rune("Unsealed_Spellbook_rune", "I", "K", 1));
        runesList.Add(new Rune("Glacial_Augment_rune", "I", "K", 2));
        runesList.Add(new Rune("Kleptomancy_rune", "I", "K", 3));
        runesList.Add(new Rune("Hextech_Flashtraption_rune", "I", "1", 1));
        runesList.Add(new Rune("Biscuit_Delivery_rune", "I", "1", 2));
        runesList.Add(new Rune("Perfect_Timing_rune", "I", "1", 3));
        runesList.Add(new Rune("Magical_Footwear_rune", "I", "2", 1));
        runesList.Add(new Rune("Future's_Market_rune", "I", "2", 2));
        runesList.Add(new Rune("Minion_Dematerializer_rune", "I", "2", 3));
        runesList.Add(new Rune("Cosmic_Insight_rune", "I", "3", 1));
        runesList.Add(new Rune("Approach_Velocity_rune", "I", "3", 2));
        runesList.Add(new Rune("Celestial_Body_rune", "I", "3", 3));

        roll();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseHoldBegin = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (checkBtnClick("btnRoll"))
            {
                roll();
            }
            if (checkBtnClick("btnMenuRoll"))
            {
                roll();
            }
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
        summIcon1.gameObject.transform.localScale = GameObject.Find("summ1bg").gameObject.transform.localScale * 100 / 64;
        summIcon2.gameObject.transform.position = GameObject.Find("summ2bg").gameObject.transform.position;
        summIcon2.gameObject.transform.localScale = GameObject.Find("summ2bg").gameObject.transform.localScale * 100 / 64;

        summIcon1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("summSpells/" + summsNamesList[summ1])[0];
        summIcon2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("summSpells/" + summsNamesList[summ2])[0];

        moveGameObjectToZMinus1(summIcon1);
        summIcon2.gameObject.transform.position=new Vector3(summIcon2.gameObject.transform.position.x, summIcon2.gameObject.transform.position.y, -1.1f);

        champ = Random.Range(0, champsList.Count);
        GameObject champIcon = new GameObject();
        champIcon.AddComponent<SpriteRenderer>();
        champIcon.gameObject.tag = "icon";
        champIcon.gameObject.transform.position = GameObject.Find("champBg").gameObject.transform.position;
        champIcon.gameObject.transform.localScale = GameObject.Find("champBg").gameObject.transform.localScale * 100 / 120;
        champIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Champions/" + champsList[champ].name)[0];
        moveGameObjectToZMinus1(champIcon);

        GameObject itemBootsIcon = new GameObject();
        itemBootsIcon.AddComponent<SpriteRenderer>();

        itemBootsIcon.gameObject.tag = "icon";

        itemBootsIcon.gameObject.transform.position = GameObject.Find("itemBootsBg").gameObject.transform.position;
        itemBootsIcon.gameObject.transform.localScale = GameObject.Find("itemBootsBg").gameObject.transform.localScale * 100 / 64;

        itemBootsIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/Boots/" + bootsList[Random.Range(0, bootsList.Count)])[0];
        moveGameObjectToZMinus1(itemBootsIcon);


        /*
        GameObject champIcon = new GameObject();
        champIcon.AddComponent<SpriteRenderer>();

        champIcon.gameObject.tag = "icon";

        champIcon.gameObject.transform.position = GameObject.Find("champBg").gameObject.transform.position;

        champIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Champions/" + champsList[Random.Range(0, champsList.Count)].name)[0];
        */

        GameObject itemIcon1 = new GameObject();
        GameObject itemIcon2 = new GameObject();
        GameObject itemIcon3 = new GameObject();
        GameObject itemIcon4 = new GameObject();
        GameObject itemIcon5 = new GameObject();
        itemIcon1.AddComponent<SpriteRenderer>();
        itemIcon2.AddComponent<SpriteRenderer>();
        itemIcon3.AddComponent<SpriteRenderer>();
        itemIcon4.AddComponent<SpriteRenderer>();
        itemIcon5.AddComponent<SpriteRenderer>();
        itemIcon1.gameObject.tag = "icon";
        itemIcon2.gameObject.tag = "icon";
        itemIcon3.gameObject.tag = "icon";
        itemIcon4.gameObject.tag = "icon";
        itemIcon5.gameObject.tag = "icon";
        itemIcon1.gameObject.transform.position = GameObject.Find("item1").gameObject.transform.position;
        itemIcon2.gameObject.transform.position = GameObject.Find("item2").gameObject.transform.position;
        itemIcon3.gameObject.transform.position = GameObject.Find("item3").gameObject.transform.position;
        itemIcon4.gameObject.transform.position = GameObject.Find("item4").gameObject.transform.position;
        itemIcon5.gameObject.transform.position = GameObject.Find("item5").gameObject.transform.position;
        itemIcon1.gameObject.transform.localScale = GameObject.Find("item1").gameObject.transform.lossyScale * 100 / 64;
        itemIcon2.gameObject.transform.localScale = GameObject.Find("item2").gameObject.transform.lossyScale * 100 / 64;
        itemIcon3.gameObject.transform.localScale = GameObject.Find("item3").gameObject.transform.lossyScale * 100 / 64;
        itemIcon4.gameObject.transform.localScale = GameObject.Find("item4").gameObject.transform.lossyScale * 100 / 64;
        itemIcon5.gameObject.transform.localScale = GameObject.Find("item5").gameObject.transform.lossyScale * 100 / 64;
        

        do
        {
            item1 = Random.Range(0, itemsList.Count);
        } while (checkRestrictions(champ, item1) == false);
        do
        {
            item2 = Random.Range(0, itemsList.Count);
        } while (item2 == item1 || checkRestrictions(champ, item2, item1) == false);
        do
        {
            item3 = Random.Range(0, itemsList.Count);
        } while (item3 == item1 || item3 == item2 || checkRestrictions(champ, item3, item2, item1) == false);
        do
        {
            item4 = Random.Range(0, itemsList.Count);
        } while (item4 == item1 || item4 == item2 || item4 == item1 || checkRestrictions(champ, item4, item3, item2, item1) == false);
        do
        {
            item5 = Random.Range(0, itemsList.Count);
        } while (item5 == item1 || item5 == item4 || item5 == item3 || item5 == item2 || item5 == item1 || checkRestrictions(champ, item5, item4, item3, item2, item1) == false);

        moveGameObjectToZMinus1(itemIcon1);
        moveGameObjectToZMinus1(itemIcon2);
        moveGameObjectToZMinus1(itemIcon3);
        moveGameObjectToZMinus1(itemIcon4);
        moveGameObjectToZMinus1(itemIcon5);


        itemIcon1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[item1].name)[0];
        itemIcon2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[item2].name)[0];
        itemIcon3.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[item3].name)[0];
        itemIcon4.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[item4].name)[0];
        itemIcon5.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[item5].name)[0];

        if (champsList[champ].isViktor)
        {
            itemIcon1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/Special/HexCore")[0]; //Viktor
        }
        if (champsList[champ].name == "Cassiopeia") //Cassiopeia
        {
            int newItem;
            do
            {
                newItem = Random.Range(0, itemsList.Count);
            } while (newItem == item5 || newItem == item4 || newItem == item3 || newItem == item2 || newItem == item1 || checkRestrictions(champ, newItem, item5, item4, item3, item2, item1) == false);
            itemBootsIcon.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("finishItems/" + itemsList[newItem].name)[0];
        }

        moveGameObjectToZMinus1(itemIcon1); //moving to z=-1 again because of the previously stated bug
        moveGameObjectToZMinus1(itemIcon2);
        moveGameObjectToZMinus1(itemIcon3);
        moveGameObjectToZMinus1(itemIcon4);
        moveGameObjectToZMinus1(itemIcon5);




        rollRunes();
    }

    string findRuneName(string tree, string row, int option)
    {
        foreach(Rune r in runesList)
        {
            if (r.tree == tree && r.row == row && r.option == option)
            {
                return (r.name);
            }
        }
        return null;
    }
     
    void rollRunes()
    {

        int treePrimaryNum = Random.Range(1,5);
        string treePrimaryStr = "";

        switch (treePrimaryNum)
        {
            case 1:
                treePrimaryStr = "P";
                break;
            case 2:
                treePrimaryStr = "D";
                break;
            case 3:
                treePrimaryStr = "S";
                break;
            case 4:
                treePrimaryStr = "R";
                break;
            case 5:
                treePrimaryStr = "I";
                break;
        }

        int treeSecondaryNum;

        do
        {
            treeSecondaryNum = Random.Range(1, 5);
        } while (treePrimaryNum == treeSecondaryNum);

        string treeSecondaryStr = "";

        switch (treeSecondaryNum)
        {
            case 1:
                treeSecondaryStr = "P";
                break;
            case 2:
                treeSecondaryStr = "D";
                break;
            case 3:
                treeSecondaryStr = "S";
                break;
            case 4:
                treeSecondaryStr = "R";
                break;
            case 5:
                treeSecondaryStr = "I";
                break;
        }



        GameObject runePrimaryKey = new GameObject();
        GameObject runePrimary1 = new GameObject();
        GameObject runePrimary2 = new GameObject();
        GameObject runePrimary3 = new GameObject();
        runePrimaryKey.AddComponent<SpriteRenderer>();
        runePrimary1.AddComponent<SpriteRenderer>();
        runePrimary2.AddComponent<SpriteRenderer>();
        runePrimary3.AddComponent<SpriteRenderer>();
        runePrimaryKey.gameObject.tag = "icon";
        runePrimary1.gameObject.tag = "icon";
        runePrimary2.gameObject.tag = "icon";
        runePrimary3.gameObject.tag = "icon";
        runePrimaryKey.gameObject.transform.position = GameObject.Find("runeKey").gameObject.transform.position;
        runePrimary1.gameObject.transform.position = GameObject.Find("runePrimary1").gameObject.transform.position;
        runePrimary2.gameObject.transform.position = GameObject.Find("runePrimary2").gameObject.transform.position;
        runePrimary3.gameObject.transform.position = GameObject.Find("runePrimary3").gameObject.transform.position;
        runePrimaryKey.gameObject.transform.localScale = GameObject.Find("runeKey").gameObject.transform.localScale * 100 / 52;
        runePrimary1.gameObject.transform.localScale = GameObject.Find("runePrimary1").gameObject.transform.localScale * 100 / 52;
        runePrimary2.gameObject.transform.localScale = GameObject.Find("runePrimary2").gameObject.transform.localScale * 100 / 52;
        runePrimary3.gameObject.transform.localScale = GameObject.Find("runePrimary3").gameObject.transform.localScale * 100 / 52;

        string rk = "runes/" + findRuneName(treePrimaryStr, "K", Random.Range(1, 3));
        string r1 = "runes/" + findRuneName(treePrimaryStr, "1", Random.Range(1, 3));
        string r2 = "runes/" + findRuneName(treePrimaryStr, "2", Random.Range(1, 3));
        string r3 = "runes/" + findRuneName(treePrimaryStr, "3", Random.Range(1, 3));

        /*
        Debug.Log("###########################");
        Debug.Log(rk);
        Debug.Log(r1);
        Debug.Log(r2);
        Debug.Log(r3);
        */

        runePrimaryKey.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>(rk)[0];
        runePrimary1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>(r1)[0];
        runePrimary2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>(r2)[0];
        runePrimary3.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>(r3)[0];

        moveGameObjectToZMinus1(runePrimaryKey);
        moveGameObjectToZMinus1(runePrimary1);
        moveGameObjectToZMinus1(runePrimary2);
        moveGameObjectToZMinus1(runePrimary3);
        /*
        runePrimaryKey.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treePrimaryStr, "K",Random.Range(1,3)))[0];
        runePrimary1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treePrimaryStr, "1", Random.Range(1, 3)))[0];
        runePrimary2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treePrimaryStr, "2", Random.Range(1, 3)))[0];
        runePrimary3.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treePrimaryStr, "3", Random.Range(1, 3)))[0];
        */
        GameObject runeSecondary1 = new GameObject();
        GameObject runeSecondary2 = new GameObject();
        runeSecondary1.AddComponent<SpriteRenderer>();
        runeSecondary2.AddComponent<SpriteRenderer>();
        runeSecondary1.gameObject.tag = "icon";
        runeSecondary2.gameObject.tag = "icon";
        runeSecondary1.gameObject.transform.position = GameObject.Find("runeSecondary1").gameObject.transform.position;
        runeSecondary2.gameObject.transform.position = GameObject.Find("runeSecondary2").gameObject.transform.position;
        runeSecondary1.gameObject.transform.localScale = GameObject.Find("runeSecondary1").gameObject.transform.localScale * 100 / 52;
        runeSecondary2.gameObject.transform.localScale = GameObject.Find("runeSecondary2").gameObject.transform.localScale * 100 / 52;

        moveGameObjectToZMinus1(runeSecondary1);
        moveGameObjectToZMinus1(runeSecondary2);

        switch (Random.Range(1, 3))
        {
            case 1:
                runeSecondary1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "1", Random.Range(1, 3)))[0];
                runeSecondary2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "2", Random.Range(1, 3)))[0];
                break;
            case 2:
                runeSecondary1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "2", Random.Range(1, 3)))[0];
                runeSecondary2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "3", Random.Range(1, 3)))[0];
                break;
            case 3:
                runeSecondary1.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "1", Random.Range(1, 3)))[0];
                runeSecondary2.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("runes/" + findRuneName(treeSecondaryStr, "3", Random.Range(1, 3)))[0];
                break;
        }




    }

    bool checkRestrictions(int champ, int itemNew, int item2 = -1, int item3 = -1, int item4 = -1, int item5 = -1, int item6 = -1)
    {

        if (itemsList[itemNew].restriction == "ranged" && champsList[champ].ranged == false)
        {
            return false;
        }
        if (itemsList[itemNew].restriction == "melee" && champsList[champ].ranged == true)
        {
            return false;
        }


        if (itemsList[itemNew].restriction == "gold")
        {
            int goldIncomeItems = 0;

            if (item1 != -1)
            {
                if (itemsList[item1].restriction == "gold")
                {
                    goldIncomeItems++;
                }
            }
            if (item2 != -1)
            {
                if (itemsList[item2].restriction == "gold")
                {
                    goldIncomeItems++;
                }
            }
            if (item3 != -1)
            {
                if (itemsList[item3].restriction == "gold")
                {
                    goldIncomeItems++;
                }
            }
            if (item4 != -1)
            {
                if (itemsList[item4].restriction == "gold")
                {
                    goldIncomeItems++;
                }

            }
            if (item5 != -1)
            {
                if (itemsList[item5].restriction == "gold")
                {
                    goldIncomeItems++;
                }
            }
            if (item6 != -1)
            {
                if (itemsList[item6].restriction == "gold")
                {
                    goldIncomeItems++;
                }
            }

            if (goldIncomeItems != 0)
            {
                return false;
            }
        }

        return true;
    }

    void moveGameObjectToZMinus1(GameObject go)
    {
        go.gameObject.transform.position = new Vector3(go.gameObject.transform.position.x, go.gameObject.transform.position.y, -1);
    }
    /*
    bool detectClickBtnRoll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform btnRollTransform = GameObject.Find("btnRoll").GetComponent<Transform>();

            Vector3 clickCoordinates = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            if (clickCoordinates.x > btnRollTransform.position.x - btnRollTransform.lossyScale.x/2 &&
                clickCoordinates.x < btnRollTransform.position.x + btnRollTransform.lossyScale.x/2 &&
                clickCoordinates.y > btnRollTransform.position.y - btnRollTransform.lossyScale.y/2 &&
                clickCoordinates.y < btnRollTransform.position.y + btnRollTransform.lossyScale.y/2
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
    }*/

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

    

}

public class Champ
{
    public string name;
    public bool ranged;
    public bool isViktor;

    public Champ(string name, bool ranged = false, bool isViktor = false)
    {
        this.name = name;
        this.ranged = ranged;
        this.isViktor = isViktor;
    }
}

public class Item
{
    public string name;
    public string restriction;

    public Item(string name, string restriction = "")
    {
        this.name = name;
        this.restriction = restriction;
    }
}

public class Rune
{
    public string name;
    public string tree;
    public string row;
    public int option;

    public Rune(string name, string tree, string row, int option)
    {
        this.name = name;
        this.tree = tree;
        this.row = row;
        this.option = option;
    }
}