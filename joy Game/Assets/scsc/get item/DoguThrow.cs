using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoguThrow : MonoBehaviour
{
    public int Hp = 1;
    int or_Hp = 1;

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
    private float ws = 0.6f;

    public string The_Dogu;

    bool Isthischong = false;

    //public AudioSource audioSource;

    public float LastTime = 0.6f;

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

        //amount1 = Player.GetComponent<PlayerHand>().Amount1;
        //amount2 = Player.GetComponent<PlayerHand>().Amount2;
        //amount3 = Player.GetComponent<PlayerHand>().Amount3;
        //amount4 = Player.GetComponent<PlayerHand>().Amount4;
        //amount5 = Player.GetComponent<PlayerHand>().Amount5;
        //amount6 = Player.GetComponent<PlayerHand>().Amount6;
        //amount7 = Player.GetComponent<PlayerHand>().Amount7;

        if (Hp <= 0)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    public void GetItem()
    {
        if (LastTime > ws)
        {
            //audioSource.Play();
            LastTime = 0;
            if (false)
            {

            }
            else
            {
                if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp1 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount1 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp2 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount2 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp3 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount3 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp4 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount4 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp5 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount5 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp6 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount6 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
                    }
                }
                else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                {
                    Player.GetComponent<PlayerHand>().PickUp7 = The_Dogu;

                    Hp -= 1;
                    Player.GetComponent<PlayerHand>().Amount7 += 1;
                    if (Isthischong)
                    {
                        GameObject.Find("Enpty").GetComponent<chongshot>().Loadtang(this.GetComponent<tangsave>().tang);
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
                //if (LastTime > ws)
                //{
                //    //audioSource.Play();
                //    LastTime = 0;
                //    if (false)
                //    {

                //    }
                //    else 
                //    {
                //        if (Player.GetComponent<PlayerHand>().PickUp1 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp1 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount1 += 1;

                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp2 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp2 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount2 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp3 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp3 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount3 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp4 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp4 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount4 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp5 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp5 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount5 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp6 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp6 = The_Dogu;

                //            Hp -= 1;
                //            Player.GetComponent<PlayerHand>().Amount6 += 1;
                //        }
                //        else if (Player.GetComponent<PlayerHand>().PickUp7 == "none")
                //        {
                //            Player.GetComponent<PlayerHand>().PickUp7 = The_Dogu;

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
