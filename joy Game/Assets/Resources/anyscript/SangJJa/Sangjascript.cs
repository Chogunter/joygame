using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sangjascript : MonoBehaviour
{
    public GameObject Itemslot1;
    public GameObject Itemslot2;

    public string item1;
    public int num1;
    public string item2;
    public int num2;

    public GameObject cursor;

    public GameObject SangJa;

    private int cursorint = 1;

    bool s = true;
    public GameObject Cursor;
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        //Debug.Log(SangJa.name);
        if (SangJa.GetComponent<SangJJasaveandload>().Item1 == null)
        {
            SangJa.GetComponent<SangJJasaveandload>().Item1 = "none";
            SangJa.GetComponent<SangJJasaveandload>().num1 = 0;
            SangJa.GetComponent<SangJJasaveandload>().Item2 = "none";
            SangJa.GetComponent<SangJJasaveandload>().num2 = 0;
        }
        if (s)
        {
            ItemLoad();
            s = false;
        }
        Itemslot1.GetComponent<itemslotscript>().a = item1;
        Itemslot1.GetComponent<itemslotscript>().amount = num1;
        Itemslot2.GetComponent<itemslotscript>().a = item2;
        Itemslot2.GetComponent<itemslotscript>().amount = num2;

        if(num1 == 0)
        {
            item1 = "none";
        }
        if (num2 == 0)
        {
            item2 = "none";
        }
    }

    public void theButtonDown()
    {
        if(false)
        {
            if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
            {
               if(Player.GetComponent<PlayerHand>().PickUp1 == "none")
               {
                    Loadchoose();
               }
               else
               {
                    choose();
               }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
            {
                if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
            {
                if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
            {
                if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
            {
                if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
            {
                if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
            {
                if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Loadchoose();
                }
                else
                {
                    choose();
                }
            }
        }
        if (true)
        {
            if(cursorint == 1)
            {
                if(Cursor.GetComponent<ItemCursor>().Using_Item == "hwal" && item1 == "hwal")
                {
                    change();
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong" && item1 == "chong")
                {
                    change();
                }
                else if(num1 > 0 && (Cursor.GetComponent<ItemCursor>().Using_Item == item1 || Cursor.GetComponent<ItemCursor>().Using_Item == "none"))
                {
                    Loadchoose();
                }
                else if(item1 == "none")
                {
                    choose();
                }
                else
                {
                    change();
                }
            }
            else if (cursorint == 2)
            {
                if (Cursor.GetComponent<ItemCursor>().Using_Item == "hwal" && item2 == "hwal")
                {
                    change();
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong" && item2 == "chong")
                {
                    change();
                }
                else if(num2 > 0 && (Cursor.GetComponent<ItemCursor>().Using_Item == item2 || Cursor.GetComponent<ItemCursor>().Using_Item == "none"))
                {
                    Loadchoose();
                }
                else if (item2 == "none")
                {
                    choose();
                }
                else
                {
                    change();
                }
            }
        }
    }

    private void Loadchoose()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong" && false)
        {
            return;
        }
        if (cursorint == 1)
        {
            Loadchoose1();
        }
        else if (cursorint == 2)
        {
            Loadchoose2();
        }
    }
    //아이템칸으로 놓기
    private void Loadchoose2()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount1 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount1;
                Player.GetComponent<PlayerHand>().Amount1 = max;
                Player.GetComponent<PlayerHand>().PickUp1 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp1 = item2;
            Player.GetComponent<PlayerHand>().Amount1 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount2 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount2;
                Player.GetComponent<PlayerHand>().Amount2 = max;
                Player.GetComponent<PlayerHand>().PickUp2 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp2 = item2;
            Player.GetComponent<PlayerHand>().Amount2 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount3 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount3;
                Player.GetComponent<PlayerHand>().Amount3 = max;
                Player.GetComponent<PlayerHand>().PickUp3 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp3 = item2;
            Player.GetComponent<PlayerHand>().Amount3 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount4 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount4;
                Player.GetComponent<PlayerHand>().Amount4 = max;
                Player.GetComponent<PlayerHand>().PickUp4 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp4 = item2;
            Player.GetComponent<PlayerHand>().Amount4 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount5 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount5;
                Player.GetComponent<PlayerHand>().Amount5 = max;
                Player.GetComponent<PlayerHand>().PickUp5 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp5 = item2;
            Player.GetComponent<PlayerHand>().Amount5 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount6 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount6;
                Player.GetComponent<PlayerHand>().Amount6 = max;
                Player.GetComponent<PlayerHand>().PickUp6 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp6 = item2;
            Player.GetComponent<PlayerHand>().Amount6 += num2;
            item2 = "none";
            num2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            string playerpickup = item2;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount7 + num2 > max && max != 99999)
            {
                num2 -= max - Player.GetComponent<PlayerHand>().Amount7;
                Player.GetComponent<PlayerHand>().Amount7 = max;
                Player.GetComponent<PlayerHand>().PickUp7 = item2;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp7 = item2;
            Player.GetComponent<PlayerHand>().Amount7 += num2;
            item2 = "none";
            num2 = 0;

        }
    }
    private void Loadchoose1()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount1 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount1;
                Player.GetComponent<PlayerHand>().Amount1 = max;
                Player.GetComponent<PlayerHand>().PickUp1 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp1 = item1;
            Player.GetComponent<PlayerHand>().Amount1 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount2 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount2;
                Player.GetComponent<PlayerHand>().Amount2 = max;
                Player.GetComponent<PlayerHand>().PickUp2 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp2 = item1;
            Player.GetComponent<PlayerHand>().Amount2 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount3 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount3;
                Player.GetComponent<PlayerHand>().Amount3 = max;
                Player.GetComponent<PlayerHand>().PickUp3 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp3 = item1;
            Player.GetComponent<PlayerHand>().Amount3 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount4 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount4;
                Player.GetComponent<PlayerHand>().Amount4 = max;
                Player.GetComponent<PlayerHand>().PickUp4 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp4 = item1;
            Player.GetComponent<PlayerHand>().Amount4 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount5 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount5;
                Player.GetComponent<PlayerHand>().Amount5 = max;
                Player.GetComponent<PlayerHand>().PickUp5 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp5 = item1;
            Player.GetComponent<PlayerHand>().Amount5 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount6 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount6;
                Player.GetComponent<PlayerHand>().Amount6 = max;
                Player.GetComponent<PlayerHand>().PickUp6 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp6 = item1;
            Player.GetComponent<PlayerHand>().Amount6 += num1;
            item1 = "none";
            num1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            string playerpickup = item1;
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount7 + num1 > max && max != 99999)
            {
                num1 -= max - Player.GetComponent<PlayerHand>().Amount7;
                Player.GetComponent<PlayerHand>().Amount7 = max;
                Player.GetComponent<PlayerHand>().PickUp7 = item1;
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp7 = item1;
            Player.GetComponent<PlayerHand>().Amount7 += num1;
            item1 = "none";
            num1 = 0;

        }
    }

    private void choose()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong" && false)
        {
            return;
        }
        if (cursorint == 1)
        {
            if (item1 == "none")
            {
                choose1();
            }
        }
        else if (cursorint == 2)
        {
            if (item2 == "none")
            {
                choose2();
            }
        }
    }
    //아이템칸에서 빼기
    private void choose1()
    {
        if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount1;
            item1 = Player.GetComponent<PlayerHand>().PickUp1;
            Player.GetComponent<PlayerHand>().Amount1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount2;
            item1 = Player.GetComponent<PlayerHand>().PickUp2;
            Player.GetComponent<PlayerHand>().Amount2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount3;
            item1 = Player.GetComponent<PlayerHand>().PickUp3;
            Player.GetComponent<PlayerHand>().Amount3 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount4;
            item1 = Player.GetComponent<PlayerHand>().PickUp4;
            Player.GetComponent<PlayerHand>().Amount4 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount5;
            item1 = Player.GetComponent<PlayerHand>().PickUp5;
            Player.GetComponent<PlayerHand>().Amount5 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount6;
            item1 = Player.GetComponent<PlayerHand>().PickUp6;
            Player.GetComponent<PlayerHand>().Amount6 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            num1 = Player.GetComponent<PlayerHand>().Amount7;
            item1 = Player.GetComponent<PlayerHand>().PickUp7;
            Player.GetComponent<PlayerHand>().Amount7 = 0;
        }
    }
    private void choose2()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp1;
            num2 = Player.GetComponent<PlayerHand>().Amount1;
            Player.GetComponent<PlayerHand>().Amount1 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp2;
            num2 = Player.GetComponent<PlayerHand>().Amount2;
            Player.GetComponent<PlayerHand>().Amount2 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp3;
            num2 = Player.GetComponent<PlayerHand>().Amount3;
            Player.GetComponent<PlayerHand>().Amount3 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp4;
            num2 = Player.GetComponent<PlayerHand>().Amount4;
            Player.GetComponent<PlayerHand>().Amount4 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp5;
            num2 = Player.GetComponent<PlayerHand>().Amount5;
            Player.GetComponent<PlayerHand>().Amount5 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp6;
            num2 = Player.GetComponent<PlayerHand>().Amount6;
            Player.GetComponent<PlayerHand>().Amount6 = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            item2 = Player.GetComponent<PlayerHand>().PickUp7;
            num2 = Player.GetComponent<PlayerHand>().Amount7;
            Player.GetComponent<PlayerHand>().Amount7 = 0;
        }
    }

    public void ItemLoad()
    {
        item1 = SangJa.GetComponent<SangJJasaveandload>().Item1;
        num1 = SangJa.GetComponent<SangJJasaveandload>().num1;
        item2 = SangJa.GetComponent<SangJJasaveandload>().Item2;
        num2 = SangJa.GetComponent<SangJJasaveandload>().num2;
    }
    public void ItemSave()
    {
        s = true;
        SangJa.GetComponent<SangJJasaveandload>().Item1 = item1;
        SangJa.GetComponent<SangJJasaveandload>().num1 = num1;
        SangJa.GetComponent<SangJJasaveandload>().Item2 = item2;
        SangJa.GetComponent<SangJJasaveandload>().num2 = num2;
    }

    public void cursor1()
    {
        cursor.transform.localPosition = new Vector2(-127, 110);
        cursorint = 1;
    }
    public void cursor2()
    {
        cursor.transform.localPosition = new Vector2(114, 110);
        cursorint = 2;
    }

    void change()
    {
        if(cursorint == 1)
        {
            change1();
        }
        else if(cursorint == 2)
        {
            change2();
        }
    }
    void change1()
    {
        if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp1;
            num1 = Player.GetComponent<PlayerHand>().Amount1;
            Player.GetComponent<PlayerHand>().PickUp1 = itemss;
            Player.GetComponent<PlayerHand>().Amount1 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp2;
            num1 = Player.GetComponent<PlayerHand>().Amount2;
            Player.GetComponent<PlayerHand>().PickUp2 = itemss;
            Player.GetComponent<PlayerHand>().Amount2 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp3;
            num1 = Player.GetComponent<PlayerHand>().Amount3;
            Player.GetComponent<PlayerHand>().PickUp3 = itemss;
            Player.GetComponent<PlayerHand>().Amount3 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp4;
            num1 = Player.GetComponent<PlayerHand>().Amount4;
            Player.GetComponent<PlayerHand>().PickUp4 = itemss;
            Player.GetComponent<PlayerHand>().Amount4 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp5;
            num1 = Player.GetComponent<PlayerHand>().Amount5;
            Player.GetComponent<PlayerHand>().PickUp5 = itemss;
            Player.GetComponent<PlayerHand>().Amount5 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp6;
            num1 = Player.GetComponent<PlayerHand>().Amount6;
            Player.GetComponent<PlayerHand>().PickUp6 = itemss;
            Player.GetComponent<PlayerHand>().Amount6 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            string itemss = item1;
            int numss = num1;
            item1 = Player.GetComponent<PlayerHand>().PickUp7;
            num1 = Player.GetComponent<PlayerHand>().Amount7;
            Player.GetComponent<PlayerHand>().PickUp7 = itemss;
            Player.GetComponent<PlayerHand>().Amount7 = numss;
        }
    }
    void change2()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp1;
            num2 = Player.GetComponent<PlayerHand>().Amount1;
            Player.GetComponent<PlayerHand>().PickUp1 = itemss;
            Player.GetComponent<PlayerHand>().Amount1 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp2;
            num2 = Player.GetComponent<PlayerHand>().Amount2;
            Player.GetComponent<PlayerHand>().PickUp2 = itemss;
            Player.GetComponent<PlayerHand>().Amount2 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp3;
            num2 = Player.GetComponent<PlayerHand>().Amount3;
            Player.GetComponent<PlayerHand>().PickUp3 = itemss;
            Player.GetComponent<PlayerHand>().Amount3 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp4;
            num2 = Player.GetComponent<PlayerHand>().Amount4;
            Player.GetComponent<PlayerHand>().PickUp4 = itemss;
            Player.GetComponent<PlayerHand>().Amount4 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp5;
            num2 = Player.GetComponent<PlayerHand>().Amount5;
            Player.GetComponent<PlayerHand>().PickUp5 = itemss;
            Player.GetComponent<PlayerHand>().Amount5 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp6;
            num2 = Player.GetComponent<PlayerHand>().Amount6;
            Player.GetComponent<PlayerHand>().PickUp6 = itemss;
            Player.GetComponent<PlayerHand>().Amount6 = numss;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            string itemss = item2;
            int numss = num2;
            item2 = Player.GetComponent<PlayerHand>().PickUp7;
            num2 = Player.GetComponent<PlayerHand>().Amount7;
            Player.GetComponent<PlayerHand>().PickUp7 = itemss;
            Player.GetComponent<PlayerHand>().Amount7 = numss;
        }
    }

    int itemmaxcheck(string item)
    {
        if(item == "namu")
        {
            return 5000;
        }
        if (item == "doll")
        {
            return 4000;
        }
        if (item == "gogi")
        {
            return 300;
        }
        if (item == "chul")
        {
            return 500;
        }
        if (item == "chulgui")
        {
            return 200;
        }
        if (item == "jackMul")
        {
            return 4500;
        }
        if (item == "hwal")
        {
            return 99999;
        }
        if (item == "tangchang")
        {
            return 4500;
        }
        if (item == "corepiece")
        {
            return 700;
        }
        if (item == "suryutang")
        {
            return 200;
        }
        if (item == "C4")
        {
            return 25;
        }
        if (item == "hubipgi")
        {
            return 50;
        }
        if (item == "chong")
        {
            return 99999;
        }
        return 1;
    }
}
