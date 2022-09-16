using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimdeacursorbitton : MonoBehaviour
{
    public GameObject chimdea;
    GameObject respwangwangri;
    void Start()
    {
        respwangwangri = GameObject.Find("respwangwangri");
    }

    void Update()
    {
        
    }
    public void OnClick()
    {
        respwangwangri.GetComponent<Respawnscript>().choosed(chimdea);
    }
}
