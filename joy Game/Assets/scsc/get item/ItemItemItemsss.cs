using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemItemItemsss : MonoBehaviour
{
    public int Itemamount;
    public string Itemname;
    public int ItemMax;

    public bool isstrong = false;

    public int Hp = 100;
    [SerializeField] int or_Hp = 1;

    private int amount1;
    private int amount2;
    private int amount3;
    private int amount4;
    private int amount5;
    private int amount6;
    private int amount7;

    private float wd = 0.7f;

    private bool AAAAA;

    //public AudioSource audioSource;

    public float LastTime = 0.7f;

    GameObject Player;
    GameObject Cursor;
    private void Awake()
    {
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
    }

    private void OnEnable()
    {
        for (int i = 0; i < Loading_Manager.NeedToBeCalled.Count; i++)
        {
            if (Loading_Manager.NeedToBeCalled[i] == gameObject)
            {
                Loading_Manager.NeedToBeCalled[i] = null;
                return;
            }
        }
        Hp = or_Hp;
    }

    //private void Start()
    //{
    //    AudioSource audioSource = gameObject.AddComponent<AudioSource>();
    //}

    void Update()
    {
        //Use_Item = Cursor.GetComponent<ItemCursor>().Using_Item;
        LastTime += Time.deltaTime;

        //items1 = Player.GetComponent<PlayerHand>().PickUp1;
        //items2 = Player.GetComponent<PlayerHand>().PickUp2;
        //items3 = Player.GetComponent<PlayerHand>().PickUp3;
        //items4 = Player.GetComponent<PlayerHand>().PickUp4;
        //items5 = Player.GetComponent<PlayerHand>().PickUp5;
        //items6 = Player.GetComponent<PlayerHand>().PickUp6;
        //items7 = Player.GetComponent<PlayerHand>().PickUp7;

        if (Hp <= 0)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    public void GetItem()
    {
        if (true)
        {
            amount1 = Player.GetComponent<PlayerHand>().Amount1;
            amount2 = Player.GetComponent<PlayerHand>().Amount2;
            amount3 = Player.GetComponent<PlayerHand>().Amount3;
            amount4 = Player.GetComponent<PlayerHand>().Amount4;
            amount5 = Player.GetComponent<PlayerHand>().Amount5;
            amount6 = Player.GetComponent<PlayerHand>().Amount6;
            amount7 = Player.GetComponent<PlayerHand>().Amount7;
            if (LastTime > wd)
            {
                AAAAA = true;
                //audioSource.Play();
                LastTime = 0;
                if (Player.GetComponent<PlayerHand>().PickUp1 == Itemname && AAAAA)
                {
                    if (amount1 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount1 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == Itemname && AAAAA)
                {
                    if (amount2 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount2 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == Itemname && AAAAA)
                {
                    if (amount3 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount3 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == Itemname && AAAAA)
                {
                    if (amount4 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount4 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == Itemname && AAAAA)
                {
                    if (amount5 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount5 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == Itemname && AAAAA)
                {
                    if (amount6 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount6 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == Itemname && AAAAA)
                {
                    if (amount7 + Itemamount <= ItemMax)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount7 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
                if (AAAAA)
                {
                    //Debug.Log("돌 칸이 없음");
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount1 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = ItemMax;
                        }
                        AAAAA = false;
                        //Debug.Log("eeeeeeeeeeeeeeeeee");

                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount2 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = ItemMax;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount3 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = ItemMax;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount4 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = ItemMax;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount5 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = ItemMax;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount6 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = ItemMax;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = Itemname;

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += Itemamount;
                        if (Player.GetComponent<PlayerHand>().Amount7 > ItemMax)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = ItemMax;
                        }
                        AAAAA = false;
                    }
                }
            }
        }
    }
}
