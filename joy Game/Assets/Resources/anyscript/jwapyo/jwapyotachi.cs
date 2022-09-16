using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jwapyotachi : MonoBehaviour
{
    [SerializeField] Text T_Name;
    [SerializeField] Text T_dis;
    public string Naaame;
    public int dis;
    GameObject Player;
    void Start()
    {
    }

    void Update()
    {
        T_Name.text = Naaame;
        T_dis.text = dis.ToString() + " m";
    }
}
