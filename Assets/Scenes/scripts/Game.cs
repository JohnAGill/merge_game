using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Game : MonoBehaviour
{
	public GameObject wood_basic;
 	public GameObject wood_plank;
	public GameObject rod;
    public GameObject bait_fly;
 	public GameObject bait_worm;
  	public GameObject fire_fly;
   	public GameObject coal;
  	public GameObject plastic;
  	public GameObject plastic_stack;
   	public GameObject box;
  	public GameObject amethyst_q;
  	public GameObject amethyst_h;
   	public GameObject amethyst;
  	public GameObject sapphire_q;
  	public GameObject sapphire_h;
   	public GameObject sapphire;
  	public GameObject ruby_q;
  	public GameObject ruby_h;
   	public GameObject ruby;
    public GameObject emerald_q;
  	public GameObject emerald_h;
   	public GameObject emerald;
    List<item> items;
	  
  private string[] tags = new string [] {
      "wood_basic",
      "wood_plank",
      "rod",
      "bait_fly",
      "bait_worm",
      "fire_fly",
      "coal",
      "plastic",
      "plastic_stack",
      "box",
      "amethyst_q",
      "amethyst_h",
      "amethyst",
      "sapphire_q",
      "sapphire_h",
      "sapphire",
      "ruby_q",
      "ruby_h",
      "ruby",
      "emerald_q",
      "emerald_h",
      "emerald"
     };
    private List<item> itemsToSave= new List<item>();
    private save CreateSaveGameObject()
	{
		itemsToSave.Clear();
  		save Save = new save();
  		foreach (string tag in tags) {
    		GameObject[] gos;
   			gos = GameObject.FindGameObjectsWithTag(tag);
  			foreach (GameObject go in gos) {
    			item new_item = new item();
     			new_item.x = go.transform.position.x;
     			new_item.y = go.transform.position.y;
     			new_item.z = go.transform.position.z;
     			new_item.id = tag;
     			itemsToSave.Add(new_item);
     			Save.items = itemsToSave;
  			}
  		}

        return Save;
	}
	public void SaveGame()
	{	Debug.Log("Start Save");
		save Save = CreateSaveGameObject();
		string json = JsonUtility.ToJson(Save);
		System.IO.File.Delete(Application.persistentDataPath + "/gamesave.json");
		System.IO.File.WriteAllText(Application.persistentDataPath + "/gamesave.json", json);
		Debug.Log("Game Saved");
	}

    private void OnApplicationPause(bool pauseStatus) {
        // SaveGame();
    }

    public void LoadGame()
	{
  
		if (File.Exists(Application.persistentDataPath + "/gamesave.json"))
		{


		// 2
			string fileContents = File.ReadAllText(Application.persistentDataPath + "/gamesave.json");
						Debug.Log(fileContents);

var SaveData = JsonUtility.FromJson<save>(fileContents);
		// 3
			Debug.Log(fileContents);
			items = SaveData.items;
			foreach (item savedItem in SaveData.items) {
				Debug.Log(savedItem);
				if (savedItem.id == "wood_basic") {
					Instantiate(wood_basic, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "wood_plank") {
					Instantiate(wood_plank, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "rod") {
					Instantiate(rod, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "bait_fly") {
					Instantiate(bait_fly, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "bait_worm") {
					Instantiate(bait_worm, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "fire_fly") {
					Instantiate(fire_fly, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "coal") {
					Instantiate(coal, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "plastic") {
					Instantiate(plastic, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "plastic_stack") {
					Instantiate(plastic_stack, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "box") {
					Instantiate(box, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "amethyst_q") {
					Instantiate(amethyst_q, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "amethyst_h") {
					Instantiate(amethyst_h, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "amethyst") {
					Instantiate(amethyst, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "sapphire_q") {
					Instantiate(sapphire_q, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "sapphire_h") {
					Instantiate(sapphire_h, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "sapphire") {
					Instantiate(sapphire, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "ruby_q") {
					Instantiate(ruby_q, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "ruby_h") {
					Instantiate(ruby_h, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "ruby") {
					Instantiate(ruby, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "emerald_q") {
					Instantiate(emerald_q, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "emerald_h") {
					Instantiate(emerald_h, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				if (savedItem.id == "emerald") {
					Instantiate(emerald, new Vector3(savedItem.x, savedItem.y, savedItem.z),  Quaternion.identity);
				}
				
			}
			Debug.Log("Game Loaded");
		}
		else
		{
			Debug.Log("No game saved!");
		}
	}
	 void Start()
    {
       LoadGame();
	   InvokeRepeating("SaveGame", 60.0f, 25.0f);
    }
}
