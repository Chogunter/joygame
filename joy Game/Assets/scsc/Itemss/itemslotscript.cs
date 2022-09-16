using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemslotscript : MonoBehaviour
{
    public Text text;

    public int amount = 0;

    public Texture[] Textures = new Texture[33];
    public RawImage thatimage;

    //public List<GameObject> Items;

    //public GameObject doll;
    //public GameObject none;
    //public GameObject gum;
    //public GameObject dollGock;
    //public GameObject namuGock;
    //public GameObject hwal;
    //public GameObject gogi;
    //public GameObject namu;

    //public GameObject namuNamuGock;
    //public GameObject namuDollGock;

    public string a;

    private int b;

    [SerializeField] bool isnotSlot = false;

    private void Start()
    {
        if (!isnotSlot)
        {
            Textures = GameObject.Find("Svae&Load Manager").GetComponent<itemslotscript>().Textures;
        }
    }

    void Update()
    {
        if (!isnotSlot)
            text.text = amount.ToString();

        //if(amount <= 0)
        //{
        //    a = "none";
        //}

        if(a == "jackMul")
        {
            b = 10;
        }
        else if (a == "jackMulddang")
        {
            b = 11;
        }
        else if (a == "chong")
        {
            b = 12;
        }
        else if (a == "tangchang")
        {
            b = 13;
        }
        else if (a == "chul")
        {
            b = 14;
        }
        else if (a == "chulgui")
        {
            b = 15;
        }
        else if (a == "chulGock")
        {
            b = 16;
        }
        else if(a == "chulnamuGock")
        {
            b = 17;
        }
        else if (a == "chulgum")
        {
            b = 18;
        }
        else if (a == "chuldangum")
        {
            b = 19;
        }
        else if (a == "myomock")
        {
            b = 20;
        }
        else if (a == "sigea")
        {
            b = 21;
        }
        else if (a == "chunsajin")
        {
            b = 22;
        }
        else if (a == "chunsajinmk2")
        {
            b = 23;
        }
        else if (a == "remover")
        {
            b = 24;
        }
        else if (a == "greencore")
        {
            b = 25;
        }
        else if (a == "orangecore")
        {
            b = 26;
        }
        else if (a == "puplecore")
        {
            b = 27;
        }
        else if (a == "redcore")
        {
            b = 28;
        }
        else if (a == "dril")
        {
            b = 29;
        }
        else if (a == "hubipgi")
        {
            b = 30;
        }
        else if (a == "corepiece")
        {
            b = 31;
        }
        else if (a == "gapock")
        {
            b = 32;
        }
        else if (a == "suryutang")
        {
            b = 33;
        }
        else if (a == "C4")
        {
            b = 34;
        }
        else if (a == "employ")
        {
            b = 35;
        }
        else if (a == "none")
        {
            b = 1;
            //none.gameObject.SetActive(true);
            //doll.gameObject.SetActive(false);
            //gum.gameObject.SetActive(false);
            //dollGock.gameObject.SetActive(false);
            //namuGock.gameObject.SetActive(false);
            //hwal.gameObject.SetActive(false);
            //gogi.gameObject.SetActive(false);
            //namu.gameObject.SetActive(false);

            //namuNamuGock.SetActive(false);
            //namuDollGock.SetActive(false);
        }
        else if (a == "doll")
        {
            b = 0;
        }
        else if (a == "gum")
        {
            b = 2;
        }
        else if (a == "dollGock")
        {
            b = 3;
        }
        else if (a == "namuGock")
        {
            b = 4;
        }
        else if (a == "hwal")
        {
            b = 5;
        }
        else if (a == "gogi")
        {
            b = 6;
        }
        else if (a == "namu")
        {
            b = 7;
        }
        else if (a == "namunamugock")
        {
            b = 8;
        }
        else if (a == "namudollgock")
        {
            b = 9;
        }

        //for (int i = 0; i < Items.Count; i++)
        //{
        //    if (i == b)
        //        Items[i].SetActive(true);
        //    else
        //        Items[i].SetActive(false);
        //}

        if (!isnotSlot)
            thatimage.texture = Textures[b];
    }
}
