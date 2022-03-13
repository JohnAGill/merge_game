using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class getMore : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject wood;
  public GameObject coal;
  public GameObject bait;
   void Start()
    {
        //Fetch the Event Trigger component from your GameObject
        EventTrigger trigger = GetComponent<EventTrigger>();
        //Create a new entry for the Event Trigger
        EventTrigger.Entry entry = new EventTrigger.Entry();
        //Add a Drag type event to the Event Trigger
        entry.eventID = EventTriggerType.PointerUp;
       
        //call the OnDragDelegate function when the Event System detects dragging
        entry.callback.AddListener((data) => { OnDragDelegate((PointerEventData)data); });
        //Add the trigger entry
        trigger.triggers.Add(entry);
    }

   public void OnDragDelegate(PointerEventData data)
    {
         GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("gridSpace");
        var test3 = Filter(gos);
         for(int i = 0; i < 5; i++) {
           var test = test3[i];
           var s2 = test.GetComponent<spaceTaken>();
            if (s2) {
             float randomNumber = Random.Range(0, 3);
               if (randomNumber == 1) {
                    Instantiate(wood, new Vector3(test.transform.position.x, test.transform.position.y, 0),  Quaternion.identity);

               } else if (randomNumber == 2) {
                    Instantiate(coal, new Vector3(test.transform.position.x, test.transform.position.y, 0),  Quaternion.identity);

               }
               else {
                    Instantiate(bait, new Vector3(test.transform.position.x, test.transform.position.y, 0),  Quaternion.identity);
               }
                    s2.SetTaken();
                
            }
         }
    }
    
public GameObject[] Filter(GameObject[] input)
{
    List<GameObject> availableSpace = new List<GameObject>();
       foreach(GameObject go in input)
    {
        var s3 = go.GetComponent<spaceTaken>();
        if(!s3.GetTaken())
            availableSpace.Add(go);
    }

    return availableSpace.ToArray();
}
}
