using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiBiMaker : MonoBehaviour
{
    int AAA;
    bool Makes;
    bool AAAs;
    int Namus;
    int Gogis;
    int JackMuls;


    GameObject ToiBiTong_;
    GameObject Player;

    private void Start()
    {
        ToiBiTong_ = GameObject.Find("ToiBiTong_");
        Player = GameObject.Find("Player");
    }
    //경작지 : 나무 150 작물 20 고기 150
    //묘목 : 나무 30 작물 40 고기 100

    public void OnClick()
    {
        if (true)
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
            //Gogis
            if (Player.GetComponent<PlayerHand>().PickUp1 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi")
                Gogis += Player.GetComponent<PlayerHand>().Amount7;
            //JackMuls
            if (Player.GetComponent<PlayerHand>().PickUp1 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "jackMul")
                JackMuls += Player.GetComponent<PlayerHand>().Amount7;
        }
        if (true)
        {
            if(ToiBiTong_.GetComponent<ToiBichoose>().theitem == "jackMulddang")
            {
                Item_make_info.MakerItem thatInfo = Item_make_info.ToiBi.Contatin("jackMulddang");
                int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
                int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
                int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;

                Makers(namudad, gogidad, jackMuldad, "jackMulddang");
            }
            else if (ToiBiTong_.GetComponent<ToiBichoose>().theitem == "myomock")
            {
                Item_make_info.MakerItem thatInfo = Item_make_info.ToiBi.Contatin("myomock");
                int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
                int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
                int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;

                Makers(namudad, gogidad, jackMuldad, "myomock");
            }
        }
    }
    private void Makers(int namu, int gogi, int jackmul, string name)
    {
        if (Player.GetComponent<PlayerHand>().PickUp1 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp2 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp3 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp4 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp5 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp6 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp7 == "none")
        {
            if (Namus >= namu && Gogis >= gogi && JackMuls >= jackmul)
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
                            AAA = namu - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
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
                //Gogi
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount1;
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
                if (Player.GetComponent<PlayerHand>().PickUp2 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount2;
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
                if (Player.GetComponent<PlayerHand>().PickUp3 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount3;
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
                if (Player.GetComponent<PlayerHand>().PickUp4 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount4;
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
                if (Player.GetComponent<PlayerHand>().PickUp5 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount5;
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
                if (Player.GetComponent<PlayerHand>().PickUp6 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
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
                if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > gogi)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= gogi;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = gogi - Player.GetComponent<PlayerHand>().Amount7;
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
                //jackmul
                AAA = 0;
                Makes = true;
                AAAs = false;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount1 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount1;
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
                if (Player.GetComponent<PlayerHand>().PickUp2 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                        AAA = 0;

                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount2 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount2;
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
                if (Player.GetComponent<PlayerHand>().PickUp3 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount3 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount3;
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
                if (Player.GetComponent<PlayerHand>().PickUp4 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount4 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount4;
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
                if (Player.GetComponent<PlayerHand>().PickUp5 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount5 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount5;
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
                if (Player.GetComponent<PlayerHand>().PickUp6 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount6 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount6;
                            Player.GetComponent<PlayerHand>().Amount6 = 0;
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
                if (Player.GetComponent<PlayerHand>().PickUp7 == "jackMul" && Makes)
                {
                    if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().Amount7 > jackmul)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= jackmul;
                        Makes = false;
                    }
                    else if (AAA == 0)
                    {
                        if (!AAAs)
                        {
                            AAA = jackmul - Player.GetComponent<PlayerHand>().Amount7;
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

                //////////////////////////////// 
            }
        }
        JackMuls = 0;
        Gogis = 0;
        Namus = 0;
    }
}
