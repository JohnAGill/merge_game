using UnityEngine;
public class GenerateInital : MonoBehaviour 
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject wood;
    public GameObject bait;
    public GameObject coal;
 public int width = 2;
   public int height = 4;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
         for (int y=0; y<height; y+= 3)
       {
           for (int x=0; x<width; x+= 4)
           {
               Instantiate(wood, new Vector3(x,y,0), Quaternion.identity);
               Instantiate(bait, new Vector3(x,y,0), Quaternion.identity);
               Instantiate(coal, new Vector3(x,y,0), Quaternion.identity);
           }
       }              
    }
}