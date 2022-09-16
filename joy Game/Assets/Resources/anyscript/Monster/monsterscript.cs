using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterscript : MonoBehaviour
{
    public int Hp;
    [SerializeField] int Max_Hp;
    float HPtime;
    float time2;
    float timemove;
    float time3;
    Vector3 target;
    GameObject Player;
    GameObject Cursor;
    public List<GameObject> dw;
    [SerializeField] GameObject child;
    [SerializeField] GameObject bumwii;
    [SerializeField] float speed;
    [SerializeField] bool targetget;
    [SerializeField] GameObject gogi;
    [SerializeField] GameObject chulgui;
    [SerializeField] GameObject corepiece;
    Vector3 walkpos;
    public float timesdwds = 0.5f;

    [SerializeField] List<AudioClip> Audioclips = new List<AudioClip>(); // 0:울음 1:울음2 2:목표에돌진
    [SerializeField] float[] times;
    AudioSource audiosource;
    bool goononce = false;

    GameObjectPool game_object_pool;

    [SerializeField] ParticleSystem particle;
    float particletime;

    void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        audiosource = GetComponent<AudioSource>();
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
        particletime = 0;
        HPtime = 0;
        time2 = 0;
        time3 = 0;
        timemove = 0;
        for(int i = 0; i < times.Length; i++)
        {
            times[i] = 0;
        }
        Hp = Max_Hp;
    }
    void Update()
    {
        particletime += Time.deltaTime;
        for (int i = 0; i < times.Length; i++)
        {
            times[i] += Time.deltaTime;
        }
        time3 += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, transform.rotation.y, 0);
        dw = bumwii.GetComponent<monsterbumwii>().dww;
        time2 += Time.deltaTime;
        HPs();
        Chase();
        if (targetget)
        {
            if(particletime > 1)
            {
                particle.Play();
                particletime = 0;
            }
            if (goononce)
            {
                Audioplay(Audioclips[2], true);
                times[2] = -2f;
            }
            goononce = false;
            if (Vector3.Distance(gameObject.transform.position, target) > 2)
                transform.position = Vector3.MoveTowards(gameObject.transform.position, target, speed * Time.deltaTime);
            transform.LookAt(target);
            if(times[2] > 0.5f)
            {
                Audioplay(Audioclips[3], true);
                times[2] = 0;
            }
        }
        else
        {
            particle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            goononce = true;
            Walkaround();
        }
        if (true)
        {
            if (times[0] > 10)
            {
                Audioplay(Audioclips[0], false);
                times[0] = 0;
            }
            else if (times[1] > 14)
            {
                Audioplay(Audioclips[1], false);
                times[1] = 1;
            }
        }
    }
    void HPs()
    {
        if(Hp < 0)
        {
            Die();
        }
        else if (Hp < Max_Hp)
        {
            HPtime += Time.deltaTime;
            if (HPtime > 1)
            {
                Hp += 10;
                HPtime = 0;
            }
        }
        if (Hp > Max_Hp)
        {
            Hp = Max_Hp;
        }
    }

    bool sss = false;
    void Chase()
    {
        sss = false;
        if (dw.Contains(Player) && !Player.GetComponent<Player_Hp>().IsDie)
        {
            target = new Vector3(Player.transform.position.x, gameObject.transform.position.y, Player.transform.position.z);
            sss = true;
        }
        else
        {
            sss = false;
            for (int i = 0; i < dw.Count; i++)
            {
                if(dw[i] != null)
                {
                    if (dw[i].tag == "boss")
                    {
                        target = new Vector3(dw[i].transform.position.x, gameObject.transform.position.y, dw[i].transform.position.z);
                        sss = true;
                    }
                    else if (dw[i].tag == "Enemy")
                    {
                        target = new Vector3(dw[i].transform.position.x, gameObject.transform.position.y, dw[i].transform.position.z);
                        sss = true;
                    }
                    else if(dw[i].tag == "SangMul")
                    {
                        target = new Vector3(dw[i].transform.position.x, gameObject.transform.position.y, dw[i].transform.position.z);
                        sss = true;
                    }
                }
            }
        }
        if (sss)
            targetget = true;
        else
            targetget = false;
    }
    void Walkaround()
    {
        timemove += Time.deltaTime;
        if (timemove > 2)
        {
            float randx = Random.Range(-7, 7);
            float randz = Random.Range(-7, 7);
            walkpos = new Vector3(randx, 0, randz);
            walkpos += gameObject.transform.position;
            timemove = 0;
        }
        transform.position = Vector3.MoveTowards(gameObject.transform.position, walkpos, speed / 5 * Time.deltaTime);
        transform.LookAt(walkpos);
    }
    void Die()
    {
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(1, 0, 0), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(-1, 0, 0), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(0, 0, 1), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(0, 0, -1), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(1, 0, 1), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(-1, 0, -1), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(1, 0, 1), Quaternion.identity);
        game_object_pool.Instantiates("gogi", transform.position - new Vector3(-1, 0, -1), Quaternion.identity);

        game_object_pool.Instantiates("corepiece", transform.position - new Vector3(0, 0, 0), Quaternion.identity);

        game_object_pool.Instantiates("chulgui", transform.position - new Vector3(0, 1, 0), Quaternion.identity);
        game_object_pool.Instantiates("chulgui", transform.position - new Vector3(1, 1, 0), Quaternion.identity);
        game_object_pool.Instantiates("chulgui", transform.position - new Vector3(-1, 1, 0), Quaternion.identity);
        game_object_pool.Instantiates("chulgui", transform.position - new Vector3(0, 1, 1), Quaternion.identity);
        game_object_pool.Instantiates("chulgui", transform.position - new Vector3(0, 1, -1), Quaternion.identity);

        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
    public void Ahit()
    {
        if (time2 > timesdwds)
        {
            if (Cursor.GetComponent<ItemCursor>().Using_Item == "gum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 7;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulgum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 12;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "namuGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 4;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dollGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 5;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulnamuGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 6;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 10;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dril")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 20;
                timesdwds = 0.05f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chuldangum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 2;
                timesdwds = 0.2f;
            }
            else
            {
                timesdwds = 0.5f;
                Hp -= PlayerSettings.Player.PlayerAttackDmg;
            }

            time2 = 0f;
        }
    }

    void Audioplay(AudioClip audio, bool ad)
    {
        if (ad)
        {
            audiosource.Stop();
        }
        if (!audiosource.isPlaying)
        {
            audiosource.clip = audio;
            audiosource.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item Gogi" && time3 > 0.3f)
        {
            Hp += 1;
            other.gameObject.SetActive(false);//Destroy(other.gameObject);
        }
    }
}
