using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invenmaniger : MonoBehaviour
{
    public bool inven;
    [SerializeField] GameObject[] Inven = new GameObject[6];
    [SerializeField] GameObject Invens;
    GameObject Player;
    GameObject Cursor;
    public string[] items = new string[6];
    public int[] nums = new int[6];
    void Start()
    {
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        for(int i = 0; i < 6; i++)
        {
            nums[i] = 0;
        }
    }
    void Update()
    {
        for(int i = 0; i < 6; i++)
        {
            if(nums[i] <= 0)
            {
                items[i] = "none";
            }
        }
        if (inven)
        {
            Invens.SetActive(true);
        }
        else
        {
            Invens.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Player.GetComponent<ESC>().Inven += 1;
        }
        if(Player.GetComponent<ESC>().Inven % 2 == 1)
        {
            inven = true;
        }
        else
        {
            inven = false;
        }
        for(int i = 0; i < 6; i++)
        {
            Inven[i].GetComponent<itemslotscript>().a = items[i];
            Inven[i].GetComponent<itemslotscript>().amount = nums[i];
        }
    }

    public void Inven1()
    {
        Trygetorstrage(0);
    }
    public void Inven2()
    {
        Trygetorstrage(1);
    }
    public void Inven3()
    {
        Trygetorstrage(2);
    }
    public void Inven4()
    {
        Trygetorstrage(3);
    }
    public void Inven5()
    {
        Trygetorstrage(4);
    }
    public void Inven6()
    {
        Trygetorstrage(5);
    }
    public void Invenopen()
    {

    }

    void Trygetorstrage(int i)
    {
        if(Cursor.GetComponent<ItemCursor>().Using_Item == "chong" && items[i] == "chong")
        {
            Change(i);
        }
        else if(Cursor.GetComponent<ItemCursor>().Using_Item == "hwal" && items[i] == "hwal")
        {
            Change(i);
        }
        else if(nums[i] > 0 && (Cursor.GetComponent<ItemCursor>().Using_Item == items[i]) &&
            !((Cursor.GetComponent<ItemCursor>().Using_Slot == 1 && Player.GetComponent<PlayerHand>().Amount1 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 2 && Player.GetComponent<PlayerHand>().Amount2 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 3 && Player.GetComponent<PlayerHand>().Amount3 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 4 && Player.GetComponent<PlayerHand>().Amount4 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 5 && Player.GetComponent<PlayerHand>().Amount5 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 6 && Player.GetComponent<PlayerHand>().Amount6 >= itemmaxcheck(items[i])) ||
            (Cursor.GetComponent<ItemCursor>().Using_Slot == 7 && Player.GetComponent<PlayerHand>().Amount7 >= itemmaxcheck(items[i]))))
        {
            FromInven(i);
        }
        else
        {
            Change(i);
        }
    }
    private void Change(int i)
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Item != "chong" || true)
        {
            string sss;
            int bbb;
            sss = items[i];
            bbb = nums[i];
            items[i] = Cursor.GetComponent<ItemCursor>().Using_Item;
            if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
            {
                Player.GetComponent<PlayerHand>().PickUp1 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount1;
                Player.GetComponent<PlayerHand>().Amount1 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
            {
                Player.GetComponent<PlayerHand>().PickUp2 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount2;
                Player.GetComponent<PlayerHand>().Amount2 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
            {
                Player.GetComponent<PlayerHand>().PickUp3 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount3;
                Player.GetComponent<PlayerHand>().Amount3 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
            {
                Player.GetComponent<PlayerHand>().PickUp4 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount4;
                Player.GetComponent<PlayerHand>().Amount4 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
            {
                Player.GetComponent<PlayerHand>().PickUp5 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount5;
                Player.GetComponent<PlayerHand>().Amount5 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
            {
                Player.GetComponent<PlayerHand>().PickUp6 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount6;
                Player.GetComponent<PlayerHand>().Amount6 = bbb;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
            {
                Player.GetComponent<PlayerHand>().PickUp7 = sss;
                nums[i] = Player.GetComponent<PlayerHand>().Amount7;
                Player.GetComponent<PlayerHand>().Amount7 = bbb;
            }
        }
    }
    void FromInven(int i)
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount1 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount1;
                Player.GetComponent<PlayerHand>().Amount1 = max;
                Player.GetComponent<PlayerHand>().PickUp1 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp1 = items[i];
            Player.GetComponent<PlayerHand>().Amount1 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount2 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount2;
                Player.GetComponent<PlayerHand>().Amount2 = max;
                Player.GetComponent<PlayerHand>().PickUp2 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp2 = items[i];
            Player.GetComponent<PlayerHand>().Amount2 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount3 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount3;
                Player.GetComponent<PlayerHand>().Amount3 = max;
                Player.GetComponent<PlayerHand>().PickUp3 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp3 = items[i];
            Player.GetComponent<PlayerHand>().Amount3 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount4 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount4;
                Player.GetComponent<PlayerHand>().Amount4 = max;
                Player.GetComponent<PlayerHand>().PickUp4 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp4 = items[i];
            Player.GetComponent<PlayerHand>().Amount4 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount5 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount5;
                Player.GetComponent<PlayerHand>().Amount5 = max;
                Player.GetComponent<PlayerHand>().PickUp5 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp5 = items[i];
            Player.GetComponent<PlayerHand>().Amount5 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount6 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount6;
                Player.GetComponent<PlayerHand>().Amount6 = max;
                Player.GetComponent<PlayerHand>().PickUp6 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp6 = items[i];
            Player.GetComponent<PlayerHand>().Amount6 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
        {
            string playerpickup = items[i];
            int max = itemmaxcheck(playerpickup);
            if (Player.GetComponent<PlayerHand>().Amount7 + nums[i] > max && max != 99999)
            {
                nums[i] -= max - Player.GetComponent<PlayerHand>().Amount7;
                Player.GetComponent<PlayerHand>().Amount7 = max;
                Player.GetComponent<PlayerHand>().PickUp7 = items[i];
                return;
            }
            Player.GetComponent<PlayerHand>().PickUp7 = items[i];
            Player.GetComponent<PlayerHand>().Amount7 += nums[i];
            items[i] = "none";
            nums[i] = 0;
        }
    }

    int itemmaxcheck(string item)
    {
        if (item == "namu")
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
