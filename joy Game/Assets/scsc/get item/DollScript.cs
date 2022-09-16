using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollScript: MonoBehaviour
{
    //(끝)playerHand 의 변수를 불러오기 (Player에 넣는다는 정의하에 작성됨)   
    //(끝)그 변수에 doll이 있다면 갯수를 찾기
    //(끝)최대갯수를 고려하여 더하며, 만약 초과하게 될 경우는 hp를 깎지 않게 하기
    //(끝)hp 1에 자원 10씩 더하기
    //(끝)hp가 0이 되면 비활성화 하기

    public bool isstrong = false;
    public bool iscanget;

    public int Hp = 100;
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

        amount1 = Player.GetComponent<PlayerHand>().Amount1;
        amount2 = Player.GetComponent<PlayerHand>().Amount2;
        amount3 = Player.GetComponent<PlayerHand>().Amount3;
        amount4 = Player.GetComponent<PlayerHand>().Amount4;
        amount5 = Player.GetComponent<PlayerHand>().Amount5;
        amount6 = Player.GetComponent<PlayerHand>().Amount6;
        amount7 = Player.GetComponent<PlayerHand>().Amount7;

        if(Hp <= 0)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

        if (Use_Item == "dollGock")
        {
            wd = 0.4f;
            iscanget = true;
        }
        else if (Use_Item == "namudollgock")
        {
            wd = 0.7f;
            iscanget = true;
        }
        else if (Use_Item == "chulGock")
        {
            wd = 0.3f;
            iscanget = true;
        }
        else if (Use_Item == "dril")
        {
            wd = 0.1f;
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
            if (LastTime > wd)
            {
                AAAAA = true;
                //audioSource.Play();
                LastTime = 0;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && AAAAA)
                {
                    if (amount1 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && AAAAA)
                {
                    if (amount2 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && AAAAA)
                {
                    if (amount3 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && AAAAA)
                {
                    if (amount4 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && AAAAA)
                {
                    if (amount5 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && AAAAA)
                {
                    if (amount6 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && AAAAA)
                {
                    if (amount7 + 10 <= 4000)
                    {
                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 4000;
                        }
                        AAAAA = false;
                    }
                }
                if (AAAAA)
                {
                    //Debug.Log("돌 칸이 없음");
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount1 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 4000;
                        }
                        AAAAA = false;
                        Debug.Log("eeeeeeeeeeeeeeeeee");

                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount2 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 4000;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount3 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 4000;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount4 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 4000;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount5 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 4000;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount6 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 4000;
                        }
                        AAAAA = false;
                    }
                    else if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "doll";

                        Hp -= 1;
                        Player.GetComponent<PlayerHand>().Amount7 += 10;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 4000)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 4000;
                        }
                        AAAAA = false;
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
        //        GetItem();
                //if(LastTime > wd)
                //{
                //    AAAAA = true;
                //    //audioSource.Play();
                //    LastTime = 0;
                //    if (Player.GetComponent<PlayerHand>().PickUp1 == "doll" && AAAAA)
                //    {
                //        if (amount1 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount1 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount1 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp2 == "doll" && AAAAA)
                //    {
                //        if (amount2 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount2 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount2 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp3 == "doll" && AAAAA)
                //    {
                //        if (amount3 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount3 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount3 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp4 == "doll" && AAAAA)
                //    {
                //        if (amount4 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount4 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount4 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp5 == "doll" && AAAAA)
                //    {
                //        if (amount5 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount5 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount5 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp6 == "doll" && AAAAA)
                //    {
                //        if (amount6 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount6 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount6 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if (Player.GetComponent<PlayerHand>().PickUp7 == "doll" && AAAAA)
                //    {
                //        if (amount7 < 4000)
                //        {
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount7 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount7 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount7 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //    if(AAAAA)
                //    {
                //        //Debug.Log("돌 칸이 없음");
                //        if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp1 = "doll";
                            
                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount1 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount1 = 4000;
                //            }
                //            AAAAA = false;
                //            Debug.Log("eeeeeeeeeeeeeeeeee");
                            
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp2 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount2 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount2 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp3 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount3 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount3 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp4 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount4 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount4 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp5 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount5 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount5 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp6 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount6 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount6 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp7 = "doll";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount7 += 10;
                //            if (Player.GetComponent<PlayerHand>().Amount7 > 4000)
                //            {
                //                Player.GetComponent<PlayerHand>().Amount7 = 4000;
                //            }
                //            AAAAA = false;
                //        }
                //    }
                //}
            //}
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
