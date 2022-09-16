using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Hp : MonoBehaviour
{
    public int PlayerHp;
    public Text text;
    public Text text1;
    private float times;
    private float times1;
    private float times2;
    private float times3;
    public float hP = 1f;
    public int ful_hp = 200;
    public bool HPs = false;

    public Slider slider;
    public GameObject slider2;

    public int Hugi;
    public int Ful_Hugi;
    public Slider Hugi1;
    public GameObject Hugi2;
    public Text Hugitext;

    public bool running;
    private float Hugitime;
    private bool dwdwdwdqadadawdawzdadadxcswefdca;

    public GameObject DiedMuckUm;
    public bool Diedsss = true;

    public Vector3 responepos = new Vector3(0f, 1.12f, 0f);

    public GameObject Diescene;
    public GameObject nininin;
    public bool IsDie;
    public GameObject dogu;
    Vector2 nininpos;
    GameObject Inven;

    public bool undie; // 트루면 안닳고 펄스면 닳는것

    float hpdtime = 2;
    int lasthp;
    float showhp;

    GameObject AudioManager;

    GameObjectPool game_object_pool;

    private void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Inven = GameObject.Find("Inventory");
        AudioManager = GameObject.Find("Player_sound");
    }
    private void Start()
    {
        nininpos = nininin.transform.position;
        showhp = PlayerHp;
        lasthp = PlayerHp;
    }

    void Update()
    {
        if (true)
        {
            ful_hp = PlayerSettings.Player.PlayerMaxHp;
        }

        text.text = PlayerHp.ToString();
        text1.text = PlayerHp.ToString() + " / " + ful_hp.ToString();

        slider.value = showhp / ful_hp;
        if(lasthp != PlayerHp)
        {
            hpdtime += Time.deltaTime / 2 * (Mathf.Abs(lasthp - PlayerHp));
            //100 -> 80  20 -> 1 2 3... 18 19 20
            if(lasthp > PlayerHp)
            {
                showhp = lasthp - hpdtime;
            }
            else
            {
                showhp = lasthp + hpdtime;
            }
            if(showhp > PlayerHp && lasthp < PlayerHp)
            {
                hpdtime = 0;
                lasthp = PlayerHp;
            }
            else if(showhp < PlayerHp && lasthp > PlayerHp)
            {
                hpdtime = 0;
                lasthp = PlayerHp;
            }
        }

        Hugitext.text = Hugi.ToString() + " / " + Ful_Hugi.ToString();
        Hugi1.value = (float)Hugi / Ful_Hugi;

        times += Time.deltaTime;

        if (Hugi > Ful_Hugi)
        {
            Hugi = Ful_Hugi;
        }
        if (!undie)
        {
            Hugitime = 20f;
            if (running)
            {
                times2 += Time.deltaTime * 5;
            }
            else
            {
                times2 += Time.deltaTime;
            }
            if(Hugi < Ful_Hugi)
            {
                dwdwdwdqadadawdawzdadadxcswefdca = false;
            }
            else
            {
                dwdwdwdqadadawdawzdadadxcswefdca = true;
            }
            if (Hugi < 30)
            {
                this.GetComponent<PlayerMover>().dontrun = true;
                times3 += Time.deltaTime;
                if (times3 >= 1f)
                {
                    PlayerHp -= 1;
                    times3 = 0f;
                }
            }
            else
            {
                this.GetComponent<PlayerMover>().dontrun = false;
            }
            if (Hugi == 0)
            {
                PlayerHp = 0;
            }
            if (Hugi < 0)
            {
                Hugi = 0;
            }

            if (times2 >= Hugitime)
            {
                Hugi -= 1;
                times2 = 0f;
            }
            if (Hugi < Ful_Hugi - 5)
            {
                HPs = true;
            }

            if (PlayerHp > ful_hp)
            {
                PlayerHp = ful_hp;
            }
            if (HPs)
            {
                if (dwdwdwdqadadawdawzdadadxcswefdca)
                {
                    times1 += Time.deltaTime;
                    if (times1 > 1f)
                    {
                        HPs = false;
                        times1 = 0f;
                    }
                }
            }
        }
        else
        {
            PlayerHp = ful_hp;
            Hugi = Ful_Hugi;
        }

        if (PlayerHp < ful_hp)
        {
            if(!HPs)
            {
                //Debug.Log("ssssssssssssssssss");
                //Debug.Log(times.ToString());
                if (times > hP)
                {
                    PlayerHp += 1;
                    //Debug.Log("eeeeeeeeeeeeeeeeeee");
                    times = 0f;
                }
            }
        }

        if(PlayerHp < 0)
        {
            PlayerHp = 0;
        }
        if(slider.value <= 0)
        {
            slider2.SetActive(false);
        }
        if(slider.value > 0)
        {
            slider2.SetActive(true);
        }
        if (Hugi1.value <= 0)
        {
            Hugi2.SetActive(false);
        }
        if (Hugi1.value > 0)
        {
            Hugi2.SetActive(true);
        }

        if(PlayerHp == 0 && !undie)
        {
            if (Diedsss)
            {
                Died();
                Diedsss = false;
            }
        }
    }

    public void Died()
    {
        GetComponent<CapsuleCollider>().isTrigger = true;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        gameObject.layer = 2;
        //var that = Instantiate(DiedMuckUm);
        var that = game_object_pool.InstantiatesObject("muckum", transform.position, Quaternion.identity);
        //that.transform.position = this.transform.position;
        that.GetComponent<PlayerDiedMuckUm>().SaveItems();
        IsDie = true;
        this.GetComponent<PlayerHand>().Amount1 = 0;
        this.GetComponent<PlayerHand>().Amount2 = 0;
        this.GetComponent<PlayerHand>().Amount3 = 0;
        this.GetComponent<PlayerHand>().Amount4 = 0;
        this.GetComponent<PlayerHand>().Amount5 = 0;
        this.GetComponent<PlayerHand>().Amount6 = 0;
        this.GetComponent<PlayerHand>().Amount7 = 0;
        this.GetComponent<PlayerHand>().AmountF = 0;
        for(int i = 0; i < Inven.GetComponent<Invenmaniger>().items.Length; i++)
        {
            Inven.GetComponent<Invenmaniger>().items[i] = "none";
            Inven.GetComponent<Invenmaniger>().nums[i] = 0;
        }
        this.GetComponent<PlayerMover>().energyTimelate = 0f;
        Diescene.SetActive(true);
        nininin.transform.position = new Vector2(0, -1000);
        dogu.SetActive(false);
        this.GetComponent<ESC>().Diechang = 1;
        //AudioManager.GetComponent<Player_sound_effect>().Soundreset();
    }

    public void Respone()
    {
        GetComponent<CapsuleCollider>().isTrigger = false;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<MeshRenderer>().enabled = true;
        gameObject.layer = 0;
        Diedsss = true;
        IsDie = false;
        this.transform.position = responepos;
        PlayerHp = ful_hp;
        Hugi = Ful_Hugi;
        times2 = 0f;
        this.GetComponent<ESC>().Diechang = 0;
        Diescene.SetActive(false);
        nininin.transform.position = nininpos;
        dogu.SetActive(true);
        lasthp = PlayerHp;
        showhp = PlayerHp;
    }
}
