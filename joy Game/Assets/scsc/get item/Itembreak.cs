using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Itembreak : MonoBehaviour
{
    RaycastHit hit;
    float MaxDistance = 5f;

    public GameObject JackMul;
    public GameObject Myomock;
    public GameObject JeaJack;
    public GameObject ToiBi;
    public GameObject Yongwang;
    public GameObject SangJa;
    public GameObject Yongwangd;
    public GameObject Habsung;
    public GameObject AdvancedBench;
    public GameObject EnemyDeal;
    public EnemyDealChoose EnemyDeal_chooser;

    public int Yongwangtimed = 1;

    private float time;
    private float time2212;
    float time1101;
    float time_item_get;
    public int anyintthing; // 제작대 : 1   퇴비통 : 2   용광로 : 3  ect.

    bool s = true;

    GameObject Player;
    GameObject Cursor;
    GameObject Enpty;
    float timebuilding;
    public GameObject Chimdeaclickeffectebebevevebeebvevev;

    [SerializeField]  float[] timess; //4
    GameObject AudioManeger;

    GameObject DigParticleManager;
    Dig_Particles_cs Diger;

    // Start is called before the first frame update

    GameObjectPool gameobjectpool;
    void Start()
    {
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        Enpty = GameObject.Find("Enpty");
        AudioManeger = GameObject.Find("Player_sound");
        DigParticleManager = GameObject.Find("dig_Particles");

        gameobjectpool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Diger = DigParticleManager.GetComponent<Dig_Particles_cs>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < timess.Length; i++)
        {
            timess[i] += Time.deltaTime;
        }
        if (Player.GetComponent<ESC>().anyint % 2 == 1 &&
            !Player.GetComponent<Player_Hp>().IsDie)
        {
            if (anyintthing == 1)
            {
                JeaJack.SetActive(true);
            }
            else if(anyintthing == 2)
            {
                ToiBi.SetActive(true);
            }
            else if (anyintthing == 3)
            {
                Yongwang.SetActive(true);
            }
            else if (anyintthing == 4)
            {
                SangJa.SetActive(true);

            }
            else if (anyintthing == 5)
            {
                Habsung.SetActive(true);
            }
            else if (anyintthing == 6)
            {
                AdvancedBench.SetActive(true);
            }
            else if (anyintthing == 7)
            {
                EnemyDeal.SetActive(true);
            }
        }
        else
        {
            JeaJack.SetActive(false);
            ToiBi.SetActive(false);
            Habsung.SetActive(false);
            AdvancedBench.SetActive(false);
            EnemyDeal.SetActive(false);
            if (anyintthing == 3)
            {
                GameObject.Find("Hwa Sal Pyo (1)").GetComponent<yongwangmaker>().Save();
                Yongwang.SetActive(false);
            }
            if(anyintthing == 4)
            {
                GameObject.Find("SangJa").GetComponent<Sangjascript>().ItemSave();
                SangJa.SetActive(false);
                s = true;
            }
            anyintthing = 0;
        }
        time2212 += Time.deltaTime;
        time += Time.deltaTime;
        time1101 += Time.deltaTime;
        timebuilding += Time.deltaTime;
        time_item_get += Time.deltaTime;
        if (canGetKey.IsESCturnedon)
        {
            return;
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
        {
            Debug.DrawRay(transform.position, transform.forward * MaxDistance, Color.blue, 0.3f);
            if (Input.GetMouseButton(1) && !Player.GetComponent<Player_Hp>().IsDie)
            {
                //Debug.Log(hit.collider.tag);
                if (hit.collider.tag == "Item Dogu")
                {
                    if (hit.transform.gameObject.GetComponent<chonglitem>())
                    {
                        hit.transform.gameObject.GetComponent<chonglitem>().GetItem();
                    }
                    else
                    {
                        hit.transform.gameObject.GetComponent<DoguThrow>().GetItem();
                    }
                }
                else if (hit.collider.tag == "Item Doll")
                {
                    if (hit.transform.gameObject.GetComponent<DollScript>().iscanget)
                    {
                        hit.transform.gameObject.GetComponent<DollScript>().GetItem();
                        if (hit.transform.gameObject.GetComponent<DollScript>().Hp > 1 || true)
                        {
                            if (timess[1] > hit.transform.gameObject.GetComponent<DollScript>().wd)
                            {
                                Diger.Particle(hit.point, "doll");
                                Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.2f);
                                AudioManeger.GetComponent<Player_sound_effect>().Soundoff("dolldig");
                                AudioManeger.GetComponent<Player_sound_effect>().Sound("dolldig");
                                timess[1] = 0;
                            }
                        }
                    }
                }
                else if (hit.collider.tag == "Item Gogi")
                {
                    hit.transform.gameObject.GetComponent<GogiScript>().GetItem();
                }
                else if (hit.collider.tag == "Item Namu")
                {
                    hit.transform.gameObject.GetComponent<NamuScript>().GetItem();
                    if (hit.transform.gameObject.GetComponent<NamuScript>().Hp > 1 || true)
                    {
                        if (timess[0] > hit.transform.gameObject.GetComponent<NamuScript>().ws)
                        {
                            Diger.Particle(hit.point, "namu");
                            Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.2f);
                            AudioManeger.GetComponent<Player_sound_effect>().Soundoff("namuchop");
                            AudioManeger.GetComponent<Player_sound_effect>().Sound("namuchop");
                            timess[0] = 0;
                        }
                    }
                }
                else if (hit.collider.tag == "Item Hwal")
                {
                    hit.transform.gameObject.GetComponent<HwalThrow>().GetItem();
                }
                else if (hit.collider.tag == "Item chul")
                {
                    if (hit.transform.gameObject.GetComponent<ChulScript>().iscanget)
                    {
                        hit.transform.gameObject.GetComponent<ChulScript>().GetItem();

                        if (hit.transform.gameObject.GetComponent<ChulScript>().Hp > 1 || true)
                        {
                            if (timess[2] > hit.transform.gameObject.GetComponent<ChulScript>().wd)
                            {
                                Diger.Particle(hit.point, "chul");
                                Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.2f);
                                AudioManeger.GetComponent<Player_sound_effect>().Soundoff("dolldig");
                                AudioManeger.GetComponent<Player_sound_effect>().Sound("dolldig");
                                timess[2] = 0;
                            }
                        }
                        else if (hit.transform.gameObject.GetComponent<ChulScript>().Hp <= 1)
                        {
                            //AudioManeger.GetComponent<Player_sound_effect>().Sound("pop");
                        }
                    }
                }
                else if (hit.collider.tag == "ItemItem")
                {

                    hit.transform.gameObject.GetComponent<ItemItemItemsss>().GetItem();
                }
                else if (hit.collider.tag == "tuchuck")
                {
                    if (hit.collider.GetComponent<ItemItemItemsss>())
                    {
                        hit.transform.gameObject.GetComponent<ItemItemItemsss>().GetItem();
                    }
                }
                else if (hit.collider.tag == "JackMulpos" && time > 0.1f)
                {
                    if(Cursor.GetComponent<ItemCursor>().Using_Item == "jackMul")
                    {
                        if (hit.transform.gameObject.GetComponent<JackMulDDangasda>().sss)
                        {
                            hit.transform.gameObject.GetComponent<JackMulDDangasda>().sss = false;
                            //Instantiate(JackMul, hit.transform.position + new Vector3(0f, 0.2f, 0f), hit.transform.rotation);
                            gameobjectpool.Instantiates("jackmul1", hit.transform.position + new Vector3(0f, 0.2f, 0f), hit.transform.rotation);
                            if (Player.GetComponent<PlayerHand>().PickUp1 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount1 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp2 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount2 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp3 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount3 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp4 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount4 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp5 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount5 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp6 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount6 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp7 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount7 -= 1;
                        }
                    }
                }
                else if ((hit.collider.tag == "ground" || hit.collider.tag == "JackmulDDang") && time > 0.1f)
                {
                    if (GameObject.Find("Cursor Item").GetComponent<ItemCursor>().Using_Item == "myomock")
                    {
                        if (true)
                        {
                            //Instantiate(Myomock, hit.point, Quaternion.identity);
                            gameobjectpool.Instantiates("the_mymock", hit.point, Quaternion.identity);
                            if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
                                Player.GetComponent<PlayerHand>().Amount1 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
                                Player.GetComponent<PlayerHand>().Amount2 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
                                Player.GetComponent<PlayerHand>().Amount3 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
                                Player.GetComponent<PlayerHand>().Amount4 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
                                Player.GetComponent<PlayerHand>().Amount5 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
                                Player.GetComponent<PlayerHand>().Amount6 -= 1;
                            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
                                Player.GetComponent<PlayerHand>().Amount7 -= 1;
                        }
                    }
                }

                if (Cursor.GetComponent<ItemCursor>().Using_Item == "remover" && time2212 > 0.4f)
                {
                    if ((hit.collider.tag == "Sangja" &&
                        !hit.collider.gameObject.GetComponent<SangJJasaveandload>().Isdontbreak) ||
                        hit.collider.tag == "habsungi" ||
                        hit.collider.tag == "yongwang" || hit.collider.tag == "chimdea" ||
                        hit.collider.tag == "toibi" || hit.collider.tag == "JeaJack" ||
                        hit.collider.tag == "build" || hit.collider.tag == "Mun" || hit.collider.tag == "badack" ||
                        hit.collider.tag == "JackmulDDang"
                        || hit.collider.tag == "paintbrush")
                    {
                        Enpty.GetComponent<CameraMover>().screen_shake(0.3f, 0.5f);
                        hit.collider.gameObject.SetActive(false);
                        time2212 = 0f;
                    }
                }
                else if (hit.collider.tag == "JeaJack" && time2212 > 1f)
                    {
                        time2212 = 0f;
                        Player.GetComponent<ESC>().anyint += 1;
                        anyintthing = 1;
                    }
                else if(hit.collider.tag == "toibi" && time2212 > 1f)
                    {
                        time2212 = 0f;
                        Player.GetComponent<ESC>().anyint += 1;
                        anyintthing = 2;
                    }
                else if (hit.collider.tag == "habsungi" && time2212 > 1f)
                {
                    time2212 = 0f;
                    Player.GetComponent<ESC>().anyint += 1;
                    anyintthing = 5;
                }
                else if (hit.collider.tag == "yongwang" && time2212 > 1f)
                    {
                        Yongwangd.GetComponent<yongwangmaker>().that = hit.transform.gameObject;
                        Yongwangd.GetComponent<yongwangmaker>().Load();
                        time2212 = 0f;
                        if (hit.collider.gameObject.GetComponent<Yongwangd>().timed == 0)
                        {
                            GameObject.Find("yongwangLotime").GetComponent<yongwanglotime>().time.Add(0f);
                            hit.collider.gameObject.GetComponent<Yongwangd>().timed = Yongwangtimed;
                            Yongwangtimed += 1;
                        }
                        Player.GetComponent<ESC>().anyint += 1;
                        anyintthing = 3;
                    }
                else if (hit.collider.tag == "Sangja" && time2212 > 1f)
                {
                    time2212 = 0f;
                    if (Player.GetComponent<ESC>().anyint % 2 == 0)
                    {
                        AudioManeger.GetComponent<Player_sound_effect>().Soundoff("chest");
                        AudioManeger.GetComponent<Player_sound_effect>().Sound("chest");
                    }

                    Player.GetComponent<ESC>().anyint += 1;
                    SangJa.GetComponent<Sangjascript>().SangJa = hit.collider.gameObject;
                    anyintthing = 4;
                }
                else if (hit.collider.tag == "chimdea" && time2212 > 1f)
                {
                    time2212 = 0f;
                    //Player.GetComponent<Player_Hp>().responepos = hit.transform.position;
                    //Chimdeaclickeffectebebevevebeebvevev.SetActive(true);
                }
                else if (hit.collider.tag == "Mun")
                {
                    hit.collider.gameObject.GetComponent<Munscript>().Opentry();
                }
                else if (hit.collider.tag == "paintbrush")
                {
                    hit.collider.gameObject.GetComponent<paintbrushBuilding>().ChangeColor(Cursor.GetComponent<ItemCursor>().Using_Item);
                }
                else if (hit.collider.tag == "advancedbench" && time2212 > 1f)
                {
                    time2212 = 0f;
                    Player.GetComponent<ESC>().anyint += 1;
                    anyintthing = 6;
                }

                if (hit.collider.tag == "Enemy" && 
                    enemypartys.CheckTeam(enemypartys.friend.name, hit.collider.GetComponent<Enemymove>().Party) == "team" &&
                     !hit.collider.GetComponent<Enemymove>().isPlayerTeam && time2212 > 1f)
                {
                    time2212 = 0f;
                    Player.GetComponent<ESC>().anyint += 1;
                    EnemyDeal_chooser.ResetDealItem(hit.collider.GetComponent<Enemymove>().DealItemList, hit.collider.GetComponent<Enemymove>());
                    anyintthing = 7;
                }

                else if (hit.collider.tag == "SangMul" && time2212 > 0.5f)
                {
                    time2212 = 0f;
                    if (true)
                    {
                        if (Cursor.GetComponent<ItemCursor>().Using_Item == "jackMul")
                        {
                            hit.transform.gameObject.GetComponent<SangMul>().Guild();
                            if (Player.GetComponent<PlayerHand>().PickUp1 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount1 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp2 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount2 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp3 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount3 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp4 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount4 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp5 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount5 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp6 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount6 -= 1;
                            else if (Player.GetComponent<PlayerHand>().PickUp7 == "jackMul")
                                Player.GetComponent<PlayerHand>().Amount7 -= 1;
                        }
                    }
                }
                else if (hit.collider.tag == "DiedMuckUm" && time2212 > 0.6f)
                {
                    time2212 = 0f;
                    hit.collider.gameObject.GetComponent<PlayerDiedMuckUm>().GetItem();
                }

                if (hit.collider.tag == "Vehicle")
                {
                    Enpty.GetComponent<CameraMover>().screen_shake(0.1f, 0.2f);
                    hit.collider.gameObject.GetComponent<getonVehicle>().Geton();
                }
            }
            if (Input.GetMouseButton(0) && !Player.GetComponent<Player_Hp>().IsDie && anyintthing == 0)
            {
                if (hit.collider.tag == "JackMul2")
                {
                    hit.transform.gameObject.GetComponent<JackMulscript>().GetJackMul();
                }
                else if (hit.collider.tag == "SangMul")
                {
                    if (timess[3] > hit.collider.GetComponent<SangMul>().timesdwds)
                    {
                        Diger.Particle(hit.point, "blood");
                        Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.1f);
                        //AudioManeger.GetComponent<Player_sound_effect>().Soundoff("punch");
                        AudioManeger.GetComponent<Player_sound_effect>().Sound("punch");
                        timess[3] = 0;
                    }
                    hit.transform.gameObject.GetComponent<SangMul>().Ahit();
                }
                else if (hit.collider.tag == "Monsters")
                {
                    if (timess[4] > hit.collider.GetComponent<monsterscript>().timesdwds)
                    {
                        Diger.Particle(hit.point, "blood");
                        Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.1f);
                        AudioManeger.GetComponent<Player_sound_effect>().Sound("punch");
                        timess[4] = 0;
                    }
                    hit.transform.gameObject.GetComponent<monsterscript>().Ahit();
                }
                else if (hit.collider.tag == "boss")
                {
                    if (hit.transform.gameObject.GetComponent<close_boss>())
                    {
                        if (timess[5] > hit.collider.GetComponent<close_boss>().timesdwds)
                        {
                            Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.1f);
                            AudioManeger.GetComponent<Player_sound_effect>().Sound("punch");
                            timess[5] = 0;
                        }
                        hit.transform.gameObject.GetComponent<close_boss>().Ahit();
                    }
                    else if (hit.transform.gameObject.GetComponent<long_boss>())
                    {
                        if (timess[6] > hit.collider.GetComponent<long_boss>().timesdwds)
                        {
                            Enpty.GetComponent<CameraMover>().screen_shake(0.21f, 0.1f);
                            AudioManeger.GetComponent<Player_sound_effect>().Sound("punch");
                            timess[6] = 0;
                        }
                        hit.transform.gameObject.GetComponent<long_boss>().Ahit();
                    }
                }
                else if (hit.collider.tag == "Enemy")
                {
                    if (timess[7] > hit.collider.GetComponent<Enemymove>().timesdwds)
                    {
                        Diger.Particle(hit.point, "blood");
                        Enpty.GetComponent<CameraMover>().screen_shake(0.2f, 0.1f);
                        AudioManeger.GetComponent<Player_sound_effect>().Sound("punch");
                        timess[7] = 0;
                    }
                    hit.transform.gameObject.GetComponent<Enemymove>().Ahit();
                }
                else if (hit.collider.tag == "Item Dogu" && hit.collider.GetComponent<redcoretopiece>() && time1101 > 0.5f)
                {
                    Enpty.GetComponent<CameraMover>().screen_shake(0.3f, 0.1f);
                    AudioManeger.GetComponent<Player_sound_effect>().Soundoff("dolldig");
                    AudioManeger.GetComponent<Player_sound_effect>().Sound("dolldig");
                    int hitdam = 1;
                    hit.collider.GetComponent<redcoretopiece>().hp -= hitdam;
                    time1101 = 0;
                }
                else if (hit.collider.GetComponent<Buildingbreak>() && timebuilding > 1f)
                {
                    Diger.Particle(hit.point, "doll");
                    Enpty.GetComponent<CameraMover>().screen_shake(0.1f, 0.1f);
                    AudioManeger.GetComponent<Player_sound_effect>().Soundoff("dolldig");
                    AudioManeger.GetComponent<Player_sound_effect>().Sound("dolldig");
                    hit.collider.GetComponent<Buildingbreak>().originhit();
                    timebuilding = 0;
                }
            }
        }
    }
}
