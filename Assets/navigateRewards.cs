using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class navigateRewards : MonoBehaviour
{
    public string scene;
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
        SceneManager.LoadScene (sceneName: scene);

    }
   
}
