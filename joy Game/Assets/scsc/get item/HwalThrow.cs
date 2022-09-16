using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HwalThrow : MonoBehaviour
{
    //(끝)playerHand 의 변수를 불러오기 (Player에 넣는다는 정의하에 작성됨)   
    //(끝)그 변수에 doll이 있다면 갯수를 찾기
    //(끝)최대갯수를 고려하여 더하며, 만약 초과하게 될 경우는 hp를 깎지 않게 하기
    //(끝)hp 1에 자원 10씩 더하기
    //(끝)hp가 0이 되면 비활성화 하기

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

    private string Use_Item;
    private float wd = 0.7f;

    //public AudioSource audioSource;

    public float LastTime = 0.7f;

    public bool ishwal;

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
    }

    public void GetItem()
    {
        if(LastTime > wd)
        {
            amount1 = Player.GetComponent<PlayerHand>().Amount1;
            amount2 = Player.GetComponent<PlayerHand>().Amount2;
            amount3 = Player.GetComponent<PlayerHand>().Amount3;
            amount4 = Player.GetComponent<PlayerHand>().Amount4;
            amount5 = Player.GetComponent<PlayerHand>().Amount5;
            amount6 = Player.GetComponent<PlayerHand>().Amount6;
            amount7 = Player.GetComponent<PlayerHand>().Amount7;
            LastTime = 0;
            if (ishwal)
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp1 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 1;

                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp2 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp3 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp4 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp5 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp6 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp7 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 1;
                }
            }
            else
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "hwal")
                {
                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 1;
                }
            }
        }
        if (false && LastTime > wd)
        {
            //audioSource.Play();
            LastTime = 0;
            if (Player.GetComponent<PlayerHand>().PickUp1 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount1 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp2 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount2 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp3 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount3 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp4 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount4 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp5 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount5 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp6 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount6 += 1;
            }
            else if (Player.GetComponent<PlayerHand>().PickUp7 == "hwal")
            {
                Hp -= 1;
                Player.GetComponent<PlayerHand>().Amount7 += 1;
            }
            else // 빈칸일 경우
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp1 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 1;

                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp2 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp3 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp4 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp5 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp6 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 1;
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp7 = "hwal";

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 1;
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
                //if (LastTime > wd)
                //{
                //    //audioSource.Play();
                //    LastTime = 0;
                //    if (Player.GetComponent<PlayerHand>().PickUp1 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount1 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp2 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount2 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp3 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount3 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp4 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount4 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp5 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount5 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp6 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount6 += 1;
                //    }
                //    else if (Player.GetComponent<PlayerHand>().PickUp7 == "hwal")
                //    {
                //        Hp -= 1;
                //        Player.GetComponent<PlayerHand>().Amount7 += 1;
                //    }
                //    else // 빈칸일 경우
                //    {
                //        //Debug.Log("돌 칸이 없음");
                //        if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp1 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 1;

                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp2 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp3 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp4 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp5 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp6 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp7 = "hwal";

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount7 += 1;
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
