using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_boss : MonoBehaviour
{
    [SerializeField] boss_bumwii bumwii;
    public float killtime = 0;
    [SerializeField] float kill_Time;

    GameObjectPool game_object_pool;
    public GameObject Stage;

    List<GameObject> bumwiiin = new List<GameObject>();
    float attacktime;
    [SerializeField] float attackcycletime;

    [System.Serializable]
    class aaaaaaaaaaa
    {
        public List<string> aa = new List<string>();
    }

    [SerializeField] List<aaaaaaaaaaa> aaaaaaaa = new List<aaaaaaaaaaa>();

    int aaaaaa;

    public List<GameObject> sponed_objects;

    GameObject Player;

    [SerializeField] float movespeed;

    public bool invincibility = false;

    Buildingbreak HPpppppppppp;

    [SerializeField] ParticleSystem invincibilityParticle;
    float invincibilityParticletime;

    Dig_Particles_cs DigParticleManager;

    [SerializeField] AudioSource Normal;
    float timeforaudioNormal;

    Player_sound_effect AudioManeger;
    void Awake()
    {
        Player = GameObject.Find("Player");
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        DigParticleManager = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        HPpppppppppp = GetComponent<Buildingbreak>();
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
        timeforaudioNormal = 0;
        invincibilityParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        invincibilityParticletime = 1;
        invincibility = true;
        killtime = 0;
        attacktime = 0;
        aaaaaa = 0;
        warpsoundonce = true;
    }
    bool warpsoundonce;
    void Update()
    {
        transform.Rotate(Vector3.up * 45 * Time.deltaTime);
        killtime += Time.deltaTime;
        attacktime += Time.deltaTime;
        if(killtime > kill_Time - 9 && warpsoundonce)
        {
            AudioManeger.Sound("warp");
            warpsoundonce = false;
        }
        if (killtime > kill_Time)
        {
            gameObject.SetActive(false);
        }
        for(int i = bumwiiin.Count - 1; i >= 0; i--)
        {
            bumwiiin.RemoveAt(i);
        }
        for (int i = 0; i < bumwii.gamob.Count; i++)
        {
            if(bumwiiin.Count > i)
            {
                bumwiiin[i] = bumwii.gamob[i];
            }
            bumwiiin.Add(bumwii.gamob[i]);
        }
        if(attacktime > attackcycletime)
        {
            Attack();
            attacktime = 0;
        }
        for(int i = sponed_objects.Count - 1; i >= 0; i--)
        {
            if(sponed_objects[i] == null)
            {
                sponed_objects.RemoveAt(i);
                continue;
            }
            if (!sponed_objects[i].activeSelf)
            {
                sponed_objects.RemoveAt(i);
            }
        }

        Vector3 Playertransform = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, Playertransform, movespeed * Time.deltaTime);

        if (invincibility)
        {
            invincibilityParticletime += Time.deltaTime;
            HPpppppppppp.HP = HPpppppppppp.or_Hp;

            if (invincibilityParticletime > 0.5f)
            {
                invincibilityParticle.Play();
                invincibilityParticletime = 0;
            }
        }
        else if (invincibilityParticle.isPlaying)
        {
            invincibilityParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }

        timeforaudioNormal += Time.deltaTime;
        if(timeforaudioNormal > 0.2f)
        {
            Normal.Stop();
            Normal.Play();
            timeforaudioNormal = 0;
        }
    }

    private void OnDisable()
    {
        Die();
    }

    void Die()
    {
        for(int i = 0; i < sponed_objects.Count; i++)
        {
            sponed_objects[i].SetActive(false);
        }
        if (killtime < kill_Time)
        {
            AudioManeger.Sound("youwilldie");
            clear();
        }
        else
        {
            DigParticleManager.Particle(transform.position + Vector3.up * 30, "finalboss_withdraw");
            AudioManeger.Soundoff("warp");
        }
    }

    void clear()
    {
        DigParticleManager.Particle(transform.position + Vector3.up * 30, "finalboss_die");
        Stage.GetComponent<finalboss_spone>().clear();
    }

    //float dis;
    //GameObject target;
    Vector3 GEtpos()
    {
        //target = null;
        //dis = 99999;
        //for(int i = 0; i < bumwiiin.Count; i++)
        //{
        //    if(bumwiiin[i].transform.position.y < 0)
        //    {
        //        continue;
        //    }
        //    float bbb = Vector3.Distance(transform.position, bumwiiin[i].transform.position);
        //    if(bbb < dis)
        //    {
        //        dis = bbb;
        //        target = bumwiiin[i];
        //    }
        //}
        //if (target == null)
        //{
        //    return new Vector3(0, -50, 0);
        //}
        //return target.transform.position;

        if (bumwiiin.Contains(Player))
        {
            return Player.transform.position;
        }
        return new Vector3(0, -50, 0);
    }

    void Attack()
    {
        if (invincibility)
        {
            invincibility = false;
        }
        if(aaaaaaaa.Count <= aaaaaa)
        {
            aaaaaa -= aaaaaaaa.Count;
        }
        //Debug.Log(aaaaaa);
        aaaaaaaaaaa a = aaaaaaaa[aaaaaa];
        Vector3 pos = GEtpos();
        if(pos.y < 0)
        {
            return;
        }
        pos = pos + Vector3.up * 50;
        for(int i = 0; i < a.aa.Count; i++)
        {
            Vector3 ppppppppppppppppos = pos + Vector3.right * i * 10 + Vector3.forward * i * 10;
            sponed_objects.Add(game_object_pool.InstantiatesObject(a.aa[i], ppppppppppppppppos, Quaternion.identity));
            DigParticleManager.Particle(ppppppppppppppppos, "finalboss_enemy_summon");
        }

        aaaaaa++;
    }
}
