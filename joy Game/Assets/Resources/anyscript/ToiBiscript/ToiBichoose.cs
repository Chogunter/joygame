using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToiBichoose : MonoBehaviour
{
    public List<GameObject> itemsdad;
    private int thedogul;
    public int num;
    public string theitem;
    public Text text;

    void Update()
    {
        text.text = num.ToString();

        if(theitem == "namu")
        {
            thedogul = 0;
        }
        else if (theitem == "gogi")
        {
            thedogul = 1;
        }
        else if (theitem == "jackMul")
        {
            thedogul = 2;
        }
        else if (theitem == "jackMulddang")
        {
            thedogul = 3;
        }
        else if (theitem == "myomock")
        {
            thedogul = 4;
        }
        else if (theitem == "none")
        {
            thedogul = 5;
        }

        for (int i = 0; i < itemsdad.Count; i++)
        {
            if(i == thedogul)
            {
                itemsdad[i].SetActive(true);
            }
            else
            {
                itemsdad[i].SetActive(false);
            }
        }
    }
}
