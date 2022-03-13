using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    public float x_start, y_start;
    public int columnLength, rowLength;
    public float x_space, y_space;
    public GameObject Prefab;
    public GameObject Prefab2;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < columnLength * rowLength; i++) {
            if (i % 2 == 0) {
                Instantiate(Prefab, new Vector3(x_start + (x_space * (i %columnLength)), y_start + (y_space * (i / columnLength))), Quaternion.identity);
            } else {
                Instantiate(Prefab2, new Vector3(x_start + (x_space * (i %columnLength)), y_start + (y_space * (i / columnLength))), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
