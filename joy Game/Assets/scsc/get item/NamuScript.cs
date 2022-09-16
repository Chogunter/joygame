using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamuScript : MonoBehaviour
{
    public int Hp = 40;
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
    public float ws = 0.6f;

    private bool AAAAAA;

    //public AudioSource audioSource;

    public float LastTime = 0.4f;

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
        Use_tem = Cursor.GetComponent<ItemCursor>().Using_Item;
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

        if(Use_tem == "namuGock")
        {
            ws = 0.3f;
        }
        else if(Use_tem == "namunamugock")
        {
            ws = 0.45f;
        }
        else if (Use_tem == "chulnamuGock")
        {
            ws = 0.15f;
        }
        else if (Use_tem == "dril")
        {
            ws = 0.05f;
        }
        else
        {
            ws = 0.6f;
        }
    }

    public void GetItem()
    {
        if (LastTime > ws)
        {
            amount1 = Player.GetComponent<PlayerHand>().Amount1;
            amount2 = Player.GetComponent<PlayerHand>().Amount2;
            amount3 = Player.GetComponent<PlayerHand>().Amount3;
            amount4 = Player.GetComponent<PlayerHand>().Amount4;
            amount5 = Player.GetComponent<PlayerHand>().Amount5;
            amount6 = Player.GetComponent<PlayerHand>().Amount6;
            amount7 = Player.GetComponent<PlayerHand>().Amount7;
            AAAAAA = true;
            //audioSource.Play();
            LastTime = 0;
            if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && AAAAAA)
            {
                if (amount1 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount1 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp2 == "namu" && AAAAAA)
            {
                if (amount2 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount2 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp3 == "namu" && AAAAAA)
            {
                if (amount3 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount3 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp4 == "namu" && AAAAAA)
            {
                if (amount4 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount4 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp5 == "namu" && AAAAAA)
            {
                if (amount5 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount5 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp6 == "namu" && AAAAAA)
            {
                if (amount6 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount6 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp7 == "namu" && AAAAAA)
            {
                if (amount7 + 15 <= 5000)
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount7 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 = 5000;
                    }
                    AAAAAA = false;
                }
            }
            if (AAAAAA)
            {
                //Debug.Log("돌 칸이 없음");
                if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp1 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount1 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 = 5000;
                    }
                    Debug.Log("eeeeeeeeeeeeeeeeee");

                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp2 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount2 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 = 5000;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp3 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount3 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 5000;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp4 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount4 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 = 5000;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp5 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount5 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 = 5000;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp6 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount6 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 = 5000;
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp7 = "namu";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 15;
                    if (Player.GetComponent<PlayerHand>().Amount7 > 5000)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 = 5000;
                    }
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {

        //}
        //private void OnTriggerEnter(Collider other)
        //{
        //if (other.gameObject == GameObject.FindGameObjectWithTag("Cursor"))
        //{
        //    if (Input.GetMouseButton(1))
        //    {
                //GetItem();
                //if (LastTime > ws)
                //{
                //    AAAAAA = true;
                //    //audioSource.Play();
                //    LastTime = 0;
                //    if (Player.GetComponent<PlayerHand>().PickUp1 == "namu" && AAAAAA)
                //    {
                //        if (amount1 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount1 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount1 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp2 == "namu" && AAAAAA)
                //    {
                //        if (amount2 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount2 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount2 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp3 == "namu" && AAAAAA)
                //    {
                //        if (amount3 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount3 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount3 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp4 == "namu" && AAAAAA)
                //    {
                //        if (amount4 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount4 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount4 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp5 == "namu" && AAAAAA)
                //    {
                //        if (amount5 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount5 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount5 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp6 == "namu" && AAAAAA)
                //    {
                //        if (amount6 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount6 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount6 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp7 == "namu" && AAAAAA)
                //    {
                //        if (amount7 < 5000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount7 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount7 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount7 = 5000;
                //            }
                //            AAAAAA = false;
                //        }
                //    }
                //    if(AAAAAA)
                //    {
                //        //Debug.Log("돌 칸이 없음");
                //        if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp1 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount1 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount1 = 5000;
                //            }
                //            Debug.Log("eeeeeeeeeeeeeeeeee");

                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp2 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount2 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount2 = 5000;
                //            }
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp3 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount3 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount3 = 5000;
                //            }
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp4 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount4 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount4 = 5000;
                //            }
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp5 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount5 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount3 = 5000;
                //            }
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp6 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount6 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount6 = 5000;
                //            }
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp7 = "namu";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount7 += 15;
                //            if (Player.GetComponent<PlayerHand>().Amount7 > 5000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount7 = 5000;
                //            }
                //        }
                //    }
                //}
        //    }
        //}
    }
    private void OnTriggerExit(Collider other)
    {

    }
}
