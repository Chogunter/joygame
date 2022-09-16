using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munscript : MonoBehaviour
{
    //public List<string> master;
    GameObject Mun1;
    GameObject Mun2;
    [SerializeField]
    float time;

    GameObject AudioManeger;
    void Start()
    {
        Mun1 = transform.GetChild(0).gameObject;
        Mun2 = transform.GetChild(1).gameObject;

        AudioManeger = GameObject.Find("Player_sound");
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > 1f)
        {
            close();
        }
    }

    public void Opentry()
    {
        time = 0;
        open();
    }

    void open()
    {
        Mun1.SetActive(false);
        Mun2.SetActive(false);
        AudioManeger.GetComponent<Player_sound_effect>().Soundoff("door");
        AudioManeger.GetComponent<Player_sound_effect>().Sound("door");
    }
    void close()
    {

        Mun1.SetActive(true);
        Mun2.SetActive(true);
    }
}
