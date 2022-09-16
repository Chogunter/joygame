using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stuffManager : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    public GameObject item6;
    public GameObject item7;

    private string a1;
    private string a2;
    private string a3;
    private string a4;
    private string a5;
    private string a6;
    private string a7;

    private int Amount1;
    private int Amount2;
    private int Amount3;
    private int Amount4;
    private int Amount5;
    private int Amount6;
    private int Amount7;

    void Update()
    {
        a1 = item1.GetComponent<itemslotscript>().a;
        a2 = item2.GetComponent<itemslotscript>().a;
        a3 = item3.GetComponent<itemslotscript>().a;
        a4 = item4.GetComponent<itemslotscript>().a;
        a5 = item5.GetComponent<itemslotscript>().a;
        a6 = item6.GetComponent<itemslotscript>().a;
        a7 = item7.GetComponent<itemslotscript>().a;

        Amount1 = item1.GetComponent<itemslotscript>().amount;
        Amount2 = item2.GetComponent<itemslotscript>().amount;
        Amount3 = item3.GetComponent<itemslotscript>().amount;
        Amount4 = item4.GetComponent<itemslotscript>().amount;
        Amount5 = item5.GetComponent<itemslotscript>().amount;
        Amount6 = item6.GetComponent<itemslotscript>().amount;
        Amount7 = item7.GetComponent<itemslotscript>().amount;

        //var 변수명 = new Dictionary<Key 타입, Value 타입>();
    }
}
