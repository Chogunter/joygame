using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yongwangchoose : MonoBehaviour
{
    public List<GameObject> eee;
    public int num;

    private int the_dogu;
    public string dogu;

    public Text text;

    void Update()
    {
        text.text = num.ToString();
        if(dogu == "namu")
        {
            the_dogu = 0;
        }
        else if(dogu == "chul")
        {
            the_dogu = 1;
        }
        else if(dogu == "chulgui")
        {
            the_dogu = 2;
        }
        else if(dogu == "none")
        {
            the_dogu = 3;
        }

        for(int i = 0; i < eee.Count; i++)
        {
            if(i == the_dogu)
            {
                eee[i].SetActive(true);
            }
            else
            {
                eee[i].SetActive(false);
            }
        }
    }
}
