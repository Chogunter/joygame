using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChulScript : MonoBehaviour
{
    public bool isstrong = false;
    public bool iscanget;

    public int Hp;
    [SerializeField] int or_Hp = 1;

    private string items1;
    private string items2;
    private string items3;
    private string items4;
    private string items5;
    private string items6;
    private string items7;

    private int amount1;
    private int amount2;
    private int amount3;
    private int amount4;
    private int amount5;
    private int amount6;
    private int amount7;

    private string Use_Item;
    public float wd = 0.7f;

    private bool AAAAA;

    //public AudioSource audioSource;

    public float LastTime = 0.7f;

    //private void Start()
    //{
    //    AudioSource audioSource = gameObject.AddComponent<AudioSource>();
    //}

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
    void Update()
    {
        Use_Item = Cursor.GetComponent<ItemCursor>().Using_Item;

        if (LastTime < 10)
        {
            LastTime += Time.deltaTime;
        }

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

        if (Use_Item == "dollGock")
        {
            wd = 1.5f;
            iscanget = true;
        }
        else if (Use_Item == "chulGock")
        {
            wd = 0.7f;
            iscanget = true;
        }
        else if (Use_Item == "dril")
        {
            wd = 0.3f;
            iscanget = true;
        }
        else
        {
            if (isstrong)
            {
                iscanget = false;
            }
            else
            {
                iscanget = true;
            }
        }
    }

    public void GetItem()
    {
        if (iscanget)
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
                if (Player.GetComponent<PlayerHand>().PickUp1 == "chul" && AAAAA)
                {
                    if (amount1 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "chul" && AAAAA)
                {
                    if (amount2 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "chul" && AAAAA)
                {
                    if (amount3 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "chul" && AAAAA)
                {
                    if (amount4 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "chul" && AAAAA)
                {
                    if (amount5 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "chul" && AAAAA)
                {
                    if (amount6 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "chul" && AAAAA)
                {
                    if (amount7 < 500)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 500;
                        }
                        AAAAA = false;
                    }
                }
                if (AAAAA)
                {
                    //Debug.Log("돌 칸이 없음");
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 500;
                        }
                        AAAAA = false;

                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 500;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 500;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 500;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 500;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 500;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "chul";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 500)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 500;
                        }
                        AAAAA = false;
                    }
                }
            }
        }
    }
}
