using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_boss : MonoBehaviour
{
    GameObject Player;
    GameObject Cursor;

    [Header("일반")]
    [SerializeField] GameObject bumwii;
    [SerializeField] float Lookdis;
    public int Hp;
    [SerializeField] int Max_hp;
    [SerializeField] GameObject nowork;

    [Header("이동")]
    [SerializeField] float speed;
    [SerializeField] float jump_power;
    [SerializeField] float super_jump_power;
    public Vector3 or_pos;

    [Header("공격")]
    [SerializeField] float attacktime;
    [SerializeField] int attack_dam;
    [SerializeField] GameObject target;
    [SerializeField] GameObject attack;

    List<GameObject> gamob;
    float[] time = new float[6];

    float discheckyondo;
    GameObject discheckyondoga;
    Vector3 movepos;
    Rigidbody rb;
    bool isground;
    bool needtojump;

    bool Isnowork;
    bool Dontconsiderdistance;

    int lasthp;
    Vector3 m_LastPosition;

    int lastHp;
    bool lastHpbool = true;

    public float timesdwds = 0.5f;
    bool dontconsidersafepos = false;

    [SerializeField] AudioClip[] clips; //0추격 1공격 2휴면
    [SerializeField] float[] audiotimes;
    [SerializeField] AudioSource[] audiosources;

    [SerializeField] ParticleSystem JumpParticle; // 5
    float JumpParticletime;
    [SerializeField] ParticleSystem BigJumpParticle; // 5
    float BigJumpParticletime;
    [SerializeField] ParticleSystem AttackParticle; // 1
    float AttackParticletime;

    void Awake()
    {
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
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
        lastHpbool = true;
        dontconsidersafepos = false;
        BigJumpParticletime = 0;
        AttackParticletime = 0;
        JumpParticletime = 0;
        for (int i = 0; i < time.Length; i++)
        {
            time[i] = 0;
        }
        for (int i = 0; i < audiotimes.Length; i++)
        {
            audiotimes[i] = 0;
        }
        Hp = Max_hp;
        or_pos = transform.position;
        time[2] = 10f;
        JumpParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        BigJumpParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        AttackParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    void Update()
    {
        gamob = bumwii.GetComponent<boss_bumwii>().gamob;
        for(int i = 0; i < time.Length; i++)
        {
            time[i] += Time.deltaTime;
        }
        for (int i = 0; i < audiotimes.Length; i++)
        {
            audiotimes[i] += Time.deltaTime;
        }
        if (Dontconsiderdistance && time[2] > 10f)
        {
            Dontconsiderdistance = false;
        }
        if (dontconsidersafepos && time[4] > 10f)
        {
            dontconsidersafepos = false;
        }
        Hpcount();
        Gettarget();
        Working();
        if (!Isnowork)
        {
            Getmovepos();
            Move();
            Attack();
        }
        else
        {
            if(audiotimes[2] > 2)
            {
                audioplay(clips[2], true);
                audioplay(clips[1], false);
                audioplay(clips[0], false);
                audiotimes[2] = 0;
            }
        }
        if (lastHpbool)
        {
            lastHp = Hp;
            lastHpbool = false;
        }
        else
        {
            lastHpbool = true;
        }

        if (true)
        {
            if (JumpParticletime > 5)
            {
                JumpParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
            else
            {
                JumpParticletime += Time.deltaTime;
            }
            if (BigJumpParticletime > 5)
            {
                BigJumpParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
            else
            {
                BigJumpParticletime += Time.deltaTime;
            }
            if (AttackParticletime > 1)
            {
                AttackParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
            else
            {
                AttackParticletime += Time.deltaTime;
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.7f || transform.position.y <= 0.4f)
        {
            isground = true;
        }
        else
        {
            isground = false;
        }
    }
    

    void Working()
    {
        Isnowork = false;
        if (Vector3.Distance(transform.position, or_pos) < 10 && target == null)
        {
            Isnowork = true;
        }

        if (Isnowork)
        {
            nowork.SetActive(true);
        }
        else
        {
            nowork.SetActive(false);
        }
    }
    void Hitten()
    {
        time[2] = 0;
        Dontconsiderdistance = true;
    }
    void jump(bool Istarget)
    {
        if (isground)
        {
            if (Istarget)
            {
                if (target.transform.position.y - transform.position.y > 20)
                {
                    rb.AddForce(Vector3.up * super_jump_power);
                    BigJumpParticle.Play();
                    BigJumpParticletime = 0f;
                    return;
                }
            }
            rb.AddForce(Vector3.up * jump_power);
            JumpParticle.Play();
            JumpParticletime = 0f;
        }
    }
    void Attack()
    {
        List<GameObject> that = attack.GetComponent<close_boss_attacker>().gamob;
        if (time[1] > attacktime)
        {
            AttackParticle.Play();
            AttackParticletime = 0f;
            for (int k = that.Count - 1; k >= 0; k--)
            {
                if(that[k] == null)
                {
                    that.Remove(that[k]);
                }
            }
            attack.GetComponent<close_boss_attacker>().gamob = that;
            for (int i = 0; i < that.Count; i++)
            {
                if (that[i].tag == "Player")
                {
                    if (that[i].GetComponent<PlayerHand>().PickUpF == "gapock")
                    {
                        that[i].GetComponent<Player_Hp>().PlayerHp -= (attack_dam / 2) * PlayerSettings.Player.PlayerHitDmg;
                    }
                    else
                    {
                        that[i].GetComponent<Player_Hp>().PlayerHp -= attack_dam * PlayerSettings.Player.PlayerHitDmg;
                    }
                }
                else if (that[i].tag == "Enemy")
                {
                    that[i].GetComponent<Enemymove>().Hp -= attack_dam;
                }
                else if (that[i].tag == "Monsters")
                {
                    that[i].GetComponent<monsterscript>().Hp -= attack_dam;
                }
                else if (that[i].tag == "SangMul")
                {
                    that[i].GetComponent<SangMul>().SangMul_Hp -= attack_dam;
                }
                else if (that[i].GetComponent<Buildingbreak>() && !that[i].GetComponent<final_boss>())
                {
                    that[i].GetComponent<Buildingbreak>().HP -= attack_dam * 5;
                }
            }
            time[1] = 0;
            if (audiotimes[1] > 0.3f)
            {
                audioplay(clips[1], false);
                audioplay(clips[1], true);
                audiotimes[1] = 0;
            }
        }
    }
    void Die()
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }

    void Hpcount()
    {
        if (Isnowork)
        {
            Hp = lasthp;
        }

        if(Hp < 0)
        {
            Die();
        }
        else if(Max_hp > Hp)
        {
            if(time[0] > 5f || (Isnowork && time[0] > 0.1f))
            {
                Hp += 50;
                if(Hp > Max_hp)
                {
                    Hp = Max_hp;
                }
                time[0] = 0f;
            }
        }
        else if(Max_hp < Hp)
        {
            Hp = Max_hp;
        }

        if(lasthp > Hp)
        {
            Hitten();
        }
        lasthp = Hp;
    }

    void Gettarget()
    {
        target = null;
        for (int i = 0; i < gamob.Count; i++)
        {
            if(gamob[i] == null)
            {
                continue;
            }
            if(gamob[i].tag == "Player" && Player.GetComponent<Player_Hp>().IsDie)
            {
                continue;
            }
            if (gamob[i].tag == "Player" && (Cursor.GetComponent<ItemCursor>().Using_Item == "chong" ||
                Cursor.GetComponent<ItemCursor>().Using_Item == "hwal"))
            {
                dontconsidersafepos = true;
            }
            float dis = Vector3.Distance(transform.position, gamob[i].transform.position);
            if (!dontconsidersafepos)
            {
                if(Vector3.Distance(transform.position, or_pos) > 70 && time[5] > 4f)
                {
                    time[5] = 0;
                    continue;
                }
            }
            if (!Dontconsiderdistance)
            {
                if(dis > Lookdis)
                {
                    continue;
                }
            }
            if (discheckyondo > dis || discheckyondoga == null)
            {
                discheckyondo = dis;
                discheckyondoga = gamob[i];
            }
        }
        target = discheckyondoga;
        discheckyondoga = null;
    }
    void Getmovepos()
    {
        if (target == null)
            return;
        needtojump = false;
        movepos = new Vector3(target.transform.position.x, transform.position.y,
            target.transform.position.z);
        if(target.transform.position.y > transform.position.y)
        {
            needtojump = true;
        }
    }
    void Move()
    {
        if (transform.position.y < 0.4f)
        {
            transform.position = new Vector3(transform.position.x, 0.4f, transform.position.z);
        }
        if (needtojump)
        {
            jump(true);
            needtojump = false;
        }

        if(target != null)
        {
            if (Vector3.Distance(transform.position, movepos) > 2)
                transform.position = Vector3.MoveTowards(transform.position, movepos, speed * Time.deltaTime);
        }
        else
        {
            if (or_pos.y > transform.position.y)
                jump(false);
            Vector3 that = new Vector3(or_pos.x, transform.position.y, or_pos.z);
            transform.position = Vector3.MoveTowards(transform.position, that, speed * Time.deltaTime);
        }
        if(audiotimes[0] > 4)
        {
            audioplay(clips[0], true);
            audiotimes[0] = 0;
        }

    }

    public void Ahit()
    {
        if (time[3] > timesdwds)
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

            time[3] = 0f;
        }
    }

    void audioplay(AudioClip audio, bool yes)
    {
        for(int i = 0; i < audiosources.Length; i++)
        {
            if (yes && !audiosources[i].isPlaying)
            {
                audiosources[i].clip = audio;
                audiosources[i].Play();
            }
            else if(!yes && audiosources[i].isPlaying && audiosources[i].clip == audio)
            {
                audiosources[i].Stop();
            }
        }
    }
}
