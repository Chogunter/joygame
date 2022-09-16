using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class long_boss : MonoBehaviour
{
    [Header("일반")]
    public int Hp;
    [SerializeField] int Max_Hp;

    [Header("이동")]
    [SerializeField] GameObject balpan;

    [Header("공격관련")]
    [SerializeField] GameObject bumwii;
    List<GameObject> targets;
    [SerializeField] GameObject target;
    [SerializeField] GameObject ray;
    [SerializeField] float reloadingtime;
    [SerializeField] int dam;
    bool shutting = false;
    bool dawdawd = false;

    float[] time = new float[5];
    Rigidbody rb;
    public float timesdwds = 0.5f;
    GameObject Cursor;

    [SerializeField] AudioClip[] clips; //0공격 1평시
    [SerializeField] float[] audiotimes;
    [SerializeField] AudioSource[] audiosources;

    [SerializeField] ParticleSystem aiming;
    [SerializeField] ParticleSystem shotParticle;
    float shot_particle_time;
    float aiming_time = 6;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
        ray.GetComponent<MeshRenderer>().enabled = false;
        shutting = false;
        dawdawd = false;
        for (int i = 0; i < time.Length; i++)
        {
            time[i] = 0;
        }
        for (int i = 0; i < audiotimes.Length; i++)
        {
            audiotimes[i] = 0;
        }
        Hp = Max_Hp;
        aiming_time = 6;
        aiming.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        shotParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    void Update()
    {
        //Debug.Log(target);
        //if(shot_particle_time > 2)
        //{
        //    shotParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        //}
        //else
        //{
        //    shot_particle_time += Time.deltaTime;
        //}
        for (int timeindex = 0; timeindex < time.Length; timeindex++)
        {
            time[timeindex] += Time.deltaTime;
        }
        for (int i = 0; i < audiotimes.Length; i++)
        {
            audiotimes[i] += Time.deltaTime;
        }
        if (!shutting)
        {
            targetclean();
            Gettarget();
            Move();
        }
        if (target != null && !shutting)
        {
            shot();
        }
        if (shutting)
        {
            if(time[1] > 0.5f)
            {
                audioplay(clips[1], false);
                audioplay(clips[0], false);
                audioplay(clips[0], true);
                ray.GetComponent<MeshRenderer>().enabled = true;
                List<GameObject> ad = ray.GetComponent<close_boss_attacker>().gamob;
                if (dawdawd)
                {
                    aiming.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
                    aiming_time = 6;
                    shot_particle_time = 0;
                    //shotParticle.Play();
                    for (int q = 0; q < ad.Count; q++)
                    {
                        if (ad[q] == null)
                        {
                            continue;
                        }
                        if (ad[q].tag == "Player" && !ad[q].GetComponent<Player_Hp>().IsDie)
                        {
                            ad[q].GetComponent<Player_Hp>().PlayerHp -= dam * PlayerSettings.Player.PlayerHitDmg;
                        }
                        else if (ad[q].tag == "Monsters")
                        {
                            ad[q].GetComponent<monsterscript>().Hp -= dam;
                        }
                        else if (ad[q].tag == "Enemy")
                        {
                            ad[q].GetComponent<Enemymove>().Hp -= dam;
                        }
                        else if (ad[q].tag == "SangMul")
                        {
                            ad[q].GetComponent<SangMul>().SangMul_Hp -= dam;
                        }
                        else if (ad[q].GetComponent<Buildingbreak>() && !ad[q].GetComponent<final_boss>())
                        {
                            ad[q].GetComponent<Buildingbreak>().HP -= dam;
                        }
                    }
                }
                dawdawd = false;
                if (time[2] > 0.3f)
                {
                    time[0] = 0;
                    time[1] = 0;
                    time[2] = 0;
                    ray.GetComponent<MeshRenderer>().enabled = false;
                    shutting = false;
                }
            }
            else
            {
                time[2] = 0;
            }
        }//shot
        if(time[3] > 1)
        {
            Hp += 10;
            if(Hp > Max_Hp)
            {
                Hp = Max_Hp;
            }
            time[3] = 0;
        }
        if(Hp <= 0)
        {
            Die();
        }
        if(audiotimes[0] > 2)
        {
            audioplay(clips[1], false);
            audioplay(clips[1], true);
            audiotimes[0] = 0;
        }
        if(target != null)
        {
            aiming_time += Time.deltaTime;
            if(aiming_time > 6)
            {
                aiming.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
                aiming.Play();
                aiming_time = 0;
            }
        }
        else
        {
            aiming_time = 6;
            aiming.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }
    void Move()
    {
        balpan.transform.position = transform.position + Vector3.down * 1.75f;
        balpan.transform.rotation = Quaternion.identity;
        if (target != null)
        {
            transform.LookAt(target.transform.position);
        }
    }
    void targetclean()
    {
        targets = bumwii.GetComponent<boss_bumwii>().gamob;
        for (int j = targets.Count - 1; j >= 0; j--)
        {
            if (targets[j] == null)
            {
                targets.RemoveAt(j);
            }
        }
        bumwii.GetComponent<boss_bumwii>().gamob = targets;
    }

    GameObject targ = null;
    float dis;
    void Gettarget()
    {
        targets = bumwii.GetComponent<boss_bumwii>().gamob;
        dis = 500; // -3000 이다 맨이야~~~
        targ = null;
        for (int i = 0; i < targets.Count; i++)
        {
            if(targets[i] == null)
            {
                continue;
            }
            if(targets[i].tag == "Player" && targets[i].GetComponent<Player_Hp>().IsDie)
            {
                continue;
            }
            float dwdawda = Vector3.Distance(targets[i].transform.position, transform.position);
            if (dwdawda < dis)
            {
                dis = dwdawda;
                targ = targets[i];
            }
        }
        target = targ;
    }
    void shot()
    {
        time[1] = 0;
        if (time[0] > reloadingtime)
        {
            shutting = true;
            dawdawd = true;
        }
    }
    void Die()
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }

    public void Ahit()
    {
        if (time[4] > timesdwds)
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

            time[4] = 0f;
        }
    }

    void audioplay(AudioClip audio, bool yes)
    {
        for (int i = 0; i < audiosources.Length; i++)
        {
            if (yes && !audiosources[i].isPlaying)
            {
                audiosources[i].clip = audio;
                audiosources[i].Play();
            }
            else if (!yes && audiosources[i].isPlaying && audiosources[i].clip == audio)
            {
                audiosources[i].Stop();
            }
        }
    }
}
