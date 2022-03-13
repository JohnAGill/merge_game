using UnityEngine;
using UnityEngine.EventSystems;
using System.Threading.Tasks;
public class DragEnd : MonoBehaviour
{
    public GameObject myPrefab;
    private GameObject closestBox;
   void Start()
    {
        //Fetch the Event Trigger component from your GameObject
        EventTrigger trigger = GetComponent<EventTrigger>();
        //Create a new entry for the Event Trigger
        EventTrigger.Entry entry = new EventTrigger.Entry();
        //Add a Drag type event to the Event Trigger
        entry.eventID = EventTriggerType.EndDrag;
       
        //call the OnDragDelegate function when the Event System detects dragging
        entry.callback.AddListener((data) => { OnDragEndDelegate((PointerEventData)data); });
        //Add the trigger entry
        trigger.triggers.Add(entry);
    }

   async public void OnDragEndDelegate(PointerEventData data)
    {
      var boxCollider = gameObject.GetComponent<BoxCollider2D>();
      boxCollider.enabled = true;
      boxCollider.isTrigger = true;
      
      await Task.Delay(100);
      if (gameObject) {
        this.closestBox = FindClosestSpace();
          gameObject.transform.position = new Vector3(this.closestBox.transform.position.x, closestBox.transform.position.y);
          boxCollider.isTrigger = false;

      }
    }


 
    public GameObject FindClosestSpace()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("gridSpace");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
          var s2 = go.GetComponent<spaceTaken>();
         
          if (s2) {          
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && !s2.GetTaken())
            {
                closest = go;
                distance = curDistance;
            }
          }
        }
        var s3 = closest.GetComponent<spaceTaken>();
        s3.SetTaken();
        return closest;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
      if (other.isTrigger) {
        if (other.tag == gameObject.tag) {
        Instantiate(myPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
        Destroy(other);
        
        }
      }
      if (other.tag == gameObject.tag) {
      Destroy(gameObject);
      }
      
    }
}