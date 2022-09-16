using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JeaJackchoose : MonoBehaviour
{
    public List<GameObject> Doguss; // 1나무 2고기 3작물 
    public string Ahhh;
    private int thedogu;

    public Text text;
    public int num;

    void Update()
    {
        text.text = num.ToString();
        if(Ahhh == "Namu")
        {
            thedogu = 0;
        }
        else if(Ahhh == "Gogi")
        {
            thedogu = 1;
        }
        else if (Ahhh == "jackMul")
        {
            thedogu = 2;
        }
        else if (Ahhh == "chulGock")
        {
            thedogu = 3;
        }
        else if (Ahhh == "chulnamuGock")
        {
            thedogu = 4;
        }
        else if (Ahhh == "chulgum")
        {
            thedogu = 5;
        }
        else if (Ahhh == "chuldangum")
        {
            thedogu = 6;
        }
        else if (Ahhh == "remover")
        {
            thedogu = 7;
        }
        else if (Ahhh == "chunsajinmk2")
        {
            thedogu = 8;
        }
        else if (Ahhh == "None")
        {
            thedogu = 9;
        }
        else if (Ahhh == "chulgui")
        {
            thedogu = 10;
        }
        else if (Ahhh == "gapock")
        {
            thedogu = 11;
        }
        for (int i = 0; i < Doguss.Count; i++)
        {
            if(i == thedogu)
            {
                Doguss[i].SetActive(true);
            }
            else
            {
                Doguss[i].SetActive(false);
            }
        }
    }
}
