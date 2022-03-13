using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UpdateClosestSpace();
    }

  public void UpdateClosestSpace()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("gridSpace");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
                
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
          
        }
        var s3 = closest.GetComponent<spaceTaken>();
        s3.SetTaken();
    }

}
