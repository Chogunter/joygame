using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCursor : MonoBehaviour
{
    public int Using_Slot = 0;
    public string Using_Item;

    public List<GameObject> soneh;

    public float speedwheel;
    private float scroll = 3;

    public GameObject cores;

    bool asas = true;
    int b;

    GameObject Player;
    Player_sound_effect AudioManeger;

    void Start()
    {
        transform.localPosition = new Vector3(-170, -70, 0);// + new Vector3(279.5f, 146.5f, 0) + new Vector3(-22, 0, 0);

        Player = GameObject.Find("Player");
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();

        time = 8;
    }

    float time;
    int getmouse;

    void Update()
    {
        if (asas)
        {
            cores.SetActive(true);
            asas = false;
        }
        if (Using_Item == "none")
        {
            b = 1;
            //none.SetActive(true);
            //doll.SetActive(false);
            //gum.SetActive(false);
            //dollGock.SetActive(false);
            //namuGock.SetActive(false);
            //hwal.SetActive(false);
            //gogi.SetActive(false);
            //namu.SetActive(false);

            //namunamugock.SetActive(false);
            //namudollgock.SetActive(false);
        }
        else if (Using_Item == "doll")
            b = 0;
        else if (Using_Item == "gum")
            b = 2;
        else if (Using_Item == "dollGock")
            b = 3;
        else if (Using_Item == "namuGock")
            b = 4;
        else if (Using_Item == "hwal")
            b = 5;
        else if (Using_Item == "gogi")
            b = 6;
        else if (Using_Item == "namu")
            b = 7;
        else if (Using_Item == "namunamugock")
            b = 8;
        else if (Using_Item == "namudollgock")
            b = 9;
        else if (Using_Item == "jackMul")
            b = 10;
        else if (Using_Item == "jackMulddang")
            b = 11;
        else if (Using_Item == "chong")
            b = 12;
        else if (Using_Item == "tangchang")
            b = 13;
        else if (Using_Item == "chul")
            b = 14;
        else if (Using_Item == "chulgui")
            b = 15;
        else if (Using_Item == "chulGock")
            b = 16;
        else if (Using_Item == "chulnamuGock")
            b = 17;
        else if (Using_Item == "chulgum")
            b = 18;
        else if (Using_Item == "chuldangum")
            b = 19;
        else if (Using_Item == "myomock")
            b = 20;
        else if (Using_Item == "sigea")
            b = 21;
        else if (Using_Item == "chunsajin")
            b = 22;
        else if (Using_Item == "chunsajinmk2")
            b = 23;
        else if (Using_Item == "remover")
            b = 24;
        else if (Using_Item == "greencore")
            b = 25;
        else if (Using_Item == "orangecore")
            b = 26;
        else if (Using_Item == "puplecore")
            b = 27;
        else if (Using_Item == "redcore")
            b = 28;
        else if (Using_Item == "dril")
            b = 29;
        else if (Using_Item == "hubipgi")
            b = 30;
        else if (Using_Item == "corepiece")
            b = 31;
        else if (Using_Item == "gapock")
            b = 32;
        else if (Using_Item == "suryutang")
            b = 33;
        else if (Using_Item == "C4")
            b = 34;

        for (int i = 0; i < soneh.Count; i++)
        {
            if (i == b)
                soneh[i].SetActive(true);
            else
                soneh[i].SetActive(false);
        }

        ///////////////////////////////////////////new Vector3(279.5, 146.5, 0)
        if (Using_Slot == 1)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp1;
        }
        else if (Using_Slot == 2)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp2;
        }
        else if (Using_Slot == 3)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp3;
        }
        else if (Using_Slot == 4)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp4;
        }
        else if (Using_Slot == 5)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp5;
        }
        else if (Using_Slot == 6)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp6;
        }
        else if (Using_Slot == 7)
        {
            Using_Item = Player.GetComponent<PlayerHand>().PickUp7;
        }
        ///////////////////////////////////////////////////

        if (Using_Item == "dril")
        {
            time += Time.deltaTime;
            if (Input.GetMouseButton(0) && getmouse == 0) getmouse = 1;
            if (Input.GetMouseButton(1) && getmouse == 0) getmouse = 2;
            if (Input.GetMouseButton(1) && Input.GetMouseButton(1)) getmouse = 3;
            if (!(Input.GetMouseButton(0) || Input.GetMouseButton(1))) getmouse = 0;

            if (getmouse == 1 || getmouse == 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    time = 6.5f;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_1");
                }
                if (time > 7.5f && Input.GetMouseButton(0))
                {
                    time = 0;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_2");
                }
                if (Input.GetMouseButtonUp(0))
                {
                    time = 8;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_3");
                }
            }

            if (getmouse == 3 || getmouse == 0)
            {
                if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
                {
                    time = 6.5f;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_1");
                }
                if (time > 7.5f && getmouse == 3)
                {
                    time = 0;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_2");
                }
                if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
                {
                    time = 8;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_3");
                }
            }

            if (getmouse == 2 || getmouse == 0)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    time = 6.5f;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_1");
                }
                if (time > 7.5f && Input.GetMouseButton(1))
                {
                    time = 0;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_2");
                }
                if (Input.GetMouseButtonUp(1))
                {
                    time = 8;
                    AudioManeger.Soundoff("drill_1");
                    AudioManeger.Soundoff("drill_2");
                    AudioManeger.Soundoff("drill_3");
                    AudioManeger.Sound("drill_3");
                }
            }
        }
        else
        {
            if (time < 8)
            {
                AudioManeger.Soundoff("drill_1");
                AudioManeger.Soundoff("drill_2");
                AudioManeger.Sound("drill_3");
            }
            time = 8;
        }

        //////////////////////////////////////////////
        if (!Player.GetComponent<DoguThrowAway>().FFF)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                scroll = 3;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                scroll = 5;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                scroll = 7;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                scroll = 9;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                scroll = 11;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                scroll = 13;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                scroll = 15;
            }
        }
        
        if (Player.GetComponent<DoguThrowAway>().FFF)
        {

        }
        else
        {
            scroll -= Input.GetAxis("Mouse ScrollWheel") * speedwheel;
            if(scroll > 18)
            {
                scroll = 3;
            }
            else if (scroll > 16)
            {
                scroll = 3;
            }
            else if (scroll > 14)
            {
                Using_Slot = 7;
                transform.localPosition = new Vector3(155, -70, 0);
            }
            else if (scroll > 12)
            {
                Using_Slot = 6;
                transform.localPosition = new Vector3(100, -70, 0);
            }
            else if (scroll > 10)
            {
                Using_Slot = 5;
                transform.localPosition = new Vector3(45, -70, 0);
            }
            else if (scroll > 8)
            {
                Using_Slot = 4;
                transform.localPosition = new Vector3(-10, -70, 0);
            }
            else if (scroll > 6)
            {
                Using_Slot = 3;
                transform.localPosition = new Vector3(-65, -70, 0);
            }
            else if (scroll > 4)
            {
                Using_Slot = 2;
                transform.localPosition = new Vector3(-120, -70, 0);
            }
            else if (scroll > 2)
            {
                Using_Slot = 1;
                transform.localPosition = new Vector3(-170, -70, 0);
            }
            else if(scroll < 2)
            {
                scroll = 15;
            }
        }
        ////////////////////////////////////////////////
    }
}
