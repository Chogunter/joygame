using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoguMaker : MonoBehaviour
{
    //public int Nones = 0;
    public int Dolls = 0;
    public int Namus = 0;
    public int Gogis = 0;
    public int DollGocks = 0;
    public int NamuGocks = 0;
    public int Gums = 0;
    public int Hwals = 0;

    public int Dollss = 0;
    public int Namuss = 0;
    public int Gogiss = 0;
    public int DollGockss = 0;
    public int NamuGockss = 0;
    public int Gumss = 0;
    public int Hwalss = 0;

    private int AAA = 0;
    private bool Makes = true;
    private bool AAAs = false;

    GameObject Player;
    GameObject DoguSlot;
    void Start()
    {
        Player = GameObject.Find("Player");
        DoguSlot = GameObject.Find("DoguSlot");
    }

    public void OnClick()
    {
        if (Player.GetComponent<PlayerHand>().PickUp1 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp2 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp3 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp4 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp5 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp6 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp7 == "none" ||
            DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "HwaSal")
        {
            AAA = 0;
            Makes = true;
            AAAs = false;
            /////////////
            //Dolls
            if (Player.GetComponent<PlayerHand>().PickUp1 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "doll")
                Dolls += Player.GetComponent<PlayerHand>().Amount7;
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
            //DollGocks
            if (Player.GetComponent<PlayerHand>().PickUp1 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "dollGock")
                DollGocks += Player.GetComponent<PlayerHand>().Amount7;
            //NamuGocks
            if (Player.GetComponent<PlayerHand>().PickUp1 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "namuGock")
                NamuGocks += Player.GetComponent<PlayerHand>().Amount7;
            //Gums
            if (Player.GetComponent<PlayerHand>().PickUp1 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "gum")
                Gums += Player.GetComponent<PlayerHand>().Amount7;
            //Hwals
            if (Player.GetComponent<PlayerHand>().PickUp1 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "hwal")
                Hwals += Player.GetComponent<PlayerHand>().Amount7;
            /////////////////
            if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "namunamugock")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("namunamugock");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                //Debug.Log("s");
                //Debug.Log(Namus.ToString());
                //Debug.Log(Dolls.ToString());
                if (Namus >= namuadad)
                {
                    InfoAdd("namunamugock");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
                    
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "namunamugock";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }

                    //////////////////////////////// 
                }
            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "namudollgock")
            {

                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("namudollgock");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                //Debug.Log("s");
                //Debug.Log(Namus.ToString());
                //Debug.Log(Dolls.ToString());
                if (Namus >= namuadad)
                {
                    InfoAdd("namudollgock");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "namudollgock";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }

                    //////////////////////////////// 
                }
            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "chunsajin")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("chunsajin");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int gogiiad = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

                //Debug.Log("s");
                //Debug.Log(Namus.ToString());
                //Debug.Log(Dolls.ToString());
                if (Gogis >= gogiiad && Namus >= namuadad)
                {
                    InfoAdd("chunsajin");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "gogi" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
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
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "chunsajin";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }

                    //////////////////////////////// DollGock
                }
            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "NamuGock")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("NamuGock");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int doalla = Item_make_info.Searchfor("doll", aaaaa.materials).amount;

                //Debug.Log("s");
                //Debug.Log(Namus.ToString());
                //Debug.Log(Dolls.ToString());
                if (Namus >= namuadad && Dolls >= doalla)
                {
                    InfoAdd("NamuGock");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
                    Makes = true;
                    AAAs = false;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount2 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount2;
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
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount3 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount3;
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
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount4 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount4;
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
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount5 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount5;
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
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount6 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount6;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount7;
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

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "namuGock";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }

                    //////////////////////////////// DollGock
                }
            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "DollGock")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("DollGock");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int doalla = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
                if (Namus >= namuadad && Dolls >= doalla) //나무75 + 돌100
                {
                    InfoAdd("DollGock");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
                    Makes = true;
                    AAAs = false;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount2 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount2;
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
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount3 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount3;
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
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount4 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount4;
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
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount5 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount5;
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
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount6 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount6;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount7;
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

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "dollGock";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }


                }
                
            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "Gum")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("Gum");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int doalla = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
                if (Namus >= namuadad && Dolls >= doalla) //나무30 + 돌150
                {
                    InfoAdd("Gum");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
                    Makes = true;
                    AAAs = false;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount2 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount2;
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
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount3 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount3;
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
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount4 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount4;
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
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount5 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount5;
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
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount6 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount6;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount7;
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


                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "gum";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "gum";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "gum";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "gum";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "gum";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "gum";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "gum";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }


                }

            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "Hwal")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("Hwal");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int gogiiad = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;
                if (Namus >= 50 && Gogis >= gogiiad) //나무50 + 고기20
                {
                    InfoAdd("Hwal");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
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
                        else if (Player.GetComponent<PlayerHand>().Amount1 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > gogiiad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= gogiiad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = gogiiad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount1 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount2 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount3 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount4 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount5 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount6 = 1;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "hwal";
                        Player.GetComponent<PlayerHand>().Amount7 = 1;
                    }


                }

            }
            else if (DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice == "HwaSal")
            {
                Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("HwaSal");
                int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
                int doalla = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
                if (Namus >= namuadad && Dolls >= doalla) //화살 나무15 + 돌10(2)
                {
                    InfoAdd("HwaSal");
                    Makes = true;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount2 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount2;
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
                        else if (Player.GetComponent<PlayerHand>().Amount3 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount3;
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
                        else if (Player.GetComponent<PlayerHand>().Amount4 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount4;
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
                        else if (Player.GetComponent<PlayerHand>().Amount5 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount5;
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
                        else if (Player.GetComponent<PlayerHand>().Amount6 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount1;
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
                        else if (Player.GetComponent<PlayerHand>().Amount7 > namuadad)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= namuadad;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = namuadad - Player.GetComponent<PlayerHand>().Amount7;
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
                    }////////////////////////////////////Doll
                    Makes = true;
                    AAAs = false;
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount1 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount1 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount1;
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
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount2 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount2 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount2;
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
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount3 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount3 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount3;
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
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount4 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount4 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount4;
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
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount5 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount5 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount5;
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
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount6 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount6 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount6;
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
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && Makes)
                    {
                        if (Player.GetComponent<PlayerHand>().Amount7 > AAA && AAA > 0)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= AAA;
                            AAA = 0;
                            Makes = false;
                        }
                        else if (Player.GetComponent<PlayerHand>().Amount7 > doalla)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 -= doalla;
                            Makes = false;
                        }
                        else if (AAA == 0)
                        {
                            if (!AAAs)
                            {
                                AAA = doalla - Player.GetComponent<PlayerHand>().Amount7;
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

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount1 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount2 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount3 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount4 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount5 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount6 += 2;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "hwal")
                    {
                        Player.GetComponent<PlayerHand>().Amount7 += 2;
                    }


                }

            }
            Namus = 0;
            Dolls = 0;
            Gogis = 0;
            Gums = 0;
            NamuGocks = 0;
            DollGocks = 0;
            Hwals = 0;
        }
    }

    void InfoAdd(string name)
    {
        play_record_info.Item_Make_Record.AddRecorder(name, 1);
    }
}
