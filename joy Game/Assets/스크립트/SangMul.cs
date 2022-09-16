using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangMul : MonoBehaviour
{
    private float time = 0f;
    private float time1 = 0f;
    private float time2 = 0f;
    private float time3 = 0f;
    private float gildulillgi_time = 0f;
    public bool gildulilljim = false;

    private float domangtime = 0f;
    public int SangMul_Hp = 50;
    public int SangMul_Hp_Max = 50;
    public GameObject gogi;
    private bool domang = false;
    private float distance;
    private float speed = 4f;
    private int random1;
    private int random2;
    private float random3 = 0;
    private float d;
    private float d2;
    public int pihearyang;
    private float Hp_time_s = 0f;
    private float Hp_time = 0f;
    private bool domangs = false;
    private bool HwaSalMajum;
    private Vector3 targetdomang;
    public float timesdwds = 0.5f;

    GameObject Player;
    GameObject Cursor;

    [SerializeField] GameObject Bunksic;
    AudioSource audiosource;
    [SerializeField] AudioClip[] audioclip;
    [SerializeField] float[] timeadw;

    Rigidbody rb;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        Physics.IgnoreCollision(Bunksic.GetComponent<Collider>(), GetComponent<Collider>());
        rb = GetComponent<Rigidbody>();
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
        Hp_time = 0;
        Hp_time_s = 0;
        domang = false;
        SangMul_Hp = SangMul_Hp_Max;
        time = 0;
        time1 = 0;
        time2 = 0;
        time3 = 0;
        domangtime = 0f;
    }

    void Update()
    {
        pihearyang = PlayerSettings.Player.PlayerAttackDmg;

        time += Time.deltaTime;
        time1 += Time.deltaTime;
        time3 += Time.deltaTime;
        Hp_time += Time.deltaTime;
        Hp_time_s += Time.deltaTime;
        if (true)
        {
            for(int i = 0; i < timeadw.Length; i++)
            {
                timeadw[i] += Time.deltaTime;
            }
            if (!audiosource.isPlaying)
            {
                if (timeadw[0] > 41)
                {
                    audiosource.clip = audioclip[0];
                    audiosource.Play();
                    timeadw[0] = 0;
                }
                if (timeadw[1] > 13)
                {
                    audiosource.clip = audioclip[1];
                    audiosource.Play();
                    timeadw[1] = 0;
                }
                if (timeadw[2] > 17)
                {
                    audiosource.clip = audioclip[2];
                    audiosource.Play();
                    timeadw[2] = 0;
                }
            }
        }

        if (SangMul_Hp <= 0)
        {
            GameObjectPool gameobjectpool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
            if (gildulilljim)
            {
                for (int i = 0; i < 12; i++)
                {
                    gameobjectpool.Instantiates("gogi", this.transform.position, Quaternion.identity);
                }
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    gameobjectpool.Instantiates("gogi", this.transform.position, Quaternion.identity);
                }
                Player.GetComponent<DoguThrowAway>().SangMuls -= 1;
            }
            gameObject.SetActive(false);
        }
        else if(SangMul_Hp <= 50 && distance < 30)
        {
            domang = true;
        }
        //else if(SangMul_Hp <= 20)
        //{
        //    domang = false;
        //    if (time1 > random3)
        //    {
        //        random1 = Random.Range(-2, 3);
        //        random2 = Random.Range(-2, 3);
        //        random3 = Random.Range(0.5f, 1f);
        //        d = transform.position.x;
        //        d2 = transform.position.z;
        //        time1 = 0;
        //    }
        //    if (transform.rotation.x > 10 && transform.rotation.z > 10)
        //    {
        //        time2 += Time.deltaTime;
        //        if (time2 > 2f)
        //        {
        //            transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
        //        }
        //    }
        //    else
        //    {
        //        time2 = 0f;
        //        this.transform.rotation = Quaternion.LookRotation(new Vector3(random1, 0, random2));
        //        transform.position = Vector3.MoveTowards(transform.position,
        //            new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 3f);
        //        //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
        //    }
        //}
        else
        {
            domang = false;
        }
        

        if(SangMul_Hp < SangMul_Hp_Max)
        {
            if (Hp_time_s > 1f)
            {
                if (Hp_time > 1.1f)
                {
                    Hp_time = 0f;
                }
                else if (Hp_time > 1f)
                {
                    SangMul_Hp += 1;
                    if (SangMul_Hp > SangMul_Hp_Max)
                    {
                        SangMul_Hp = SangMul_Hp_Max;
                    }
                    Hp_time = 0f;
                }
            }
        }
        if (SangMul_Hp > SangMul_Hp_Max)
        {
            SangMul_Hp = SangMul_Hp_Max;
        }

        if (time > 2f)
        {
            distance = Vector3.Distance(Player.transform.position, this.transform.position);
        }
        if (!gildulilljim && !Player.GetComponent<Player_Hp>().IsDie)
        {

        }
        else if (distance >= 25 && SangMul_Hp > 10)
        {

            if (time1 > random3)
            {
                random1 = Random.Range(-2, 3);
                random2 = Random.Range(-2, 3);
                random3 = Random.Range(0.5f, 4f);
                d = transform.position.x;
                d2 = transform.position.z;
                time1 = 0;
            }
            if (transform.rotation.x > 10 && transform.rotation.z > 10)
            {
                time2 += Time.deltaTime;
                if (time2 > 2f)
                {
                    transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                }
            }
            else
            {
                time2 = 0f;
                transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z));
                transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 0.3f);
                //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
            }
        }

        if (!gildulilljim && !Player.GetComponent<Player_Hp>().IsDie)
        {
            if (!domang && distance < 25)
            {
                if (transform.rotation.x > 10 && transform.rotation.z > 10)
                {
                    time2 += Time.deltaTime;
                    if (time2 > 2f)
                    {
                        transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                    }
                }
                else
                {
                    time2 = 0f;
                    transform.position = Vector3.MoveTowards(transform.position,
                        new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z),
                        speed * Time.deltaTime);
                    //Debug.Log((speed * Time.deltaTime).ToString());
                    transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z));
                }
            }
            else if (domang)
            {
                if (transform.rotation.x > 10 && transform.rotation.z > 10)
                {
                    time2 += Time.deltaTime;
                    if (time2 > 2f)
                    {
                        transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                    }
                }
                else
                {
                    time2 = 0f;
                    domangtime += Time.deltaTime;
                    //if (domangs)
                    //{
                    //    d = transform.position.x;
                    //    d2 = transform.position.z;
                    //    domangs = false;
                    //}
                    d = transform.position.x;
                    d2 = transform.position.z;

                    targetdomang = (this.transform.position - Player.transform.position);

                    this.transform.rotation = Quaternion.LookRotation(new Vector3(targetdomang.x, 0, targetdomang.z));
                    transform.position = Vector3.MoveTowards(transform.position,
                        new Vector3(d + targetdomang.x, transform.position.y, d2 + targetdomang.z), speed * Time.deltaTime * 1.5f);
                }
            }
            else if (distance >= 25 && SangMul_Hp > 10)
            {

                if (time1 > random3)
                {
                    random1 = Random.Range(-2, 3);
                    random2 = Random.Range(-2, 3);
                    random3 = Random.Range(0.5f, 4f);
                    d = transform.position.x;
                    d2 = transform.position.z;
                    time1 = 0;
                }
                if (transform.rotation.x > 10 && transform.rotation.z > 10)
                {
                    time2 += Time.deltaTime;
                    if (time2 > 2f)
                    {
                        transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                    }
                }
                else
                {
                    time2 = 0f;
                    //this.transform.rotation = Quaternion.LookRotation(new Vector3(random1, 0, random2));
                    this.transform.LookAt(new Vector3(random1, 0, random2) + transform.position);
                    transform.position = Vector3.MoveTowards(transform.position,
                        new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 0.3f);
                    //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
                }
            }
            if (distance > 350)
            {
                Player.GetComponent<DoguThrowAway>().SangMuls -= 1;
                gameObject.SetActive(false);
            }
        }
        else
        {
            if (time1 > random3)
            {
                random1 = Random.Range(-2, 3);
                random2 = Random.Range(-2, 3);
                random3 = Random.Range(0.5f, 4f);
                d = transform.position.x;
                d2 = transform.position.z;
                time1 = 0;
            }
            if (transform.rotation.x > 10 && transform.rotation.z > 10)
            {
                time2 += Time.deltaTime;
                if (time2 > 2f)
                {
                    transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                }
            }
            else
            {
                time2 = 0f;
                //this.transform.rotation = Quaternion.LookRotation(new Vector3(random1, 0, random2));
                this.transform.LookAt(new Vector3(random1, 0, random2) + transform.position);
                transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 0.3f);
                //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
            }
        }

        if(distance < 15)
        {
            gildulillgi_time += Time.deltaTime;
            if(gildulillgi_time > 60)
            {
                gildulilljim = true;
                Player.GetComponent<DoguThrowAway>().SangMuls -= 1;
                gameObject.name = "sangmul_domesticated";
            }
        }
        else
        {
            gildulillgi_time = 0f;
        }

        if (gildulilljim)
        {
            transform.GetChild(2).gameObject.SetActive(true);

            //if(distance > 30)
            //{
            //    if (time1 > random3)
            //    {
            //        random1 = Random.Range(-2, 3);
            //        random2 = Random.Range(-2, 3);
            //        random3 = Random.Range(0.5f, 4f);
            //        d = transform.position.x;
            //        d2 = transform.position.z;
            //        time1 = 0;
            //    }
            //    if (transform.rotation.x > 10 && transform.rotation.z > 10)
            //    {
            //        time2 += Time.deltaTime;
            //        if (time2 > 2f)
            //        {
            //            transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            //        }
            //    }
            //    else
            //    {
            //        time2 = 0f;
            //        this.transform.rotation = Quaternion.LookRotation(new Vector3(random1, 0, random2));
            //        transform.position = Vector3.MoveTowards(transform.position,
            //            new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 0.3f);
            //        //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
            //    }
            //}
            if (time1 > random3)
            {
                random1 = Random.Range(-2, 3);
                random2 = Random.Range(-2, 3);
                random3 = Random.Range(0.5f, 4f);
                d = transform.position.x;
                d2 = transform.position.z;
                time1 = 0;
            }
            if (transform.rotation.x > 10 && transform.rotation.z > 10)
            {
                time2 += Time.deltaTime;
                if (time2 > 2f)
                {
                    transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
                }
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "jackMul" && distance < 15)
            {
                if (distance > 5)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                        new Vector3(Player.transform.position.x, transform.position.y,
                        Player.transform.position.z),
                        speed * Time.deltaTime);
                }
                transform.LookAt(new Vector3(Player.transform.position.x,
                        transform.position.y, Player.transform.position.z));
            }
            else
            {
                time2 = 0f;
                //this.transform.rotation = Quaternion.LookRotation(new Vector3(random1, 0, random2));
                this.transform.LookAt(new Vector3(random1, 0, random2) + transform.position);
                transform.position = Vector3.MoveTowards(transform.position,
                    new Vector3(d + random1, transform.position.y, d2 + random2), speed * Time.deltaTime * 0.3f);
                //Debug.Log(new Vector3(d + random1, transform.position.y, d2 + random2).ToString());
            }
            //else if(distance > 10)
            //{
            //    this.transform.rotation = Quaternion.LookRotation(new Vector3(GameObject.Find("dongmulddarawa").transform.position.x, transform.position.y,
            //        GameObject.Find("dongmulddarawa").transform.position.z));
            //    transform.position = Vector3.MoveTowards(transform.position,
            //        new Vector3(GameObject.Find("dongmulddarawa").transform.position.x, transform.position.y,
            //        GameObject.Find("dongmulddarawa").transform.position.z), speed * 0.5f);
            //}
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (!gildulilljim)
        {
            if (other.tag == "Player")
            {
                if (time > 0.8f)
                {
                    Hit();
                    time = 0f;
                }
            }
        }
        //if (other.tag == "HwaSal")
        //{
            
        //    if(time > 0.25f)
        //    {
        //        SangMul_Hp -= pihearyang + 10;
        //        time = 0f;
        //    }
            
        //}
        //if (other.tag == "Cursor")
        //{
        //    Ahit();
        //    //if (Input.GetMouseButton(0))
        //    //{
        //    //    if (time3 > 0.7f)
        //    //    {
        //    //        if (GameObject.Find("Cursor Item").GetComponent<ItemCursor>().Using_Item == "gum")
        //    //        {
        //    //            SangMul_Hp -= pihearyang + 20;
        //    //        }
        //    //        else if (GameObject.Find("Cursor Item").GetComponent<ItemCursor>().Using_Item == "namuGock")
        //    //        {
        //    //            SangMul_Hp -= pihearyang + 10;
        //    //        }
        //    //        else if (GameObject.Find("Cursor Item").GetComponent<ItemCursor>().Using_Item == "dollGock")
        //    //        {
        //    //            SangMul_Hp -= pihearyang + 7;
        //    //        }
        //    //        else
        //    //        {
        //    //            SangMul_Hp -= pihearyang;
        //    //        }
        //    //        time3 = 0f;
        //    //        Hp_time_s = 0f;
        //    //    }
        //    //}
        //}
    }
    public void Hwasalhit()
    {
        SangMul_Hp -= pihearyang * 4;
    }
    private void Hit()
    {
        if (!Player.GetComponent<Player_Hp>().undie)
        {
            if (Player.GetComponent<PlayerHand>().PickUpF == "gapock")
                Player.GetComponent<Player_Hp>().PlayerHp -= 1 * PlayerSettings.Player.PlayerHitDmg;
            else
                Player.GetComponent<Player_Hp>().PlayerHp -= 10 * PlayerSettings.Player.PlayerHitDmg;
            Player.GetComponent<Player_Hp>().HPs = true;
        }
    }
    public void Guild()
    {
        gildulillgi_time += 10f;
        SangMul_Hp += 10;
        if (gildulilljim)
        {
            Bunksic.GetComponent<SangMulBungSick>().random = Random.Range(0, 2);
        }
    }
    public void Ahit()
    {
        if (Input.GetMouseButton(0))
        {
            if (time3 > timesdwds)
            {
                if (Cursor.GetComponent<ItemCursor>().Using_Item == "gum")
                {
                    SangMul_Hp -= pihearyang * 7;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulgum")
                {
                    SangMul_Hp -= pihearyang * 12;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "namuGock")
                {
                    SangMul_Hp -= pihearyang * 4;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dollGock")
                {
                    SangMul_Hp -= pihearyang * 3;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulnamuGock")
                {
                    SangMul_Hp -= pihearyang * 5;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulGock")
                {
                    SangMul_Hp -= pihearyang * 4;
                    timesdwds = 0.5f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dril")
                {
                    SangMul_Hp -= pihearyang * 7;
                    timesdwds = 0.05f;
                }
                else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chuldangum")
                {
                    SangMul_Hp -= pihearyang * 6;
                    timesdwds = 0.2f;
                }
                else
                {
                    timesdwds = 0.5f;
                    SangMul_Hp -= pihearyang;
                }

                time3 = 0f;
                Hp_time_s = 0f;
                rb.AddForce((transform.position - Player.transform.position).normalized * PlayerSettings.Player.PlayerPushDegree + Vector3.up, ForceMode.VelocityChange);
            }
        }
    }
}
