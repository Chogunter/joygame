using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habsungMake : MonoBehaviour
{
    int AAA;
    bool Makes;
    bool AAAs;

    int Namus;
    int greens;
    int oranges;
    int reds;

    GameObject Player;
    public GameObject slot1;

    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick()
    {
        if (true)
        {
            if (true) // 나무
            {
                //Namus
                if (Player.GetComponent<PlayerHand>().PickUp1 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount1;
                if (Player.GetComponent<PlayerHand>().PickUp2 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount2;
                if (Player.GetComponent<PlayerHand>().PickUp3 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount3;
                if (Player.GetComponent<PlayerHand>().PickUp4 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount4;
                if (Player.GetComponent<PlayerHand>().PickUp5 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount5;
                if (Player.GetComponent<PlayerHand>().PickUp6 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount6;
                if (Player.GetComponent<PlayerHand>().PickUp7 == "namu")
                    Namus += Player.GetComponent<PlayerHand>().Amount7;
            }
            if (true)
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount1;
                if (Player.GetComponent<PlayerHand>().PickUp2 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount2;
                if (Player.GetComponent<PlayerHand>().PickUp3 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount3;
                if (Player.GetComponent<PlayerHand>().PickUp4 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount4;
                if (Player.GetComponent<PlayerHand>().PickUp5 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount5;
                if (Player.GetComponent<PlayerHand>().PickUp6 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount6;
                if (Player.GetComponent<PlayerHand>().PickUp7 == "greencore")
                    greens += Player.GetComponent<PlayerHand>().Amount7;
            }
            if (true)
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount1;
                if (Player.GetComponent<PlayerHand>().PickUp2 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount2;
                if (Player.GetComponent<PlayerHand>().PickUp3 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount3;
                if (Player.GetComponent<PlayerHand>().PickUp4 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount4;
                if (Player.GetComponent<PlayerHand>().PickUp5 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount5;
                if (Player.GetComponent<PlayerHand>().PickUp6 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount6;
                if (Player.GetComponent<PlayerHand>().PickUp7 == "orangecore")
                    oranges += Player.GetComponent<PlayerHand>().Amount7;
            }
            if (true)
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount1;
                if (Player.GetComponent<PlayerHand>().PickUp2 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount2;
                if (Player.GetComponent<PlayerHand>().PickUp3 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount3;
                if (Player.GetComponent<PlayerHand>().PickUp4 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount4;
                if (Player.GetComponent<PlayerHand>().PickUp5 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount5;
                if (Player.GetComponent<PlayerHand>().PickUp6 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount6;
                if (Player.GetComponent<PlayerHand>().PickUp7 == "redcore")
                    reds += Player.GetComponent<PlayerHand>().Amount7;
            }
        }
        if(slot1.GetComponent<itemslotscript>().a == "greencore")
        {
            Item_make_info.MakerItem thatInfo = Item_make_info.HabSungGi.Contatin("greencore");
            int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;

            if (Namus >= namudad)
            {
                Make(namudad, 0, 0, 0, "greencore");
            }
        }
        if (slot1.GetComponent<itemslotscript>().a == "orangecore")
        {
            Item_make_info.MakerItem thatInfo = Item_make_info.HabSungGi.Contatin("orangecore");
            int namudad = Item_make_info.Searchfor("greencore", thatInfo.materials).amount;

            if (greens >= namudad)
            {
                Make(0, namudad, 0, 0, "orangecore");
            }
        }
        if (slot1.GetComponent<itemslotscript>().a == "redcore")
        {
            Item_make_info.MakerItem thatInfo = Item_make_info.HabSungGi.Contatin("redcore");
            int namudad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;

            if (oranges >= namudad)
            {
                Make(0, 0, namudad, 0, "redcore");
            }
        }
        if (slot1.GetComponent<itemslotscript>().a == "puplecore")
        {
            Item_make_info.MakerItem thatInfo = Item_make_info.HabSungGi.Contatin("puplecore");
            int namudad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;

            if (reds >= namudad)
            {
                Make(0, 0, 0, namudad, "puplecore");
            }
        }
    }

    void Make(int namu, int green, int orange, int red, string name)
    {
        if (Player.GetComponent<PlayerHand>().PickUp1 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp2 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp3 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp4 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp5 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp6 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp7 == "none")
        {
            if (true)
            {
                play_record_info.Item_Make_Record.AddRecorder(name, 1);
                //Namu
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount1)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount2)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount3)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount4)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount5)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount6)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "namu" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > namu)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= namu;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount7)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                        }
                    }
                }
                //green
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount1)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount2)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount3)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount4)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount5)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount6)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "greencore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > green)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= green;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = green - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount7)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                        }
                    }
                }
                //orange
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount1)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount2)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount3)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount4)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount5)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount6)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "orangecore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > orange)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= orange;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = orange - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount7)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                        }
                    }
                }
                //red
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount1)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount2)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount2;
                            Player.GetComponent<PlayerHand>().Amount2 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount3)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount3;
                            Player.GetComponent<PlayerHand>().Amount3 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount4)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount4;
                            Player.GetComponent<PlayerHand>().Amount4 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount5)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount5;
                            Player.GetComponent<PlayerHand>().Amount5 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount1;
                            Player.GetComponent<PlayerHand>().Amount1 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount6)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
                        }
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "redcore" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > red)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= red;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = red - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                            AAAs = true;
                        }
                    }
                    else
                    {
                        if (AAA < Player.GetComponent<PlayerHand>().Amount7)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else
                        {
                            AAA = AAA - Player.GetComponent<PlayerHand>().Amount7;
                            Player.GetComponent<PlayerHand>().Amount7 = 0;
                        }
                    }
                }

                if (true)
                {
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = name;
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = name;
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = name;
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = name;
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = name;
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = name;
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = name;
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }
                }//아이템 배출

                Namus = 0;
                greens = 0;
                reds = 0;
                oranges = 0;
            }
        }
    }
}
