using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Savefileshows_In_main : MonoBehaviour
{
    public save_UI_in_main aaa;
    public string Name;
    public string date;
    [SerializeField] Text text;
    public void Starta()
    {
        text.text = "Name : " + Name + "\n" + "Date : " + date;
    }
    public void Check()
    {
        aaa.filechoose(Name);
    }
}
