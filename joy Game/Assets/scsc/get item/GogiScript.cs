using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GogiScript : MonoBehaviour
{
    public int Hp = 1;
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

    private string Use_tem;
    private float last_time;
    private bool AAAA;

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
    //public AudioSource audioSource;
    private void Update()
    {
        Use_tem = Cursor.GetComponent<ItemCursor>().Using_Item;
        if (last_time < 10)
        {
            last_time += Time.deltaTime;
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

            AAAA = true;
            if (Player.GetComponent<PlayerHand>().PickUp1 == "gogi" && AAAA)
            {
                if (amount1 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount1 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp2 == "gogi" && AAAA)
            {
                if (amount2 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount2 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp3 == "gogi" && AAAA)
            {
                if (amount3 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount3 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp4 == "gogi" && AAAA)
            {
                if (amount4 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount4 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp5 == "gogi" && AAAA)
            {
                if (amount5 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount5 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp6 == "gogi" && AAAA)
            {
                if (amount6 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount6 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 = 300;
                    }
                    AAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi" && AAAA)
            {
                if (amount7 + 2 <= 300)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount7 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 = 300;
                    }
                    AAAA = false;
                }
            }
            //if(Player.GetComponent<PlayerHand>().PickUp1 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp2 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp3 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp4 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp5 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp6 == "gogi" ||
            //    Player.GetComponent<PlayerHand>().PickUp7 == "gogi")
            //{

            //}
            if (AAAA)
            {
                //Debug.Log("ssssssssssssssssssss");
                if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp1 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount1 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 = 300;
                    }

                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp2 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount2 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 = 300;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp3 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount3 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 300;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp4 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount4 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 = 300;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp5 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount5 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 300;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp6 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount6 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 = 300;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp7 = "gogi";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 2;
                    if (Player.GetComponent<PlayerHand>().Amount7 > 300)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 = 300;
                    }
                }
            }
        }

        if (Hp <= 0)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //GetItem();
        //if (other.gameObject == GameObject.FindGameObjectWithTag("Cursor"))
        //{
        //    if (Input.GetMouseButton(1) && last_time > 0.4f)
        //    {
        //        AAAA = true;
        //        if (Player.GetComponent<PlayerHand>().PickUp1 == "gogi")
        //        {
        //            if (amount1 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount1 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount1 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount1 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //        if (Player.GetComponent<PlayerHand>().PickUp2 == "gogi" && AAAA)
        //        {
        //            if (amount2 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount2 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount2 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount2 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //       if (Player.GetComponent<PlayerHand>().PickUp3 == "gogi" && AAAA)
        //        {
        //            if (amount3 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount3 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount3 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount3 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //            Debug.Log("a");
        //        }
        //        if (Player.GetComponent<PlayerHand>().PickUp4 == "gogi" && AAAA)
        //        {
        //            if (amount4 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount4 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount4 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount4 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //        if (Player.GetComponent<PlayerHand>().PickUp5 == "gogi" && AAAA)
        //        {
        //            if (amount5 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount5 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount5 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount5 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //        if (Player.GetComponent<PlayerHand>().PickUp6 == "gogi" && AAAA)
        //        {
        //            if (amount6 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount6 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount6 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount6 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //        if (Player.GetComponent<PlayerHand>().PickUp7 == "gogi" && AAAA)
        //        {
        //            if (amount7 < 300)
        //            {
        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount7 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount7 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount7 = 300;
        //                }
        //                AAAA = false;
        //                Destroy(gameObject);
        //            }
        //        }
        //        //if(Player.GetComponent<PlayerHand>().PickUp1 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp2 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp3 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp4 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp5 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp6 == "gogi" ||
        //        //    Player.GetComponent<PlayerHand>().PickUp7 == "gogi")
        //        //{

        //        //}
        //        if(AAAA)
        //        {
        //            //Debug.Log("ssssssssssssssssssss");
        //            if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp1 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount1 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount1 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount1 = 300;
        //                }
        //                Destroy(gameObject);

        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp2 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount2 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount2 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount2 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp3 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount3 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount3 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount3 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp4 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount4 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount4 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount4 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp5 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount5 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount5 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount3 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp6 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount6 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount6 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount6 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //            else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
        //            {
        //                Player.GetComponent<PlayerHand>().PickUp7 = "gogi";

        //                Hp -= 1;
        //                Player.GetComponent<PlayerHand>().Amount7 += 2;
        //                if (Player.GetComponent<PlayerHand>().Amount7 > 300)
        //                {
        //                    Player.GetComponent<PlayerHand>().Amount7 = 300;
        //                }
        //                Destroy(gameObject);
        //            }
        //        }
        //    }
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}

