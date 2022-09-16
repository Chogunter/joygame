using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doguslotscript : MonoBehaviour
{
    public List<GameObject> slot;
    public string a;
    int b;
    void Start()
    {

    }
    void Update()
    {
        if (a == "jackMul")
        {
            b = 10;
        }
        if (a == "jackMulddang")
        {
            b = 11;
        }
        if (a == "chong")
        {
            b = 12;
        }
        if (a == "tangchang")
        {
            b = 13;
        }
        if (a == "chul")
        {
            b = 14;
        }
        if (a == "chulgui")
        {
            b = 15;
        }
        if (a == "chulGock")
        {
            b = 16;
        }
        if (a == "chulnamuGock")
        {
            b = 17;
        }
        if (a == "chulgum")
        {
            b = 18;
        }
        if (a == "chuldangum")
        {
            b = 19;
        }
        if (a == "myomock")
        {
            b = 20;
        }
        if (a == "sigea")
        {
            b = 21;
        }
        if (a == "chunsajin")
        {
            b = 22;
        }
        if (a == "chunsajinmk2")
        {
            b = 23;
        }
        if (a == "remover")
        {
            b = 24;
        }
        if (a == "greencore")
        {
            b = 25;
        }
        if (a == "orangecore")
        {
            b = 26;
        }
        if (a == "puplecore")
        {
            b = 27;
        }
        if (a == "redcore")
        {
            b = 28;
        }
        if (a == "dril")
        {
            b = 29;
        }
        if (a == "hubipgi")
        {
            b = 30;
        }
        if (a == "corepiece")
        {
            b = 31;
        }
        if (a == "gapock")
        {
            b = 32;
        }
        if (a == "suryutang")
        {
            b = 33;
        }
        if (a == "C4")
        {
            b = 34;
        }


        if (a == "none")
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
        if (a == "doll")
        {
            b = 0;
        }
        if (a == "gum")
        {
            b = 2;
        }
        if (a == "dollGock")
        {
            b = 3;
        }
        if (a == "namuGock")
        {
            b = 4;
        }
        if (a == "hwal")
        {
            b = 5;
        }
        if (a == "gogi")
        {
            b = 6;
        }
        if (a == "namu")
        {
            b = 7;
        }
        if (a == "namunamugock")
        {
            b = 8;
        }
        if (a == "namudollgock")
        {
            b = 9;
        }

        for (int i = 0; i < slot.Count; i++)
        {
            if (i == b)
                slot[i].SetActive(true);
            else
                slot[i].SetActive(false);
        }
    }
}
