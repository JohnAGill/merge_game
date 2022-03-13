using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceTaken : MonoBehaviour
{
    public bool taken;
     private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("exit");
        this.taken = false;
    }

    public bool GetTaken() {
        return this.taken;
    }
     public void SetTaken() {
         Debug.Log("testttt");
        this.taken = true;
    }
}
