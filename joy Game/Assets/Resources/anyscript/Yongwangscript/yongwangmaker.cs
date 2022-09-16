using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yongwangmaker : MonoBehaviour
{
    public Slider scrol;
    public GameObject bar;

    public int yoyoyoyoyoyo;

    public float time;
    public float needtime;

    private int chulguis;
    private int Namus;
    private int chulguid;
    private int Namud;

    private float barvalue;

    private int amount1;
    private int amount2;
    private int amount3;
    private int amount4;
    private int amount5;
    private int amount6;
    private int amount7;

    int AAA;
    bool AAAAA;

    private int chulguir;

    public GameObject that;
    public int thattime;

    GameObject Player;
    GameObject yongwangLotime;
    void Start()
    {
        Player = GameObject.Find("Player");
        yongwangLotime = GameObject.Find("yongwangLotime");
    }

    public void Load()
    {
        yoyoyoyoyoyo = that.GetComponent<Yongwangd>().yoyoyoyooyoyo;
        thattime = that.GetComponent<Yongwangd>().timed;
    }
    public void Save()
    {
        that.GetComponent<Yongwangd>().yoyoyoyooyoyo = yoyoyoyoyoyo;
    }

    void Update()
    {
        this.GetComponent<Yongwangchooser>().kaikaikitan = chulguir;
        scrol.value = barvalue;
        this.GetComponent<Yongwangchooser>().kai = yoyoyoyoyoyo;
        barvalue = time / needtime;
        if (yoyoyoyoyoyo >= 1)
        {
            //time = yongwangLotime.GetComponent<yongwanglotime>().time[thattime];
            time = that.GetComponent<Yongwangd>().timelate;
            if (time >= needtime)
            {
                yoyoyoyoyoyo -= 1;
                chulguir += 1;
                //yongwangLotime.GetComponent<yongwanglotime>().time[thattime] -= needtime;
                that.GetComponent<Yongwangd>().timelate -= needtime;
            }
        }
        else
        {
            //yongwangLotime.GetComponent<yongwanglotime>().time[thattime] = 0f;
            that.GetComponent<Yongwangd>().timelate = 0;
        }
        //if (yongwangLotime.GetComponent<yongwanglotime>().time[thattime] == 0f)
        //{
        //    bar.SetActive(false);
        //}
        if (that.GetComponent<Yongwangd>().timelate == 0f)
        {
            bar.SetActive(false);
        }
        else
        {
            bar.SetActive(true);
        }

        if (chulguir >= 1)
        {
            if (Player.GetComponent<PlayerHand>().PickUp1 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp2 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp3 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp4 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp5 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp6 == "none" ||
                Player.GetComponent<PlayerHand>().PickUp7 == "none" ||
                (Player.GetComponent<PlayerHand>().PickUp1 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount1 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp2 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount2 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp3 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount3 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp4 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount4 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp5 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount5 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp6 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount6 < 200) ||
                (Player.GetComponent<PlayerHand>().PickUp7 == "chulgui" &&
                Player.GetComponent<PlayerHand>().Amount7 < 200))
            {
                Make();
                chulguir -= 1;
            }
        }
    }

    public void Onclick()
    {
        if (true) // 나무
        {
            //Namus
            if (Player.GetComponent<PlayerHand>().PickUp1 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "namu")
                Namus += Player.GetComponent<PlayerHand>().Amount7;
        }
        if (true)
        {
            //chul
            if (Player.GetComponent<PlayerHand>().PickUp1 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount1;
            if (Player.GetComponent<PlayerHand>().PickUp2 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount2;
            if (Player.GetComponent<PlayerHand>().PickUp3 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount3;
            if (Player.GetComponent<PlayerHand>().PickUp4 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount4;
            if (Player.GetComponent<PlayerHand>().PickUp5 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount5;
            if (Player.GetComponent<PlayerHand>().PickUp6 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount6;
            if (Player.GetComponent<PlayerHand>().PickUp7 == "chul")
                chulguis += Player.GetComponent<PlayerHand>().Amount7;
        }
        
        if (Namus >= 2 && chulguis >= 2)
        {
            time = 0;
            yoyoyoyoyoyo += 1;
            Namud = 2;
            chulguid = 2;
            if(Player.GetComponent<PlayerHand>().PickUp1 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount1 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount1 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount1 -= 1;
                    Namud -= 1;
                }
            }
            if(Player.GetComponent<PlayerHand>().PickUp2 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount2 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount2 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount2 -= 1;
                    Namud -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp3 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount3 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount3 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount3 -= 1;
                    Namud -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp4 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount4 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount4 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount4 -= 1;
                    Namud -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp5 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount5 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount5 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount5 -= 1;
                    Namud -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp6 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount6 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount6 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount6 -= 1;
                    Namud -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp7 == "namu" && Namud > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount7 >= Namud)
                {
                    Player.GetComponent<PlayerHand>().Amount7 -= Namud;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount7 -= 1;
                    Namud -= 1;
                }
            }

            if (Player.GetComponent<PlayerHand>().PickUp1 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount1 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount1 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount1 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp2 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount2 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount2 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount2 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp3 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount3 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount3 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount3 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp4 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount4 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount4 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount4 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp5 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount5 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount5 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount5 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp6 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount6 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount6 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount6 -= 1;
                    chulguid -= 1;
                }
            }
            if (Player.GetComponent<PlayerHand>().PickUp7 == "chul" && chulguid > 0)
            {
                if (Player.GetComponent<PlayerHand>().Amount7 >= chulguid)
                {
                    Player.GetComponent<PlayerHand>().Amount7 -= chulguid;
                }
                else
                {
                    Player.GetComponent<PlayerHand>().Amount7 -= 1;
                    chulguid -= 1;
                }
            }
        }
        Namus = 0;
        chulguis = 0;
    }

    void Make()
    {
        amount1 = Player.GetComponent<PlayerHand>().Amount1;
        amount2 = Player.GetComponent<PlayerHand>().Amount2;
        amount3 = Player.GetComponent<PlayerHand>().Amount3;
        amount4 = Player.GetComponent<PlayerHand>().Amount4;
        amount5 = Player.GetComponent<PlayerHand>().Amount5;
        amount6 = Player.GetComponent<PlayerHand>().Amount6;
        amount7 = Player.GetComponent<PlayerHand>().Amount7;
        if (Player.GetComponent<PlayerHand>().PickUp1 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp2 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp3 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp4 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp5 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp6 == "none" ||
            Player.GetComponent<PlayerHand>().PickUp7 == "none" ||
            (Player.GetComponent<PlayerHand>().PickUp1 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount1 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp2 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount2 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp3 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount3 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp4 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount4 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp5 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount5 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp6 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount6 < 200) ||
            (Player.GetComponent<PlayerHand>().PickUp7 == "chulgui" &&
            Player.GetComponent<PlayerHand>().Amount7 < 200))
        {
            if (true)
            {
                play_record_info.Item_Make_Record.AddRecorder("chulgui", 1);
                AAAAA = true;
                if (Player.GetComponent<PlayerHand>().PickUp1 == "chulgui" && AAAAA)
                {
                    if (amount1 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp2 == "chulgui" && AAAAA)
                {
                    if (amount2 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp3 == "chulgui" && AAAAA)
                {
                    if (amount3 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp4 == "chulgui" && AAAAA)
                {
                    if (amount4 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp5 == "chulgui" && AAAAA)
                {
                    if (amount5 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp6 == "chulgui" && AAAAA)
                {
                    if (amount6 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (Player.GetComponent<PlayerHand>().PickUp7 == "chulgui" && AAAAA)
                {
                    if (amount7 < 200)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 200;
                        }
                        AAAAA = false;
                    }
                }
                if (AAAAA)
                {

                    if (Player.GetComponent<PlayerHand>().PickUp1 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp1 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount1 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount1 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount1 = 200;
                        }
                        AAAAA = false;

                    }
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp2 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount2 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount2 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount2 = 200;
                        }
                        AAAAA = false;
                    }
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp3 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount3 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount3 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount3 = 200;
                        }
                        AAAAA = false;
                    }
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp4 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount4 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount4 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount4 = 200;
                        }
                        AAAAA = false;
                    }
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp5 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount5 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount5 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount5 = 200;
                        }
                        AAAAA = false;
                    }
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp6 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount6 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount6 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount6 = 200;
                        }
                        AAAAA = false;
                    }
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "none" && AAAAA)
                    {
                        Player.GetComponent<PlayerHand>().PickUp7 = "chulgui";

                        Player.GetComponent<PlayerHand>().Amount7 += 1;
                        if (Player.GetComponent<PlayerHand>().Amount7 > 200)
                        {
                            Player.GetComponent<PlayerHand>().Amount7 = 200;
                        }
                        AAAAA = false;
                    }
                }
            }
        }
    }

    public void cancle()
    {

    }


}
