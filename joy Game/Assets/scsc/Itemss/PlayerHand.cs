using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public string PickUp1 = "doll"; //1
    public int Amount1 = 1500;

    public string PickUp2 = "none"; //2
    public int Amount2 = 0;

    public string PickUp3 = "none"; //3
    public int Amount3 = 0;

    public string PickUp4 = "none"; //4
    public int Amount4 = 0;

    public string PickUp5 = "none"; //5
    public int Amount5 = 0;

    public string PickUp6 = "none"; //6
    public int Amount6 = 0;

    public string PickUp7 = "none"; //7
    public int Amount7 = 0;

    public string PickUpF;
    public int AmountF;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject Fslot;
    public GameObject Cursor;
    public GameObject Fdogu;

    void Update()
    {
        if(Amount1 == 0)
            PickUp1 = "none";
        if (Amount2 == 0)
            PickUp2 = "none";
        if (Amount3 == 0)
            PickUp3 = "none";
        if (Amount4 == 0)
            PickUp4 = "none";
        if (Amount5 == 0)
            PickUp5 = "none";
        if (Amount6 == 0)
            PickUp6 = "none";
        if (Amount7 == 0)
            PickUp7 = "none";
        if (AmountF == 0)
            PickUpF = "none";

        slot1.GetComponent<itemslotscript>().amount = Amount1;
        slot1.GetComponent<itemslotscript>().a = PickUp1; //1

        slot2.GetComponent<itemslotscript>().amount = Amount2;
        slot2.GetComponent<itemslotscript>().a = PickUp2; //2

        slot3.GetComponent<itemslotscript>().amount = Amount3;
        slot3.GetComponent<itemslotscript>().a = PickUp3; //3

        slot4.GetComponent<itemslotscript>().amount = Amount4;
        slot4.GetComponent<itemslotscript>().a = PickUp4; //4

        slot5.GetComponent<itemslotscript>().amount = Amount5;
        slot5.GetComponent<itemslotscript>().a = PickUp5; //5

        slot6.GetComponent<itemslotscript>().amount = Amount6;
        slot6.GetComponent<itemslotscript>().a = PickUp6; //6

        slot7.GetComponent<itemslotscript>().amount = Amount7;
        slot7.GetComponent<itemslotscript>().a = PickUp7; //7

        Fslot.GetComponent<itemslotscript>().amount = AmountF;
        Fslot.GetComponent<itemslotscript>().a = PickUpF; //F

        Fdogu.GetComponent<doguslotscript>().a = PickUpF;

        if (Input.GetKeyDown(KeyCode.F))
        {
            if(!this.GetComponent<DoguThrowAway>().FFF)
                change();
        }
    }
    private void change()
    {
        string a1;
        int a2;

        if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            a1 = PickUp1;
            a2 = Amount1;
            PickUp1 = PickUpF;
            Amount1 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if(Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            a1 = PickUp2;
            a2 = Amount2;
            PickUp2 = PickUpF;
            Amount2 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            a1 = PickUp3;
            a2 = Amount3;
            PickUp3 = PickUpF;
            Amount3 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            a1 = PickUp4;
            a2 = Amount4;
            PickUp4 = PickUpF;
            Amount4 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            a1 = PickUp5;
            a2 = Amount5;
            PickUp5 = PickUpF;
            Amount5 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            a1 = PickUp6;
            a2 = Amount6;
            PickUp6 = PickUpF;
            Amount6 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            a1 = PickUp7;
            a2 = Amount7;
            PickUp7 = PickUpF;
            Amount7 = AmountF;
            PickUpF = a1;
            AmountF = a2;
        }
    }

}
