using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chongshot : MonoBehaviour
{
    RaycastHit hit;
    GameObject Player;
    GameObject Cursor;
    GameObject cam;
    public int tang = 0;
    [SerializeField] int Max_tang = 15;
    int tanchang;
    float MaxDistance = 600;
    float shuttingtime;
    float reloadingtime;
    bool reloading;
    [SerializeField] private Text text;
    [SerializeField] private GameObject tangUI;
    [SerializeField] private GameObject chongDogu;
    Vector3 Dogupos;
    Camera mainCamera;
    [SerializeField] float eeeeeee;
    bool sss;
    float Mousegamdo;
    Vector3 target;
    [SerializeField] float tanperjim;
    float tanperjimreal;

    [SerializeField] GameObject chongal;
    [SerializeField] float speed;
    [SerializeField] int dam;
    [SerializeField] float shutlatetime;

    GameObject AudioManager;

    bool adgfwdauyfwyuvgc;

    int tnaghp;
    int tnaghp_maxtang;

    GameObject Enpty;
    [SerializeField] ParticleSystem particle;
    float particletime;

    GameObjectPool game_object_pool;

    void Start()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        cam = GameObject.Find("Main Camera");
        AudioManager = GameObject.Find("Player_sound");
        Enpty = GameObject.Find("Enpty");
        mainCamera = cam.GetComponent<Camera>();
        Dogupos = chongDogu.transform.localPosition;
        eeeeeee = PlayerSettings.VideoSetting.ViewingAngle;//mainCamera.fieldOfView;
        Mousegamdo = Player.GetComponent<PlayerOption>().Moussegamdo;
        tanperjimreal = tanperjim;
        particletime = shutlatetime;
    }

    void Update()
    {
        particletime += Time.deltaTime;
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong")
        {
            if (particle.isPlaying && particletime > shutlatetime)
            {
                particle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
                particletime = 0;
            }
            if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
            {
                tang = Player.GetComponent<PlayerHand>().Amount1 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
            {
                tang = Player.GetComponent<PlayerHand>().Amount2 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
            {
                tang = Player.GetComponent<PlayerHand>().Amount3 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
            {
                tang = Player.GetComponent<PlayerHand>().Amount4 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
            {
                tang = Player.GetComponent<PlayerHand>().Amount5 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
            {
                tang = Player.GetComponent<PlayerHand>().Amount6 - 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
            {
                tang = Player.GetComponent<PlayerHand>().Amount7 - 1;
            }
        }
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong")
        {
            sss = true;
            if (tang <= 0)
            {
                reloading = true;
            }
            text.text = tang.ToString() + "  /  " + Max_tang.ToString();
            tangUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R) && tang < Max_tang && !reloading)
            {
                AudioManager.GetComponent<Player_sound_effect>().Sound("reloading");
                reloading = true;
            }
            if (Input.GetMouseButton(0))
            {
                if (tang <= 0)
                {
                    reloading = true;
                }
                else
                {
                    shuttingtime += Time.deltaTime;
                }
            }
            else
            {
                shuttingtime = 0;
            }
            if (Input.GetMouseButton(1) && !reloading)
            {
                chongDogu.transform.localPosition = new Vector3(-1f, -1.27f, 1.44f);
                mainCamera.fieldOfView = eeeeeee / 2;
                Player.GetComponent<PlayerOption>().Moussegamdo = Mousegamdo / 3;
                tanperjimreal = tanperjim / 2;
            }
            else
            {
                chongDogu.transform.localPosition = Dogupos;
                mainCamera.fieldOfView = eeeeeee;
                Player.GetComponent<PlayerOption>().Moussegamdo = Mousegamdo;
                tanperjimreal = tanperjim;
            }
            if (reloading)
            {
                if (adgfwdauyfwyuvgc)
                {
                    if (true)
                    {
                        if (Player.GetComponent<PlayerHand>().PickUp1 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount1;
                        if (Player.GetComponent<PlayerHand>().PickUp2 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount2;
                        if (Player.GetComponent<PlayerHand>().PickUp3 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount3;
                        if (Player.GetComponent<PlayerHand>().PickUp4 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount4;
                        if (Player.GetComponent<PlayerHand>().PickUp5 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount5;
                        if (Player.GetComponent<PlayerHand>().PickUp6 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount6;
                        if (Player.GetComponent<PlayerHand>().PickUp7 == "tangchang")
                            tanchang += Player.GetComponent<PlayerHand>().Amount7;
                    } // 탄창갯수
                    if (tanchang >= 1)
                    {
                        AudioManager.GetComponent<Player_sound_effect>().Sound("reloading");
                    }
                    else
                    {
                        reloading = false;
                    }
                    tanchang = 0;
                    adgfwdauyfwyuvgc = false;
                }
                if(Cursor.GetComponent<ItemCursor>().Using_Item != "chong")
                {
                    reloading = false;
                }
            }
            else
            {
                adgfwdauyfwyuvgc = true;
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("reloading");
            }
        }
        else
        {
            adgfwdauyfwyuvgc = true;
            AudioManager.GetComponent<Player_sound_effect>().Soundoff("reloading");
            if (Player.GetComponent<PlayerHand>().PickUp1 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp2 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp3 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp4 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp5 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp6 == "chong" ||
               Player.GetComponent<PlayerHand>().PickUp7 == "chong")
            {

            }
            if (sss)
            {
                tangUI.SetActive(false);
                reloadingtime = 0;
                reloading = false;
                shuttingtime = 0;
                mainCamera.fieldOfView = eeeeeee;
                sss = false;
            }
        }
        if (reloading)
        {
            if (Input.GetMouseButtonDown(0) && !(tang <= 0))
            {
                reloadingtime = 0;
                reloading = false;
            }
            reloadingtime += Time.deltaTime;
            if (reloadingtime > 2.5f)
            {
                reloading = false;
                tanchang = 0;
                if (true)
                {
                    if (Player.GetComponent<PlayerHand>().PickUp1 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount1;
                    if (Player.GetComponent<PlayerHand>().PickUp2 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount2;
                    if (Player.GetComponent<PlayerHand>().PickUp3 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount3;
                    if (Player.GetComponent<PlayerHand>().PickUp4 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount4;
                    if (Player.GetComponent<PlayerHand>().PickUp5 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount5;
                    if (Player.GetComponent<PlayerHand>().PickUp6 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount6;
                    if (Player.GetComponent<PlayerHand>().PickUp7 == "tangchang")
                        tanchang += Player.GetComponent<PlayerHand>().Amount7;
                } // 탄창갯수
                if (tanchang >= 1)
                {
                    Reload(tanchang);
                }
                tanchang = 0;
                reloadingtime = 0;
            }
        }
        if(shuttingtime > shutlatetime)
        {
            if (tang > 0)
                Shut();
            shuttingtime = 0;
        }
    }

    void Shut()
    {
        if(GetComponent<CameraMover>().DoGuUSING || GetComponent<CameraMover>().ishelgi)
        {
            return;
        }
        particletime = 0;
        particle.Play();
        if (Input.GetMouseButton(1) && !reloading)
        {
            Enpty.GetComponent<CameraMover>().screen_shake(0.10f, 0.1f);
            this.GetComponent<CameraMover>().xRotate += -0.4f;
        }
        else
        {
            Enpty.GetComponent<CameraMover>().screen_shake(0.15f, 0.2f);
            this.GetComponent<CameraMover>().xRotate += -0.8f;
        }
        AudioManager.GetComponent<Player_sound_effect>().Sound("shut");

        Vector3 aaa = Vector3.up * ((float)Random.Range(-100f, 101f) / 100f) * tanperjim + Vector3.right * ((float)Random.Range(-100f, 101f) / 100f) * tanperjim;
        Quaternion aaaaa = Quaternion.Euler(aaa + chongDogu.transform.rotation.eulerAngles);
        //Debug.Log(aaa);
        //var chogalll = Instantiate(chongal, chongDogu.transform.position, chongDogu.transform.rotation);
        var chogalll = game_object_pool.InstantiatesObject("chongal_shooted", chongDogu.transform.position, aaaaa);
        chogalll.GetComponent<shongal_shouted>().damage = dam;
        chogalll.GetComponent<shongal_shouted>().speed = speed;
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong")
        {
            if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
            {
                Player.GetComponent<PlayerHand>().Amount1 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
            {
                Player.GetComponent<PlayerHand>().Amount2 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
            {
                Player.GetComponent<PlayerHand>().Amount3 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
            {
                Player.GetComponent<PlayerHand>().Amount4 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
            {
                Player.GetComponent<PlayerHand>().Amount5 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
            {
                Player.GetComponent<PlayerHand>().Amount6 -= 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
            {
                Player.GetComponent<PlayerHand>().Amount7 -= 1;
            }
        }
    }
    void Reload(int ab)
    {
        if(ab + tang >= Max_tang)
        {
            tnaghp_maxtang = Max_tang;
        }
        else
        {
            tnaghp_maxtang = ab + tang;
        }
        tnaghp = tnaghp_maxtang - tang;

        if (ab >= Max_tang)  // ab=> 10개 Maxtang => 15개 tang=>7개   재장전한후=>15개 빠진탄=>8개 ab=>2개
        {                    // ab=> 5개 Maxtang => 15개 tang=>4개   재장전한후=>9개 빠진탄=>5개 ab=>0개
            ab = Max_tang;
        }
        if (Player.GetComponent<PlayerHand>().PickUp1 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount1 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount1 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount1 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount1;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp2 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount2 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount2 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount2 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount2;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp3 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount3 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount3 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount3 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount3;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp4 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount4 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount4 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount4 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount4;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp5 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount5 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount5 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount5 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount5;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp6 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount6 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount6 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount6 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount6;
            }
        }
        else if (Player.GetComponent<PlayerHand>().PickUp7 == "tangchang")
        {
            if (Player.GetComponent<PlayerHand>().Amount7 >= tnaghp)
            {
                Player.GetComponent<PlayerHand>().Amount7 -= tnaghp;
            }
            else
            {
                Player.GetComponent<PlayerHand>().Amount7 = 0;
                tnaghp -= Player.GetComponent<PlayerHand>().Amount7;
            }
        }
        else
            return;


        if (Cursor.GetComponent<ItemCursor>().Using_Item == "chong")
        {
            if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
            {
                Player.GetComponent<PlayerHand>().Amount1 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
            {
                Player.GetComponent<PlayerHand>().Amount2 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
            {
                Player.GetComponent<PlayerHand>().Amount3 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
            {
                Player.GetComponent<PlayerHand>().Amount4 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
            {
                Player.GetComponent<PlayerHand>().Amount5 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
            {
                Player.GetComponent<PlayerHand>().Amount6 = tnaghp_maxtang + 1;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
            {
                Player.GetComponent<PlayerHand>().Amount7 = tnaghp_maxtang + 1;
            }
        }
    }

    public void Loadtang(int ttang)
    {
        tang = ttang;
    }
}
