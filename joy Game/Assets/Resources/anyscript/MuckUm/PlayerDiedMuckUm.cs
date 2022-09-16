using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDiedMuckUm : MonoBehaviour
{
    public string[] Items = new string[14];
    public int[] ItemAmount = new int[14];
    public string[] InvenItems = new string[6];
    public int[] InvenItemAmount = new int[6];
    GameObject Player;
    GameObject Inven;
    public GameObject child;

    string thatname;
    int thatint;

    bool sss; // 수령하면 트루 안하면 펄스

    bool AAAAA;

    private int amount1;
    private int amount2;
    private int amount3;
    private int amount4;
    private int amount5;
    private int amount6;
    private int amount7;

    [SerializeField] GameObject chong;

    private void Awake()
    {

    }

    void Update()
    {
        child.transform.position = transform.position + Vector3.up * 2;

        for(int i = 0; i < ItemAmount.Length; i++)
        {
            if(ItemAmount[i] > 0)
            {
                return;
            }
        }
        gameObject.SetActive(false);
    }

    public void SaveItems()
    {
        Player = GameObject.Find("Player");
        Inven = GameObject.Find("Inventory");
        AAAAA = false;
        Items[0] = Player.GetComponent<PlayerHand>().PickUp1;
        ItemAmount[0] = Player.GetComponent<PlayerHand>().Amount1;
        Items[1] = Player.GetComponent<PlayerHand>().PickUp2;
        ItemAmount[1] = Player.GetComponent<PlayerHand>().Amount2;
        Items[2] = Player.GetComponent<PlayerHand>().PickUp3;
        ItemAmount[2] = Player.GetComponent<PlayerHand>().Amount3;
        Items[3] = Player.GetComponent<PlayerHand>().PickUp4;
        ItemAmount[3] = Player.GetComponent<PlayerHand>().Amount4;
        Items[4] = Player.GetComponent<PlayerHand>().PickUp5;
        ItemAmount[4] = Player.GetComponent<PlayerHand>().Amount5;
        Items[5] = Player.GetComponent<PlayerHand>().PickUp6;
        ItemAmount[5] = Player.GetComponent<PlayerHand>().Amount6;
        Items[6] = Player.GetComponent<PlayerHand>().PickUp7;
        ItemAmount[6] = Player.GetComponent<PlayerHand>().Amount7;
        Items[7] = Player.GetComponent<PlayerHand>().PickUpF;
        ItemAmount[7] = Player.GetComponent<PlayerHand>().AmountF;

        InvenItems[0] = Inven.GetComponent<Invenmaniger>().items[0];
        InvenItemAmount[0] = Inven.GetComponent<Invenmaniger>().nums[0];
        InvenItems[1] = Inven.GetComponent<Invenmaniger>().items[1];
        InvenItemAmount[1] = Inven.GetComponent<Invenmaniger>().nums[1];
        InvenItems[2] = Inven.GetComponent<Invenmaniger>().items[2];
        InvenItemAmount[2] = Inven.GetComponent<Invenmaniger>().nums[2];
        InvenItems[3] = Inven.GetComponent<Invenmaniger>().items[3];
        InvenItemAmount[3] = Inven.GetComponent<Invenmaniger>().nums[3];
        InvenItems[4] = Inven.GetComponent<Invenmaniger>().items[4];
        InvenItemAmount[4] = Inven.GetComponent<Invenmaniger>().nums[4];
        InvenItems[5] = Inven.GetComponent<Invenmaniger>().items[5];
        InvenItemAmount[5] = Inven.GetComponent<Invenmaniger>().nums[5];

        for(int i = 8; i < Items.Length; i++)
        {
            Items[i] = InvenItems[i - 8];
            ItemAmount[i] = InvenItemAmount[i - 8];
        }

        for(int i = 0; i < Items.Length; i++)
        {
            if(Items[i] == "chong")
            {
                var chongaaaa = Instantiate(chong, transform.position + Vector3.up * 5.5f, transform.rotation);
                chongaaaa.GetComponent<tangsave>().tang = ItemAmount[i] - 1;
                Items[i] = "none";
                ItemAmount[i] = 0;
            }
        }
    }
    public void SangJaItems(string name1, int num1, string name2, int num2)
    {
        Items[0] = name1;
        ItemAmount[0] = num1;
        Items[1] = name2;
        ItemAmount[1] = num2;
    }

    public void GetItem()
    {
        Player = GameObject.Find("Player");
        Inven = GameObject.Find("Inventory");
        int y = 0;
        while (y <= 13)
        {
            if (Items[y] == "none" || ItemAmount[y] <= 0)
            {
                y += 1;
                continue;
            }
            AAAAA = false;
            while (!AAAAA)
            {
                if(Items[y] == "none" || ItemAmount[y] <= 0)
                {
                    break;
                }
                AAAAA = true;
                Getready();
                Gets(Items[y], Getthingsmax(Items[y]), 1, y);
            }
            y += 1;
        }
        if (tryDestroys())
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    void Gets(string Itemname, int ItemMax, int Itemamount, int y)
    {
        if (true)
        {
            if (true)
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == Itemname && AAAAA)
                {
                    if (amount1 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount1 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == Itemname && AAAAA)
                {
                    if (amount2 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount2 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == Itemname && AAAAA)
                {
                    if (amount3 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount3 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == Itemname && AAAAA)
                {
                    if (amount4 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount4 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == Itemname && AAAAA)
                {
                    if (amount5 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount5 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == Itemname && AAAAA)
                {
                    if (amount6 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount6 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == Itemname && AAAAA)
                {
                    if (amount7 < ItemMax)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount7 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                }
                if (AAAAA)
                {
                    //Debug.Log("돌 칸이 없음");
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount1 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount1 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;

                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount2 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount2 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount3 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount3 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount4 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount4 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount5 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount5 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount6 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount6 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = Itemname;

                        Player.GetComponent<PlayerHand>().Amount7 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount7 > ItemMax && ItemMax < 90000)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = ItemMax;
                        }
                        AAAAA = false;
                        ItemAmount[y] -= Itemamount;
                    }
                    if (AAAAA)
                    {
                        for (int i = 0; i < Inven.GetComponent<Invenmaniger>().items.Length; i++)
                        {
                            if (Inven.GetComponent<Invenmaniger>().items[i] == Itemname && Inven.GetComponent<Invenmaniger>().nums[i] < ItemMax)
                            {
                                Inven.GetComponent<Invenmaniger>().nums[i] += Itemamount;
                                if (Inven.GetComponent<Invenmaniger>().nums[i] > ItemMax && ItemMax < 90000)
                                {
                                    Inven.GetComponent<Invenmaniger>().nums[i] = ItemMax;
                                }
                                AAAAA = false;
                                ItemAmount[y] -= Itemamount;
                                break;
                            }
                        }
                        if (AAAAA)
                        {
                            for (int i = 0; i < Inven.GetComponent<Invenmaniger>().items.Length; i++)
                            {
                                if (Inven.GetComponent<Invenmaniger>().items[i] == "none")
                                {
                                    Inven.GetComponent<Invenmaniger>().items[i] = Itemname;
                                    Inven.GetComponent<Invenmaniger>().nums[i] += Itemamount;
                                    if (Inven.GetComponent<Invenmaniger>().nums[i] > ItemMax && ItemMax < 90000)
                                    {
                                        Inven.GetComponent<Invenmaniger>().nums[i] = ItemMax;
                                    }
                                    AAAAA = false;
                                    ItemAmount[y] -= Itemamount;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    void Getready()
    {
        amount1 = Player.GetComponent<PlayerHand>().Amount1;
        amount2 = Player.GetComponent<PlayerHand>().Amount2;
        amount3 = Player.GetComponent<PlayerHand>().Amount3;
        amount4 = Player.GetComponent<PlayerHand>().Amount4;
        amount5 = Player.GetComponent<PlayerHand>().Amount5;
        amount6 = Player.GetComponent<PlayerHand>().Amount6;
        amount7 = Player.GetComponent<PlayerHand>().Amount7;
    }

    int Getthingsmax(string itemname)
    {
        if (itemname == "namu")
        {
            return 5000;
        }
        else if (itemname == "doll")
        {
            return 4000;
        }
        else if (itemname == "gogi")
        {
            return 300;
        }
        else if (itemname == "jackMul")
        {
            return 4500;
        }
        else if (itemname == "tangchang")
        {
            return 4500;
        }
        else if (itemname == "chul")
        {
            return 500;
        }
        else if (itemname == "chulgui")
        {
            return 200;
        }
        else if (itemname == "hubipgi")
        {
            return 50;
        }
        else if (itemname == "corepiece")
        {
            return 7000;
        }
        else if (itemname == "suryutang")
        {
            return 200;
        }
        else if (itemname == "C4")
        {
            return 25;
        }
        else if (itemname == "hwal")
        {
            return 99999;
        }
        return 1;
    }

    bool tryDestroys()
    {
        for(int i = 0; i < Items.Length; i++)
        {
            if(Items[i] != "none" && ItemAmount[i] > 0)
            {
                return false;
            }
        }
        return true;
    }
}
