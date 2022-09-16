using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimdeaadd : MonoBehaviour
{
    [SerializeField] int index;
    GameObject Minimap;
    bool sss = true;
    void Start()
    {
        Minimap = GameObject.Find("respwangwangri");
        index = Minimap.GetComponent<respawnchimdealists>().chimdea.Count;
        Minimap.GetComponent<respawnchimdealists>().chimdea.Add(gameObject);
    }
    
    public void removelist()
    {
        //Debug.Log("removed");
        Minimap.GetComponent<respawnchimdealists>().chimdea.Remove(gameObject);
    }
}
