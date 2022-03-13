using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class save
{
    public List<item> items;
}
[System.Serializable]
public class item {
  public float x;
  public float y;
  public float z;

  public string id;
}