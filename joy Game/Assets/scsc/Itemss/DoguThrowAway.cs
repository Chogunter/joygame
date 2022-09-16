using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoguThrowAway : MonoBehaviour
{
    public GameObject Buildpos;

    //aaaaaaaaaaaaaaaaaaaaaaaaaaa
    public GameObject dollw;
    public GameObject namuw;
    public GameObject gogiw;
    public GameObject dollGockw;
    public GameObject namuGockw;
    public GameObject gumw;
    public GameObject hwalw;

    public GameObject namunamugocckw;
    public GameObject namudollgockw;

    public GameObject jackmul;
    public GameObject jackMulddang;
    public GameObject chong;
    public GameObject tangchang;
    public GameObject chul;
    public GameObject chulgui;
    public GameObject chulGock;
    public GameObject chulnamuGock;
    public GameObject chulgum;
    public GameObject chuldangum;
    public GameObject myomock;
    public GameObject sigea;
    public GameObject chunsajin;
    public GameObject chunsajinmk2;
    public GameObject remover;
    public GameObject greencore;
    public GameObject orangecore;
    public GameObject puplecore;
    public GameObject redcore;
    public GameObject dril;
    public GameObject hubipgi;
    public GameObject corepiece;
    public GameObject gapock;
    public GameObject chongall;
    public GameObject suryutang;
    public GameObject C4;

    public GameObject hwaSalw;
    //aaaaaaaaaaaaaaaaaaaaaaaaaaa
    public bool hwalsalsss;

    private Vector3 posPlayer;
    private Vector3 RealposPlayer;
    private float time;

    public GameObject dongMul;
    private Vector3 pos;
    private int randomx; // -200 ~ 200
    private int randomz;
    private float randomtime = 100f;
    private float time2 = 100;
    public int SangMuls;

    public GameObject Kabe;
    public GameObject chongjang;
    public GameObject badack;
    public GameObject Ulltari;

    public GameObject JackMulDDang;
    public GameObject JeaJackDea;

    public GameObject SangJa;

    public GameObject BuildPosRot;

    public GameObject Kabe_hang;
    public GameObject chongjang_hang;
    public GameObject badack_hang;
    public GameObject Ulltari_hang;

    public GameObject JackMulDDang_hang;
    public GameObject JeaJackDea_hang;

    public GameObject SangJa_hang;

    public float speedwheel;
    public bool FFF;
    private int BBB = 0;

    private int AAA;
    private bool Makes;
    private bool AAAs;
    private int Namud;
    private int Dolld;
    //aaaaaaaaaaaaaaaaaaaaaaaaaaa
    private int Gogid;

    private int Gogis;
    private int Namus;
    private int Dolls;
    private int jackMulddangs;
    private int redcores;
    int chuls;
    int chulguis;
    int jackmuls;

    public GameObject text;
    private float Texttime;
    private bool Textbool = false;

    public GameObject kabefee;
    public GameObject badackfee;
    public GameObject chungjanfee;
    public GameObject UlltariFee;

    public GameObject JackMulDDangFee;
    public GameObject JeaJackDeaFee;

    public GameObject sangJaFee;

    public GameObject buildguide;

    private Vector3 radom3d;

    public GameObject mk1buildpreview;

    public GameObject HwaSalItemw;

    public GameObject BBBCursor;
    public GameObject BBBCursor2;

    int suterulimit;

    public GameObject Tobi;
    public GameObject TobiFee;
    public GameObject Tobi_hang;
    public GameObject Yongwang;
    public GameObject YongwangFee;
    public GameObject Yongwang_hang;
    public GameObject ChimDea;
    public GameObject ChimDea_hang;
    public GameObject ChimDeaFee;
    public GameObject HabSungi;
    public GameObject HabSungi_hang;
    public GameObject HabSungiFee;

    public GameObject mk2buildpreview;

    public GameObject SamGackHyong;
    public GameObject SamGackHyong_Hang;
    public GameObject SamGackHyongFee;
    public GameObject JiBung;
    public GameObject JiBung_hang;
    public GameObject JiBungFee;

    public GameObject Mun;
    public GameObject Mun_hang;
    public GameObject MunFee;

    public GameObject window;
    public GameObject window_hang;
    public GameObject windowFee;
    public GameObject paintbrush;
    public GameObject paintbrush_hang;
    public GameObject paintbrushFee;

    bool Isbuilding;

    public GameObject the;
    public GameObject RedBuildPosRot;

    public bool canBuild = true;
    public int thatBuilding = 0;

    GameObject Player;
    GameObject Cursor;
    GameObjectPool game_object_pool;
    Player_sound_effect AudioManager;

    public KeyCode buildpageopen;
    public KeyCode build;

    bool eat_once;

    ItemCursor CursorItem;
    PlayerHand Hand;
    private void Awake()
    {
        Player = GameObject.Find("Player");
        Hand = Player.GetComponent<PlayerHand>();
        Cursor = GameObject.Find("Cursor Item");
        CursorItem = Cursor.GetComponent<ItemCursor>();
        AudioManager = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();

    }
    void Update()
    {
        Texttime += Time.deltaTime;
        if (CursorItem.Using_Item == "chunsajin")
        {
            thatBuilding = BBB - 1;
            if (BBB > 0)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BBB = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    BBB = 1;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    BBB = 2;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    BBB = 3;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    BBB = 4;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    BBB = 5;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    BBB = 6;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    BBB = 7;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    BBB = 8;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9))
                {
                    BBB = 9;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    BBB = 10;
                }
            }
            if (this.GetComponent<ESC>().IsInputFieldUsing)
            {
                BBB = 0;
            }
            if (Textbool)
            {
                text.SetActive(true);
                //Debug.Log(Texttime.ToString());
                if (Texttime > 1f)
                {
                    text.SetActive(false);
                    Textbool = false;
                }
            }
            if (Input.GetKeyDown(buildpageopen))
            {
                if (!this.GetComponent<ESC>().IsInputFieldUsing)
                {
                    if(BBB == 0)
                    {
                        BBB = 1;
                    }
                    else
                    {
                        BBB = 0;
                    }
                }
                
            }

            if (BBB == 0)
            {
                Isbuilding = false;
                BBBCursor.SetActive(false);
                mk1buildpreview.SetActive(false);
                FFF = false;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 1)
            {
                the.GetComponent<buildposgetrey>().index = 0;
                FFF = true;
                Kabe_hang.SetActive(true);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(true);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 2)
            {
                the.GetComponent<buildposgetrey>().index = 1;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(true);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(true);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 3)
            {
                the.GetComponent<buildposgetrey>().index = 2;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(true);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(true);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 4)
            {
                the.GetComponent<buildposgetrey>().index = 3;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(true);
                SamGackHyongFee.SetActive(true);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 5)
            {
                the.GetComponent<buildposgetrey>().index = 4;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(true);
                JiBung_hang.SetActive(true);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if(BBB == 6)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(true);
                Ulltari_hang.SetActive(true);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 7) // 경작지
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(true);
                JackMulDDang_hang.SetActive(true);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 8) // 제작대
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(true);
                JeaJackDea_hang.SetActive(true);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 9) // 상자
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(true);
                SangJa_hang.SetActive(true);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(false);
                MunFee.SetActive(false);
            }
            else if (BBB == 10)
            {
                the.GetComponent<buildposgetrey>().index = 0;
                FFF = true;
                Kabe_hang.SetActive(false);
                chongjang_hang.SetActive(false);
                badack_hang.SetActive(false);

                kabefee.SetActive(false);
                chungjanfee.SetActive(false);
                badackfee.SetActive(false);

                UlltariFee.SetActive(false);
                Ulltari_hang.SetActive(false);

                JackMulDDangFee.SetActive(false);
                JackMulDDang_hang.SetActive(false);
                JeaJackDeaFee.SetActive(false);
                JeaJackDea_hang.SetActive(false);

                sangJaFee.SetActive(false);
                SangJa_hang.SetActive(false);

                SamGackHyong_Hang.SetActive(false);
                SamGackHyongFee.SetActive(false);
                JiBungFee.SetActive(false);
                JiBung_hang.SetActive(false);

                Mun_hang.SetActive(true);
                MunFee.SetActive(true);
            }
            else
            {
                BBB = 0;
            }

            if(BBB > 0)
            {
                buildguide.SetActive(true);
                //this.GetComponent<PlayerGuide>().Guide_Was_Shown = false;
            }
            else
            {
                buildguide.SetActive(false);
                //this.GetComponent<PlayerGuide>().Guide_Was_Shown = true;
            }

            if (FFF)
            {
                Isbuilding = true;
                BBBCursor.SetActive(true);
                BBBCursor.transform.localPosition = new Vector2(560 + 105 * (BBB-1), -90);
                mk1buildpreview.SetActive(true);
                if (Input.GetKeyDown(build) && canBuild)
                {
                    text.SetActive(false);
                    if (true)
                    {
                        redcores = 0;
                        //dolls
                        if (Hand.PickUp1 == "doll")
                            Dolls += Hand.Amount1;
                        if (Hand.PickUp2 == "doll")
                            Dolls += Hand.Amount2;
                        if (Hand.PickUp3 == "doll")
                            Dolls += Hand.Amount3;
                        if (Hand.PickUp4 == "doll")
                            Dolls += Hand.Amount4;
                        if (Hand.PickUp5 == "doll")
                            Dolls += Hand.Amount5;
                        if (Hand.PickUp6 == "doll")
                            Dolls += Hand.Amount6;
                        if (Hand.PickUp7 == "doll")
                            Dolls += Hand.Amount7;
                        //Namus
                        if (Hand.PickUp1 == "namu")
                            Namus += Hand.Amount1;
                        if (Hand.PickUp2 == "namu")
                            Namus += Hand.Amount2;
                        if (Hand.PickUp3 == "namu")
                            Namus += Hand.Amount3;
                        if (Hand.PickUp4 == "namu")
                            Namus += Hand.Amount4;
                        if (Hand.PickUp5 == "namu")
                            Namus += Hand.Amount5;
                        if (Hand.PickUp6 == "namu")
                            Namus += Hand.Amount6;
                        if (Hand.PickUp7 == "namu")
                            Namus += Hand.Amount7;
                        //Gogis
                        if (Hand.PickUp1 == "gogi")
                            Gogis += Hand.Amount1;
                        if (Hand.PickUp2 == "gogi")
                            Gogis += Hand.Amount2;
                        if (Hand.PickUp3 == "gogi")
                            Gogis += Hand.Amount3;
                        if (Hand.PickUp4 == "gogi")
                            Gogis += Hand.Amount4;
                        if (Hand.PickUp5 == "gogi")
                            Gogis += Hand.Amount5;
                        if (Hand.PickUp6 == "gogi")
                            Gogis += Hand.Amount6;
                        if (Hand.PickUp7 == "gogi")
                            Gogis += Hand.Amount7;
                        //chul
                        if (Hand.PickUp1 == "chul")
                            chuls += Hand.Amount1;
                        if (Hand.PickUp2 == "chul")
                            chuls += Hand.Amount2;
                        if (Hand.PickUp3 == "chul")
                            chuls += Hand.Amount3;
                        if (Hand.PickUp4 == "chul")
                            chuls += Hand.Amount4;
                        if (Hand.PickUp5 == "chul")
                            chuls += Hand.Amount5;
                        if (Hand.PickUp6 == "chul")
                            chuls += Hand.Amount6;
                        if (Hand.PickUp7 == "chul")
                            chuls += Hand.Amount7;
                        //chulgui
                        if (Hand.PickUp1 == "chulgui")
                            chulguis += Hand.Amount1;
                        if (Hand.PickUp2 == "chulgui")
                            chulguis += Hand.Amount2;
                        if (Hand.PickUp3 == "chulgui")
                            chulguis += Hand.Amount3;
                        if (Hand.PickUp4 == "chulgui")
                            chulguis += Hand.Amount4;
                        if (Hand.PickUp5 == "chulgui")
                            chulguis += Hand.Amount5;
                        if (Hand.PickUp6 == "chulgui")
                            chulguis += Hand.Amount6;
                        if (Hand.PickUp7 == "chulgui")
                            chulguis += Hand.Amount7;
                        //jackMul
                        if (Hand.PickUp1 == "jackMul")
                            jackmuls += Hand.Amount1;
                        if (Hand.PickUp2 == "jackMul")
                            jackmuls += Hand.Amount2;
                        if (Hand.PickUp3 == "jackMul")
                            jackmuls += Hand.Amount3;
                        if (Hand.PickUp4 == "jackMul")
                            jackmuls += Hand.Amount4;
                        if (Hand.PickUp5 == "jackMul")
                            jackmuls += Hand.Amount5;
                        if (Hand.PickUp6 == "jackMul")
                            jackmuls += Hand.Amount6;
                        if (Hand.PickUp7 == "jackMul")
                            jackmuls += Hand.Amount7;
                        //경작지
                        if (Hand.PickUp1 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp2 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp3 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp4 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp5 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp6 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp7 == "jackMulddang")
                            jackMulddangs += 1;

                    }
                    if (BBB == 1)
                    {
                        Dolld = 90;
                        Namud = 55;
                        if (Namus >= Namud && Dolls >= Dolld)
                        {
                            Makes = true;
                            if (Hand.PickUp1 == "namu" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Namud)
                                {
                                    Hand.Amount1 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "namu" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;

                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Namud)
                                {
                                    Hand.Amount2 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "namu" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Namud)
                                {
                                    Hand.Amount3 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "namu" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Namud)
                                {
                                    Hand.Amount4 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "namu" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Namud)
                                {
                                    Hand.Amount5 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "namu" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Namud)
                                {
                                    Hand.Amount6 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "namu" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Namud)
                                {
                                    Hand.Amount7 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }////////////////////////////////////Doll
                            Makes = true;
                            AAAs = false;
                            if (Hand.PickUp1 == "doll" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Dolld)
                                {
                                    Hand.Amount1 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "doll" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Dolld)
                                {
                                    Hand.Amount2 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "doll" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Dolld)
                                {
                                    Hand.Amount3 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "doll" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Dolld)
                                {
                                    Hand.Amount4 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "doll" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Dolld)
                                {
                                    Hand.Amount5 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "doll" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Dolld)
                                {
                                    Hand.Amount6 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "doll" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Dolld)
                                {
                                    Hand.Amount7 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }

                            //Instantiate(Kabe, Kabe_hang.transform.position, Kabe_hang.transform.rotation);
                            game_object_pool.Instantiates("kabe", Kabe_hang.transform.position, Kabe_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    else if (BBB == 2)
                    {
                        Dolld = 100;
                        Namud = 75;
                        if (Namus >= Namud && Dolls >= Dolld)
                        {
                            Makes = true;
                            if (Hand.PickUp1 == "namu" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Namud)
                                {
                                    Hand.Amount1 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "namu" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;

                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Namud)
                                {
                                    Hand.Amount2 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "namu" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Namud)
                                {
                                    Hand.Amount3 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "namu" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Namud)
                                {
                                    Hand.Amount4 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "namu" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Namud)
                                {
                                    Hand.Amount5 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "namu" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Namud)
                                {
                                    Hand.Amount6 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "namu" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Namud)
                                {
                                    Hand.Amount7 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }////////////////////////////////////Doll
                            Makes = true;
                            AAAs = false;
                            if (Hand.PickUp1 == "doll" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Dolld)
                                {
                                    Hand.Amount1 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "doll" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Dolld)
                                {
                                    Hand.Amount2 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "doll" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Dolld)
                                {
                                    Hand.Amount3 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "doll" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Dolld)
                                {
                                    Hand.Amount4 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "doll" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Dolld)
                                {
                                    Hand.Amount5 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "doll" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Dolld)
                                {
                                    Hand.Amount6 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "doll" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Dolld)
                                {
                                    Hand.Amount7 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }

                            //Instantiate(badack, badack_hang.transform.position, badack_hang.transform.rotation);
                            game_object_pool.Instantiates("badack", badack_hang.transform.position, badack_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    else if (BBB == 3)
                    {
                        Dolld = 10;
                        Namud = 50;
                        if(Namus >= Namud && Dolls >= Dolld)
                        {
                            Makes = true;
                            if (Hand.PickUp1 == "namu" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Namud)
                                {
                                    Hand.Amount1 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "namu" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;

                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Namud)
                                {
                                    Hand.Amount2 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "namu" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Namud)
                                {
                                    Hand.Amount3 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "namu" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Namud)
                                {
                                    Hand.Amount4 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "namu" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Namud)
                                {
                                    Hand.Amount5 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "namu" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Namud)
                                {
                                    Hand.Amount6 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "namu" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Namud)
                                {
                                    Hand.Amount7 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }////////////////////////////////////Doll
                            Makes = true;
                            AAAs = false;
                            if (Hand.PickUp1 == "doll" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Dolld)
                                {
                                    Hand.Amount1 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "doll" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Dolld)
                                {
                                    Hand.Amount2 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "doll" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Dolld)
                                {
                                    Hand.Amount3 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "doll" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Dolld)
                                {
                                    Hand.Amount4 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "doll" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Dolld)
                                {
                                    Hand.Amount5 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "doll" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Dolld)
                                {
                                    Hand.Amount6 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "doll" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Dolld)
                                {
                                    Hand.Amount7 -= Dolld;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Dolld - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }

                            //Instantiate(chongjang, chongjang_hang.transform.position, chongjang_hang.transform.rotation);
                            game_object_pool.Instantiates("chungjan", chongjang_hang.transform.position, chongjang_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    else if (BBB == 4)
                    {

                        if (Namus >= 20 && Dolls >= 60)
                        {
                            Make(20, 60, 0, 0, 0, 0, 0);
                            //Instantiate(SamGackHyong, SamGackHyong_Hang.transform.position, SamGackHyong_Hang.transform.rotation);
                            game_object_pool.Instantiates("sanmgackhyong", SamGackHyong_Hang.transform.position, SamGackHyong_Hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    else if (BBB == 5)
                    {

                        if (Namus >= 55)
                        {
                            Make(55, 0, 0, 0, 0, 0, 0);
                            //Instantiate(JiBung, JiBung_hang.transform.position, JiBung_hang.transform.rotation);
                            game_object_pool.Instantiates("jibung", JiBung_hang.transform.position, JiBung_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    else if(BBB == 6)
                    {
                        Namud = 105;
                        if(Namus >= Namud)
                        {
                            Makes = true;
                            if (Hand.PickUp1 == "namu" && Makes)
                            {
                                if (Hand.Amount1 > AAA && AAA > 0)
                                {
                                    Hand.Amount1 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount1 > Namud)
                                {
                                    Hand.Amount1 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount1)
                                    {
                                        Hand.Amount1 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp2 == "namu" && Makes)
                            {
                                if (Hand.Amount2 > AAA && AAA > 0)
                                {
                                    Hand.Amount2 -= AAA;
                                    AAA = 0;

                                    Makes = false;
                                }
                                else if (Hand.Amount2 > Namud)
                                {
                                    Hand.Amount2 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount2)
                                    {
                                        Hand.Amount2 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount2;
                                        Hand.Amount2 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp3 == "namu" && Makes)
                            {
                                if (Hand.Amount3 > AAA && AAA > 0)
                                {
                                    Hand.Amount3 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount3 > Namud)
                                {
                                    Hand.Amount3 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount3)
                                    {
                                        Hand.Amount3 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount3;
                                        Hand.Amount3 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp4 == "namu" && Makes)
                            {
                                if (Hand.Amount4 > AAA && AAA > 0)
                                {
                                    Hand.Amount4 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount4 > Namud)
                                {
                                    Hand.Amount4 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount4)
                                    {
                                        Hand.Amount4 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount4;
                                        Hand.Amount4 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp5 == "namu" && Makes)
                            {
                                if (Hand.Amount5 > AAA && AAA > 0)
                                {
                                    Hand.Amount5 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount5 > Namud)
                                {
                                    Hand.Amount5 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount5)
                                    {
                                        Hand.Amount5 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount5;
                                        Hand.Amount5 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp6 == "namu" && Makes)
                            {
                                if (Hand.Amount6 > AAA && AAA > 0)
                                {
                                    Hand.Amount6 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount6 > Namud)
                                {
                                    Hand.Amount6 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount1;
                                        Hand.Amount1 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount6)
                                    {
                                        Hand.Amount6 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount6;
                                        Hand.Amount6 = 0;
                                    }
                                }
                            }
                            if (Hand.PickUp7 == "namu" && Makes)
                            {
                                if (Hand.Amount7 > AAA && AAA > 0)
                                {
                                    Hand.Amount7 -= AAA;
                                    AAA = 0;
                                    Makes = false;
                                }
                                else if (Hand.Amount7 > Namud)
                                {
                                    Hand.Amount7 -= Namud;
                                    Makes = false;
                                }
                                else if (AAA == 0)
                                {
                                    if (!AAAs)
                                    {
                                        AAA = Namud - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                        AAAs = true;
                                    }
                                }
                                else
                                {
                                    if (AAA < Hand.Amount7)
                                    {
                                        Hand.Amount7 -= AAA;
                                        AAA = 0;
                                        Makes = false;
                                    }
                                    else
                                    {
                                        AAA = AAA - Hand.Amount7;
                                        Hand.Amount7 = 0;
                                    }
                                }
                            }
                            //Instantiate(Ulltari, Ulltari_hang.transform.position, Ulltari_hang.transform.rotation);
                            game_object_pool.Instantiates("ultari", Ulltari_hang.transform.position, Ulltari_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    else if(BBB == 7)
                    {
                        if(jackMulddangs >= 1)
                        {
                            if (Hand.PickUp1 == "jackMulddang")
                                Hand.Amount1 -= 1;
                            else if (Hand.PickUp2 == "jackMulddang")
                                Hand.Amount2 -= 1;
                            else if (Hand.PickUp3 == "jackMulddang")
                                Hand.Amount3 -= 1;
                            else if (Hand.PickUp4 == "jackMulddang")
                                Hand.Amount4 -= 1;
                            else if (Hand.PickUp5 == "jackMulddang")
                                Hand.Amount5 -= 1;
                            else if (Hand.PickUp6 == "jackMulddang")
                                Hand.Amount6 -= 1;
                            else if (Hand.PickUp7 == "jackMulddang")
                                Hand.Amount7 -= 1;
                            //Instantiate(JackMulDDang, JackMulDDang_hang.transform.position, JackMulDDang_hang.transform.rotation);
                            game_object_pool.Instantiates("jackmulddang_building", JackMulDDang_hang.transform.position, JackMulDDang_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    else if (BBB == 8)
                    {

                        if (Namus >= 1500)
                        {
                            Make(1500, 0, 0, 0, 0, 0, 0);
                            //Instantiate(JeaJackDea, JeaJackDea_hang.transform.position, JeaJackDea_hang.transform.rotation);
                            game_object_pool.Instantiates("jeajackdea", JeaJackDea_hang.transform.position, JeaJackDea_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    else if(BBB == 9)
                    {
                        
                        if (Namus >= 75 && Dolls >= 40 && Gogis >= 30)
                        {
                            Make(150, 50, 30, 0, 0, 0, 0);
                            //Instantiate(SangJa, SangJa_hang.transform.position, SangJa_hang.transform.rotation);
                            game_object_pool.Instantiates("sangja", SangJa_hang.transform.position, SangJa_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    else if (BBB == 10)
                    {

                        if (Namus >= 50 && Dolls >= 30 && chulguis >= 5)
                        {
                            Make(50, 30, 0, 0, 5, 0, 0);
                            //Instantiate(Mun, Mun_hang.transform.position, Mun_hang.transform.rotation);
                            game_object_pool.Instantiates("mun", Mun_hang.transform.position, Mun_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }

                    }
                    Namus = 0;
                    Dolls = 0;
                    Gogis = 0;
                    chuls = 0;
                    chulguis = 0;
                    jackmuls = 0;
                    jackMulddangs = 0;
                    redcores = 0;
                    //ddddd
                }
                float scroll = Input.GetAxis("Mouse ScrollWheel") * speedwheel;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Buildpos.transform.localPosition += new Vector3(0, 0, scroll / 7);
                    if(Buildpos.transform.localPosition.z > 7)
                    {
                        Buildpos.transform.localPosition = new Vector3(0, 0, 7);
                    }
                    if (Buildpos.transform.localPosition.z < 0)
                    {
                        Buildpos.transform.localPosition = new Vector3(0, 0, 0);
                    }
                }
                else
                {
                    BuildPosRot.transform.Rotate(0, scroll, 0, 0);
                    RedBuildPosRot.transform.Rotate(0, scroll, 0, 0);
                }
            }
        } // 건물
        else if (CursorItem.Using_Item == "chunsajinmk2")
        {
            if (BBB > 0)
            {
                thatBuilding = 9 + BBB;
            }
            else
            {
                thatBuilding = -1;
            }
            Isbuilding = true;
            if (BBB > 0)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BBB = 0;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    BBB = 1;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    BBB = 2;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    BBB = 3;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    BBB = 4;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    BBB = 5;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    BBB = 6;
                }
            }
            if (this.GetComponent<ESC>().IsInputFieldUsing)
            {
                BBB = 0;
            }
            if (Textbool)
            {
                text.SetActive(true);
                //Debug.Log(Texttime.ToString());
                if (Texttime > 1f)
                {
                    text.SetActive(false);
                    Textbool = false;
                }
            }
            if (Input.GetKeyDown(buildpageopen))
            {
                if (!this.GetComponent<ESC>().IsInputFieldUsing)
                {
                    if (BBB == 0)
                    {
                        BBB = 1;
                    }
                    else
                    {
                        BBB = 0;
                    }
                }

            }

            if (BBB == 0)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                Isbuilding = false;
                BBBCursor2.SetActive(false);
                mk2buildpreview.SetActive(false);
                FFF = false;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 1)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                TobiFee.SetActive(true);
                Tobi_hang.SetActive(true);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 2)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(true);
                Yongwang_hang.SetActive(true);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 3)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(true);
                ChimDeaFee.SetActive(true);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 4)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(true);
                HabSungiFee.SetActive(true);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 5)
            {
                the.GetComponent<buildposgetrey>().index = 0;
                FFF = true;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(true);
                windowFee.SetActive(true);
                paintbrushFee.SetActive(false);
                paintbrush_hang.SetActive(false);
            }
            else if (BBB == 6)
            {
                the.GetComponent<buildposgetrey>().index = 99;
                FFF = true;
                TobiFee.SetActive(false);
                Tobi_hang.SetActive(false);
                YongwangFee.SetActive(false);
                Yongwang_hang.SetActive(false);
                ChimDea_hang.SetActive(false);
                ChimDeaFee.SetActive(false);
                HabSungi_hang.SetActive(false);
                HabSungiFee.SetActive(false);

                window_hang.SetActive(false);
                windowFee.SetActive(false);
                paintbrushFee.SetActive(true);
                paintbrush_hang.SetActive(true);
            }
            else
            {
                BBB = 0;
            }

            if (BBB > 0)
            {
                buildguide.SetActive(true);
                //this.GetComponent<PlayerGuide>().Guide_Was_Shown = false;
            }
            else
            {
                buildguide.SetActive(false);
                //this.GetComponent<PlayerGuide>().Guide_Was_Shown = true;
            }

            if (FFF)
            {
                Isbuilding = true;
                BBBCursor2.SetActive(true);
                BBBCursor2.transform.localPosition = new Vector2(560 + 105 * (BBB - 1), -90);
                mk2buildpreview.SetActive(true);
                if (Input.GetKeyDown(build) && canBuild)
                {
                    text.SetActive(false);
                    if (true)
                    {
                        //redcore
                        if (Hand.PickUp1 == "redcore")
                            redcores += Hand.Amount1;
                        if (Hand.PickUp2 == "redcore")
                            redcores += Hand.Amount2;
                        if (Hand.PickUp3 == "redcore")
                            redcores += Hand.Amount3;
                        if (Hand.PickUp4 == "redcore")
                            redcores += Hand.Amount4;
                        if (Hand.PickUp5 == "redcore")
                            redcores += Hand.Amount5;
                        if (Hand.PickUp6 == "redcore")
                            redcores += Hand.Amount6;
                        if (Hand.PickUp7 == "redcore")
                            redcores += Hand.Amount7;
                        //dolls
                        if (Hand.PickUp1 == "doll")
                            Dolls += Hand.Amount1;
                        if (Hand.PickUp2 == "doll")
                            Dolls += Hand.Amount2;
                        if (Hand.PickUp3 == "doll")
                            Dolls += Hand.Amount3;
                        if (Hand.PickUp4 == "doll")
                            Dolls += Hand.Amount4;
                        if (Hand.PickUp5 == "doll")
                            Dolls += Hand.Amount5;
                        if (Hand.PickUp6 == "doll")
                            Dolls += Hand.Amount6;
                        if (Hand.PickUp7 == "doll")
                            Dolls += Hand.Amount7;
                        //Namus
                        if (Hand.PickUp1 == "namu")
                            Namus += Hand.Amount1;
                        if (Hand.PickUp2 == "namu")
                            Namus += Hand.Amount2;
                        if (Hand.PickUp3 == "namu")
                            Namus += Hand.Amount3;
                        if (Hand.PickUp4 == "namu")
                            Namus += Hand.Amount4;
                        if (Hand.PickUp5 == "namu")
                            Namus += Hand.Amount5;
                        if (Hand.PickUp6 == "namu")
                            Namus += Hand.Amount6;
                        if (Hand.PickUp7 == "namu")
                            Namus += Hand.Amount7;
                        //Gogis
                        if (Hand.PickUp1 == "gogi")
                            Gogis += Hand.Amount1;
                        if (Hand.PickUp2 == "gogi")
                            Gogis += Hand.Amount2;
                        if (Hand.PickUp3 == "gogi")
                            Gogis += Hand.Amount3;
                        if (Hand.PickUp4 == "gogi")
                            Gogis += Hand.Amount4;
                        if (Hand.PickUp5 == "gogi")
                            Gogis += Hand.Amount5;
                        if (Hand.PickUp6 == "gogi")
                            Gogis += Hand.Amount6;
                        if (Hand.PickUp7 == "gogi")
                            Gogis += Hand.Amount7;
                        //chul
                        if (Hand.PickUp1 == "chul")
                            chuls += Hand.Amount1;
                        if (Hand.PickUp2 == "chul")
                            chuls += Hand.Amount2;
                        if (Hand.PickUp3 == "chul")
                            chuls += Hand.Amount3;
                        if (Hand.PickUp4 == "chul")
                            chuls += Hand.Amount4;
                        if (Hand.PickUp5 == "chul")
                            chuls += Hand.Amount5;
                        if (Hand.PickUp6 == "chul")
                            chuls += Hand.Amount6;
                        if (Hand.PickUp7 == "chul")
                            chuls += Hand.Amount7;
                        //chulgui
                        if (Hand.PickUp1 == "chulgui")
                            chulguis += Hand.Amount1;
                        if (Hand.PickUp2 == "chulgui")
                            chulguis += Hand.Amount2;
                        if (Hand.PickUp3 == "chulgui")
                            chulguis += Hand.Amount3;
                        if (Hand.PickUp4 == "chulgui")
                            chulguis += Hand.Amount4;
                        if (Hand.PickUp5 == "chulgui")
                            chulguis += Hand.Amount5;
                        if (Hand.PickUp6 == "chulgui")
                            chulguis += Hand.Amount6;
                        if (Hand.PickUp7 == "chulgui")
                            chulguis += Hand.Amount7;
                        //jackMul
                        if (Hand.PickUp1 == "jackMul")
                            jackmuls += Hand.Amount1;
                        if (Hand.PickUp2 == "jackMul")
                            jackmuls += Hand.Amount2;
                        if (Hand.PickUp3 == "jackMul")
                            jackmuls += Hand.Amount3;
                        if (Hand.PickUp4 == "jackMul")
                            jackmuls += Hand.Amount4;
                        if (Hand.PickUp5 == "jackMul")
                            jackmuls += Hand.Amount5;
                        if (Hand.PickUp6 == "jackMul")
                            jackmuls += Hand.Amount6;
                        if (Hand.PickUp7 == "jackMul")
                            jackmuls += Hand.Amount7;
                        //경작지
                        if (Hand.PickUp1 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp2 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp3 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp4 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp5 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp6 == "jackMulddang")
                            jackMulddangs += 1;
                        if (Hand.PickUp7 == "jackMulddang")
                            jackMulddangs += 1;

                    }
                    if(BBB == 1)
                    {
                        if (Namus >= 300 && Gogis >= 200 && jackmuls >= 25)
                        {
                            Make(300, 0, 200, 0, 0, 25, 0);
                            //Instantiate(Tobi, Tobi_hang.transform.position, Tobi_hang.transform.rotation);
                            game_object_pool.Instantiates("toibitong", Tobi_hang.transform.position, Tobi_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    if (BBB == 2)
                    {
                        if (Namus >= 120 && Dolls >= 500 && chuls >= 200)
                        {
                            Make(120, 500, 0, 200, 0, 0, 0);
                            //Instantiate(Yongwang, Yongwang_hang.transform.position, Yongwang_hang.transform.rotation);
                            game_object_pool.Instantiates("yongwanlo", Yongwang_hang.transform.position, Yongwang_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    if (BBB == 3)
                    {
                        if (Namus >= 240 && jackmuls >= 200 && Gogis >= 150)
                        {
                            Make(240, 0, 150, 0, 0, 200, 0);
                            //Instantiate(ChimDea, ChimDea_hang.transform.position, ChimDea_hang.transform.rotation);
                            game_object_pool.Instantiates("chimdea", ChimDea_hang.transform.position, ChimDea_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    if (BBB == 4)
                    {
                        if (Namus >= 500 && chulguis >= 300 && Dolls >= 2500 && redcores >= 2)
                        {
                            Make(500, 2500, 0, 0, 300, 0, 2);
                            //Instantiate(HabSungi, HabSungi_hang.transform.position, HabSungi_hang.transform.rotation);
                            game_object_pool.Instantiates("habsungi", HabSungi_hang.transform.position, HabSungi_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    if (BBB == 5)
                    {
                        if (Namus >= 50 && chulguis >= 20 && redcores >= 1)
                        {
                            Make(50, 0, 0, 0, 20, 0, 1);
                            //Instantiate(window, window_hang.transform.position, window_hang.transform.rotation);
                            game_object_pool.Instantiates("window", window_hang.transform.position, window_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    if (BBB == 6)
                    {
                        if (Namus >= 50)
                        {
                            Make(50, 0, 0, 0, 0, 0, 0);
                            //Instantiate(paintbrush, paintbrush_hang.transform.position, paintbrush_hang.transform.rotation);
                            game_object_pool.Instantiates("paintbrush", paintbrush_hang.transform.position, paintbrush_hang.transform.rotation);
                            AudioManager.Sound("build");
                        }
                        else
                        {
                            Texttime = 0f;
                            Textbool = true;
                        }
                    }
                    Namus = 0;
                    Dolls = 0;
                    Gogis = 0;
                    chuls = 0;
                    chulguis = 0;
                    jackmuls = 0;
                    jackMulddangs = 0;
                    redcores = 0;
                    //ddddd
                }
                float scroll = Input.GetAxis("Mouse ScrollWheel") * speedwheel;
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Buildpos.transform.localPosition += new Vector3(0, 0, scroll / 7);
                    if (Buildpos.transform.localPosition.z > 7)
                    {
                        Buildpos.transform.localPosition = new Vector3(0, 0, 7);
                    }
                    if (Buildpos.transform.localPosition.z < 0)
                    {
                        Buildpos.transform.localPosition = new Vector3(0, 0, 0);
                    }
                }
                else
                {
                    BuildPosRot.transform.Rotate(0, scroll, 0, 0);
                    RedBuildPosRot.transform.Rotate(0, scroll, 0, 0);
                }
            }
        } // 건물
        else
        {
            Isbuilding = false;
            BBB = 0;
        }

        time2 += Time.deltaTime;
        if (SangMuls < 12)
        {
            if (time2 > randomtime)
            {
                randomtime = Random.Range(80f, 160f);
                randomx = Random.Range(-300, 300);
                randomz = Random.Range(-300, 300);
                pos = new Vector3(randomx, -this.transform.position.y, randomz) + this.transform.position;
                if (Vector3.Distance(this.transform.position, pos) > 50)
                {

                    //Instantiate(dongMul, pos, Quaternion.identity);
                    //Instantiate(dongMul, pos + new Vector3(3, 0, 0), Quaternion.identity);
                    //Instantiate(dongMul, pos + new Vector3(-3, 0, 0), Quaternion.identity);
                    //Instantiate(dongMul, pos + new Vector3(0, 0, 3), Quaternion.identity);
                    game_object_pool.Instantiates("sangmul", pos, Quaternion.identity);
                    game_object_pool.Instantiates("sangmul", pos + new Vector3(3, 0, 0), Quaternion.identity);
                    game_object_pool.Instantiates("sangmul", pos + new Vector3(-3, 0, 0), Quaternion.identity);
                    game_object_pool.Instantiates("sangmul", pos + new Vector3(0, 0, 3), Quaternion.identity);
                    //Instantiate(dongMul, pos + new Vector3(0, 0, -3), Quaternion.identity);
                    SangMuls += 4;
                    time2 = 0f;
                }
                else
                {
                    randomx = Random.Range(-200, 200);
                    randomz = Random.Range(-200, 200);
                    pos = new Vector3(randomx, 1, randomz);
                }
            }
        } //동물 스폰

        if (true)
        {
            float rand1 = Random.Range(-0.2f, 0.2f);
            float rand2 = Random.Range(-0.2f, 0.2f);
            float rand3 = Random.Range(-0.2f, 0.2f);
            radom3d = new Vector3(rand1, rand2, rand3);

            if (GameObject.Find("Cursor").transform.position.y < 0.5f)
            {
                posPlayer = GameObject.Find("Cursor").transform.position + new Vector3(0, 1, 0) + radom3d;
            }
            else
            {
                posPlayer = GameObject.Find("Cursor").transform.position + radom3d;
            }
        } //버리는 위치 설정
       
        RealposPlayer = Player.GetComponent<PlayerMover>().pos;

        if (Input.GetMouseButton(0))
        {
            if (CursorItem.Using_Item == "hwal")
            {
                if (this.GetComponent<ESC>().NoorYes)
                {
                    if (time > 0.7f)
                    {
                        hwalsalsss = true;
                        time = 0f;
                        if (CursorItem.Using_Slot == 1)
                        {
                            if (Hand.Amount1 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount1 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 2)
                        {
                            if (Hand.Amount2 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount2 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 3)
                        {
                            if (Hand.Amount3 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount3 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 4)
                        {
                            if (Hand.Amount4 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount4 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 5)
                        {
                            if (Hand.Amount5 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount5 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 6)
                        {
                            if (Hand.Amount6 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount6 -= 1;
                            }
                        }
                        else if (CursorItem.Using_Slot == 7)
                        {
                            if (Hand.Amount7 >= 2)
                            {
                                //Instantiate(hwaSalw, RealposPlayer, Quaternion.identity);
                                game_object_pool.Instantiates("hwasal_shotted2", RealposPlayer, Quaternion.identity);
                                Hand.Amount7 -= 1;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            hwalsalsss = false;
        }

        
        if (CursorItem.Using_Item == "gogi" || CursorItem.Using_Item == "hubipgi")
        {
            if (Input.GetMouseButton(1))
            {
                if (Player.GetComponent<Player_Hp>().PlayerHp < Player.GetComponent<Player_Hp>().ful_hp ||
                        Player.GetComponent<Player_Hp>().Hugi < Player.GetComponent<Player_Hp>().Ful_Hugi ||
                        (CursorItem.Using_Item == "hubipgi" && Player.GetComponent<PlayerMover>().giryock > 0))
                {
                    if (eat_once)
                    {
                        AudioManager.Sound("eat");
                        eat_once = false;
                    }
                    time += Time.deltaTime;
                    if (time > 2f)
                    {
                        if (true)
                        {
                            if (CursorItem.Using_Item == "hubipgi")
                            {
                                if (CursorItem.Using_Slot == 1)
                                {
                                    if (Hand.Amount1 >= 1)
                                    {
                                        Hand.Amount1 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 2)
                                {
                                    if (Hand.Amount2 >= 1)
                                    {
                                        Hand.Amount2 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 3)
                                {
                                    if (Hand.Amount3 >= 1)
                                    {
                                        Hand.Amount3 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 4)
                                {
                                    if (Hand.Amount4 >= 1)
                                    {
                                        Hand.Amount4 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 5)
                                {
                                    if (Hand.Amount5 >= 1)
                                    {
                                        Hand.Amount5 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 6)
                                {
                                    if (Hand.Amount6 >= 1)
                                    {
                                        Hand.Amount6 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 7)
                                {
                                    if (Hand.Amount7 >= 1)
                                    {
                                        Hand.Amount7 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 70;
                                        Player.GetComponent<Player_Hp>().Hugi += 10;
                                        Player.GetComponent<PlayerMover>().energyTimelate = 0;
                                    }
                                }
                            }
                            if (CursorItem.Using_Item == "gogi")
                            {
                                if (CursorItem.Using_Slot == 1)
                                {
                                    if (Hand.Amount1 >= 1)
                                    {
                                        Hand.Amount1 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 2)
                                {
                                    if (Hand.Amount2 >= 1)
                                    {
                                        Hand.Amount2 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 3)
                                {
                                    if (Hand.Amount3 >= 1)
                                    {
                                        Hand.Amount3 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 4)
                                {
                                    if (Hand.Amount4 >= 1)
                                    {
                                        Hand.Amount4 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 5)
                                {
                                    if (Hand.Amount5 >= 1)
                                    {
                                        Hand.Amount5 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 6)
                                {
                                    if (Hand.Amount6 >= 1)
                                    {
                                        Hand.Amount6 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                                else if (CursorItem.Using_Slot == 7)
                                {
                                    if (Hand.Amount7 >= 1)
                                    {
                                        Hand.Amount7 -= 1;
                                        Player.GetComponent<Player_Hp>().PlayerHp += 5;
                                        Player.GetComponent<Player_Hp>().Hugi += 5;
                                    }
                                }
                            }
                        }
                        time = 0f;
                        eat_once = true;
                    }
                }
            }
            else
            {
                AudioManager.Soundoff("eat");
                eat_once = true;
                time = 0;
            }
        }
        if (!this.GetComponent<ESC>().IsInputFieldUsing && !Isbuilding)
        {
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.LeftShift) && suterulimit <= 50)
            {
                suterulimit += 1;
                throwsbundle();
            } //내뿜기
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                suterulimit = 0;
                throwsbundle();
            } //한개씩
        }

        if (Input.GetKey(KeyCode.O))
        {
            if (Input.GetKey(KeyCode.I))
            {
                if (CursorItem.Using_Item == "greencore" ||
                    CursorItem.Using_Item == "orangecore" ||
                    CursorItem.Using_Item == "redcore" ||
                    CursorItem.Using_Item == "puplecore")
                {

                }
                else
                {
                    if (CursorItem.Using_Slot == 1)
                    {
                        Hand.Amount1 = 0;
                    }
                    else if (CursorItem.Using_Slot == 2)
                    {
                        Hand.Amount2 = 0;
                    }
                    else if (CursorItem.Using_Slot == 3)
                    {
                        Hand.Amount3 = 0;
                    }
                    else if (CursorItem.Using_Slot == 4)
                    {
                        Hand.Amount4 = 0;
                    }
                    else if (CursorItem.Using_Slot == 5)
                    {
                        Hand.Amount5 = 0;
                    }
                    else if (CursorItem.Using_Slot == 6)
                    {
                        Hand.Amount6 = 0;
                    }
                    else if (CursorItem.Using_Slot == 7)
                    {
                        Hand.Amount7 = 0;
                    }
                }
            }
        }
    }
    void throwsbundle()
    {
        //throws("namu", 15, namuw, null);
        //throws("doll", 10, dollw, null);
        //throws("gogi", 2, gogiw, null);
        //throws("dollGock", 1, dollGockw, null);
        //throws("namuGock", 1, namuGockw, null);
        //throws("gum", 1, gumw, null);
        //throws("namunamugock", 1, namunamugocckw, null);
        //throws("namudollgock", 1, namudollgockw, null);
        //throws("dril", 1, dril, null);
        //throws("hubipgi", 1, hubipgi, null);
        //throws("corepiece", 1, corepiece, null);
        //throws("gapock", 1, gapock, null);
        //throws("suryutang", 1, suryutang, null);
        //throws("C4", 1, C4, null);
        //throws("jackMul", 1, jackmul, null);
        //throws("jackMulddang", 1, jackMulddang, null);
        //throws("tangchang", 15, tangchang, chongall);
        //throws("chul", 1, chul, null);
        //throws("chulgui", 1, chulgui, null);
        //throws("chulGock", 1, chulGock, null);
        //throws("chulnamuGock", 1, chulnamuGock, null);
        //throws("chulgum", 1, chulgum, null);
        //throws("chuldangum", 1, chuldangum, null);
        //throws("myomock", 1, myomock, null);
        //throws("chunsajin", 1, chunsajin, null);
        //throws("chunsajinmk2", 1, chunsajinmk2, null);
        //throws("remover", 1, remover, null);
        //throws("greencore", 1, greencore, null);
        //throws("orangecore", 1, orangecore, null);
        //throws("puplecore", 1, puplecore, null);
        //throws("redcore", 1, redcore, null);
        //throws("sigea", 1, sigea, null);


        //if (CursorItem.Using_Item == "hwal")
        //{
        //    if (CursorItem.Using_Slot == 1)
        //    {
        //        if (Hand.Amount1 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount1 -= 1;
        //        }
        //        else if (Hand.Amount1 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount1 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 2)
        //    {
        //        if (Hand.Amount2 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount2 -= 1;
        //        }
        //        else if (Hand.Amount2 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount2 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 3)
        //    {
        //        if (Hand.Amount3 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount3 -= 1;
        //        }
        //        else if (Hand.Amount3 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount3 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 4)
        //    {
        //        if (Hand.Amount4 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount4 -= 1;
        //        }
        //        else if (Hand.Amount4 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount4 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 5)
        //    {
        //        if (Hand.Amount5 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount5 -= 1;
        //        }
        //        else if (Hand.Amount5 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount5 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 6)
        //    {
        //        if (Hand.Amount6 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount6 -= 1;
        //        }
        //        else if (Hand.Amount6 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount6 -= 1;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 7)
        //    {
        //        if (Hand.Amount7 == 1)
        //        {
        //            Instantiate(hwalw, posPlayer, Quaternion.identity);
        //            Hand.Amount7 -= 1;
        //        }
        //        else if (Hand.Amount7 > 1)
        //        {
        //            Instantiate(HwaSalItemw, posPlayer, Quaternion.identity);
        //            Hand.Amount7 -= 1;
        //        }
        //    }
        //}
        //if (CursorItem.Using_Item == "chong")
        //{
        //    if (CursorItem.Using_Slot == 1)
        //    {
        //        if (Hand.Amount1 >= 1)
        //        {
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //            Hand.Amount1 = 0;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 2)
        //    {
        //        if (Hand.Amount2 >= 1)
        //        {
        //            Hand.Amount2 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 3)
        //    {
        //        if (Hand.Amount3 >= 1)
        //        {
        //            Hand.Amount3 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 4)
        //    {
        //        if (Hand.Amount4 >= 1)
        //        {
        //            Hand.Amount4 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 5)
        //    {
        //        if (Hand.Amount5 >= 1)
        //        {
        //            Hand.Amount5 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 6)
        //    {
        //        if (Hand.Amount6 >= 1)
        //        {
        //            Hand.Amount6 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //    else if (CursorItem.Using_Slot == 7)
        //    {
        //        if (Hand.Amount7 >= 1)
        //        {
        //            Hand.Amount7 = 0;
        //            var bullet = Instantiate(chong, posPlayer, Quaternion.identity);
        //            bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
        //        }
        //    }
        //}

        throws2("namu", 15, "namu", "namu_small");
        throws2("doll", 10, "doll", "doll_small");
        throws2("gogi", 2, "gogi", "gogi_small");
        throws2("dollGock", 1, "dollgock", null);
        throws2("namuGock", 1, "namugock", null);
        throws2("gum", 1, "gum", null);
        throws2("namunamugock", 1, "namunamugock", null);
        throws2("namudollgock", 1, "namudollgock", null);
        throws2("dril", 1, "dril", null);
        throws2("hubipgi", 1, "hubipgi", null);
        throws2("corepiece", 1, "corepiece", null);
        throws2("gapock", 1, "gapock", null);
        throws2("suryutang", 1, "suryutang", null);
        throws2("C4", 1, "C4", null);
        throws2("jackMul", 1, "jackmulItem", null);
        throws2("jackMulddang", 1, "jackmulddang", null);
        throws2("tangchang", 30, "tangchang", "chongal");
        throws2("chul", 1, "chul", null);
        throws2("chulgui", 1, "chulgui", null);
        throws2("chulGock", 1, "chuldollgock", null);
        throws2("chulnamuGock", 1, "chulnamugock", null);
        throws2("chulgum", 1, "chulgum", null);
        throws2("chuldangum", 1, "chulgum_dangum", null);
        throws2("myomock", 1, "mymock", null);
        throws2("chunsajin", 1, "chungsajin", null);
        throws2("chunsajinmk2", 1, "chungsajinmk2", null);
        throws2("remover", 1, "remover", null);
        throws2("greencore", 1, "greencore", null);
        throws2("orangecore", 1, "orangecore", null);
        throws2("puplecore", 1, "puplecore", null);
        throws2("redcore", 1, "redcore", null);
        throws2("sigea", 1, "sigea", null);

        if (CursorItem.Using_Item == "hwal")
        {
            if (CursorItem.Using_Slot == 1)
            {
                if (Hand.Amount1 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount1 -= 1;
                }
                else if (Hand.Amount1 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount1 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 2)
            {
                if (Hand.Amount2 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount2 -= 1;
                }
                else if (Hand.Amount2 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount2 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 3)
            {
                if (Hand.Amount3 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount3 -= 1;
                }
                else if (Hand.Amount3 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount3 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 4)
            {
                if (Hand.Amount4 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount4 -= 1;
                }
                else if (Hand.Amount4 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount4 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 5)
            {
                if (Hand.Amount5 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount5 -= 1;
                }
                else if (Hand.Amount5 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount5 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 6)
            {
                if (Hand.Amount6 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount6 -= 1;
                }
                else if (Hand.Amount6 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount6 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 7)
            {
                if (Hand.Amount7 == 1)
                {
                    game_object_pool.Instantiates("hwal", posPlayer, Quaternion.identity);
                    Hand.Amount7 -= 1;
                }
                else if (Hand.Amount7 > 1)
                {
                    game_object_pool.Instantiates("hwasal", posPlayer, Quaternion.identity);
                    Hand.Amount7 -= 1;
                }
            }
        }
        if (CursorItem.Using_Item == "chong")
        {
            if (CursorItem.Using_Slot == 1)
            {
                if (Hand.Amount1 >= 1)
                {
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                    Hand.Amount1 = 0;
                }
            }
            else if (CursorItem.Using_Slot == 2)
            {
                if (Hand.Amount2 >= 1)
                {
                    Hand.Amount2 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
            else if (CursorItem.Using_Slot == 3)
            {
                if (Hand.Amount3 >= 1)
                {
                    Hand.Amount3 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
            else if (CursorItem.Using_Slot == 4)
            {
                if (Hand.Amount4 >= 1)
                {
                    Hand.Amount4 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
            else if (CursorItem.Using_Slot == 5)
            {
                if (Hand.Amount5 >= 1)
                {
                    Hand.Amount5 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
            else if (CursorItem.Using_Slot == 6)
            {
                if (Hand.Amount6 >= 1)
                {
                    Hand.Amount6 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
            else if (CursorItem.Using_Slot == 7)
            {
                if (Hand.Amount7 >= 1)
                {
                    Hand.Amount7 = 0;
                    var bullet = game_object_pool.InstantiatesObject("chong", posPlayer, Quaternion.identity);
                    bullet.GetComponent<tangsave>().tang = the.GetComponent<chongshot>().tang;
                }
            }
        }
    }
    //void throws(string itemname, int bigitemamount, GameObject bigone, GameObject smallone)
    //{
    //    if (CursorItem.Using_Item == itemname)
    //    {
    //        if (CursorItem.Using_Slot == 1)
    //        {
    //            if (Hand.Amount1 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount1 -= bigitemamount;
    //            }
    //            else if (Hand.Amount1 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount1 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 2)
    //        {
    //            if (Hand.Amount2 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount2 -= bigitemamount;
    //            }
    //            else if (Hand.Amount2 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount2 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 3)
    //        {
    //            if (Hand.Amount3 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount3 -= bigitemamount;
    //            }
    //            else if (Hand.Amount3 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount3 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 4)
    //        {
    //            if (Hand.Amount4 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount4 -= bigitemamount;
    //            }
    //            else if (Hand.Amount4 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount4 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 5)
    //        {
    //            if (Hand.Amount5 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount5 -= bigitemamount;
    //            }
    //            else if (Hand.Amount5 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount5 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 6)
    //        {
    //            if (Hand.Amount6 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount6 -= bigitemamount;
    //            }
    //            else if (Hand.Amount6 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount6 -= 1;
    //            }
    //        }
    //        else if (CursorItem.Using_Slot == 7)
    //        {
    //            if (Hand.Amount7 >= bigitemamount)
    //            {
    //                Instantiate(bigone, posPlayer, Quaternion.identity);
    //                Hand.Amount7 -= bigitemamount;
    //            }
    //            else if (Hand.Amount7 >= 1 && smallone != null)
    //            {
    //                Instantiate(smallone, posPlayer, Quaternion.identity);
    //                Hand.Amount7 -= 1;
    //            }
    //        }
    //    }
    //}
    void throws2(string itemname, int bigitemamount, string bigone, string smallone)
    {
        if (CursorItem.Using_Item == itemname)
        {
            if (CursorItem.Using_Slot == 1)
            {
                if (Hand.Amount1 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount1 -= bigitemamount;
                }
                else if (Hand.Amount1 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount1 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 2)
            {
                if (Hand.Amount2 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount2 -= bigitemamount;
                }
                else if (Hand.Amount2 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount2 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 3)
            {
                if (Hand.Amount3 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount3 -= bigitemamount;
                }
                else if (Hand.Amount3 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount3 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 4)
            {
                if (Hand.Amount4 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount4 -= bigitemamount;
                }
                else if (Hand.Amount4 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount4 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 5)
            {
                if (Hand.Amount5 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount5 -= bigitemamount;
                }
                else if (Hand.Amount5 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount5 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 6)
            {
                if (Hand.Amount6 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount6 -= bigitemamount;
                }
                else if (Hand.Amount6 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount6 -= 1;
                }
            }
            else if (CursorItem.Using_Slot == 7)
            {
                if (Hand.Amount7 >= bigitemamount)
                {
                    game_object_pool.Instantiates(bigone, posPlayer, Quaternion.identity);
                    Hand.Amount7 -= bigitemamount;
                }
                else if (Hand.Amount7 >= 1 && smallone != null)
                {
                    game_object_pool.Instantiates(smallone, posPlayer, Quaternion.identity);
                    Hand.Amount7 -= 1;
                }
            }
        }
    }
    void Make(int namu, int Doll, int gogi, int chul, int chulgui, int jackmul, int redcore)
    {
        if (true)//(Namus >= namu && Gogis >= gogi && jackmuls >= jackmul && chulguis >= chulgui && chuls >= chul && Dolls >= Doll && redcore >= redcores)
        {
            //Namu
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "namu" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > namu)
                {
                    Hand.Amount1 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "namu" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > namu)
                {
                    Hand.Amount2 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "namu" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > namu)
                {
                    Hand.Amount3 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "namu" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > namu)
                {
                    Hand.Amount4 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "namu" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > namu)
                {
                    Hand.Amount5 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "namu" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > namu)
                {
                    Hand.Amount6 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "namu" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > namu)
                {
                    Hand.Amount7 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //Gogi
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "gogi" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > gogi)
                {
                    Hand.Amount1 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "gogi" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > gogi)
                {
                    Hand.Amount2 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "gogi" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > gogi)
                {
                    Hand.Amount3 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "gogi" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > gogi)
                {
                    Hand.Amount4 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "gogi" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > gogi)
                {
                    Hand.Amount5 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "gogi" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > gogi)
                {
                    Hand.Amount6 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "gogi" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > gogi)
                {
                    Hand.Amount7 -= gogi;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = gogi - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //jackmul
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "jackMul" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > jackmul)
                {
                    Hand.Amount1 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "jackMul" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > jackmul)
                {
                    Hand.Amount2 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "jackMul" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > jackmul)
                {
                    Hand.Amount3 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "jackMul" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > jackmul)
                {
                    Hand.Amount4 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "jackMul" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > jackmul)
                {
                    Hand.Amount5 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "jackMul" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > jackmul)
                {
                    Hand.Amount6 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "jackMul" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > jackmul)
                {
                    Hand.Amount7 -= jackmul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = jackmul - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //chulgui
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "chulgui" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > chulgui)
                {
                    Hand.Amount1 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "chulgui" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > chulgui)
                {
                    Hand.Amount2 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "chulgui" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > chulgui)
                {
                    Hand.Amount3 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "chulgui" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > chulgui)
                {
                    Hand.Amount4 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "chulgui" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > chulgui)
                {
                    Hand.Amount5 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "chulgui" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > chulgui)
                {
                    Hand.Amount6 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "chulgui" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > chulgui)
                {
                    Hand.Amount7 -= chulgui;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chulgui - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //chul
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "chul" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > chul)
                {
                    Hand.Amount1 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "chul" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > chul)
                {
                    Hand.Amount2 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "chul" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > chul)
                {
                    Hand.Amount3 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "chul" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > chul)
                {
                    Hand.Amount4 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "chul" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > chul)
                {
                    Hand.Amount5 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "chul" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > chul)
                {
                    Hand.Amount6 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "chul" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > chul)
                {
                    Hand.Amount7 -= chul;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = chul - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //doll
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "doll" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > Doll)
                {
                    Hand.Amount1 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "doll" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > Doll)
                {
                    Hand.Amount2 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "doll" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > Doll)
                {
                    Hand.Amount3 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "doll" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > Doll)
                {
                    Hand.Amount4 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "doll" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > Doll)
                {
                    Hand.Amount5 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "doll" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > Doll)
                {
                    Hand.Amount6 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "doll" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > Doll)
                {
                    Hand.Amount7 -= Doll;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = Doll - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
            //redcore
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (Hand.PickUp1 == "redcore" && Makes)
            {
                if (Hand.Amount1 > AAA && AAA > 0)
                {
                    Hand.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount1 > redcore)
                {
                    Hand.Amount1 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount1;
                        Hand.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount1)
                    {
                        Hand.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount1;
                        Hand.Amount1 = 0;
                    }
                }
            }
            if (Hand.PickUp2 == "redcore" && Makes)
            {
                if (Hand.Amount2 > AAA && AAA > 0)
                {
                    Hand.Amount2 -= AAA;
                    AAA = 0;

                    Makes = false;
                }
                else if (Hand.Amount2 > redcore)
                {
                    Hand.Amount2 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount2;
                        Hand.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount2)
                    {
                        Hand.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount2;
                        Hand.Amount2 = 0;
                    }
                }
            }
            if (Hand.PickUp3 == "redcore" && Makes)
            {
                if (Hand.Amount3 > AAA && AAA > 0)
                {
                    Hand.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount3 > redcore)
                {
                    Hand.Amount3 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount3;
                        Hand.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount3)
                    {
                        Hand.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount3;
                        Hand.Amount3 = 0;
                    }
                }
            }
            if (Hand.PickUp4 == "redcore" && Makes)
            {
                if (Hand.Amount4 > AAA && AAA > 0)
                {
                    Hand.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount4 > redcore)
                {
                    Hand.Amount4 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount4;
                        Hand.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount4)
                    {
                        Hand.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount4;
                        Hand.Amount4 = 0;
                    }
                }
            }
            if (Hand.PickUp5 == "redcore" && Makes)
            {
                if (Hand.Amount5 > AAA && AAA > 0)
                {
                    Hand.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount5 > redcore)
                {
                    Hand.Amount5 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount5;
                        Hand.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount5)
                    {
                        Hand.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount5;
                        Hand.Amount5 = 0;
                    }
                }
            }
            if (Hand.PickUp6 == "redcore" && Makes)
            {
                if (Hand.Amount6 > AAA && AAA > 0)
                {
                    Hand.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount6 > redcore)
                {
                    Hand.Amount6 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount6;
                        Hand.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount6)
                    {
                        Hand.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount6;
                        Hand.Amount6 = 0;
                    }
                }
            }
            if (Hand.PickUp7 == "redcore" && Makes)
            {
                if (Hand.Amount7 > AAA && AAA > 0)
                {
                    Hand.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (Hand.Amount7 > redcore)
                {
                    Hand.Amount7 -= redcore;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = redcore - Hand.Amount7;
                        Hand.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < Hand.Amount7)
                    {
                        Hand.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - Hand.Amount7;
                        Hand.Amount7 = 0;
                    }
                }
            }
        }
    }
}
