using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    float Maxdis = 50;
    [SerializeField] int dam;
    public float dam_ratio;
    RaycastHit hit;
    GameObject Player;
    GameObject Cursor;
    GameObject enemy;

    Vector3 target;

    float[] time = new float[2];

    [SerializeField] GameObject hwasal;
    float timesdwds = 0.5f;

    string dogu;
    [SerializeField] Transform hwasalpos;

    [SerializeField] GameObject chongal;
    [SerializeField] int chongdam ;
    [SerializeField] float chongspeed;
    [SerializeField] float chongshutlatetime;
    [SerializeField] AudioSource[] audios;

    [SerializeField] ParticleSystem particle;

    GameObjectPool game_object_pool;

    [SerializeField] Transform arm;
    [SerializeField] Transform dogua;
    [SerializeField] personanimationparamitormanager animationperson;
    [SerializeField] Transform arms;

    Enemymove parentmove;

    Player_sound_effect AudioManeger;
    void Start()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        enemy = transform.parent.gameObject;
        parentmove = enemy.GetComponent<Enemymove>();
    }
    void Update()
    {
        dogua.position = arm.position + (-arm.up * 0.7f);
        arms.localEulerAngles = new Vector3(transform.eulerAngles.x, 0, 0);
        for (int i = 0; i < time.Length; i++)
        {
            time[i] += Time.deltaTime;
        }
        if (enemy.GetComponent<Enemymove>().ThereIsTarget)
        {
            if (dogu == "hwal")
            {
                target = enemy.GetComponent<Enemymove>().target_pos +
                    Vector3.up * 0.1f * Vector3.Distance(transform.position, enemy.GetComponent<Enemymove>().target_pos);
            }
            else
            {
                target = enemy.GetComponent<Enemymove>().target_pos;
            }
            transform.LookAt(target);
        }
        else
        {
            transform.localRotation = Quaternion.identity;
        }
        dogu = enemy.GetComponent<Enemymove>().dogu;
        
        if(particle.isPlaying && time[1] > chongshutlatetime)
        {
            particle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            time[1] = 0;
        }
    }
    void chongshut()
    {
        if (time[0] > chongshutlatetime)
        {
            particle.Play();
            float randx = Random.Range(-0.5f, 0.5f);
            float randy = Random.Range(-0.5f, 0.5f);
            Vector3 randpos = new Vector3(randx + transform.rotation.eulerAngles.x, randy + transform.rotation.eulerAngles.y, 0);

            //var chogalll = Instantiate(chongal, transform.position, Quaternion.Euler(randpos));
            var chogalll = game_object_pool.InstantiatesObject("chongal_shooted", transform.position + transform.forward, Quaternion.Euler(randpos));
            chogalll.GetComponent<shongal_shouted>().damage = chongdam;
            chogalll.GetComponent<shongal_shouted>().speed = chongspeed;
            for(int i = 0; i < audios.Length; i++)
            {
                if (!audios[i].isPlaying)
                {
                    audios[i].Play();
                    break;
                }
            }
            time[0] = 0;

        }
    }
    void hwalshut()
    {
        if (time[0] > 0.7f)
        {
            Vector3 dua = target - transform.position;
            //Instantiate(hwasal, hwasalpos.position - transform.right * 0.2f, Quaternion.LookRotation(dua.normalized));
            game_object_pool.Instantiates("hwasal_shotted1", hwasalpos.position - transform.right * 0.2f, Quaternion.LookRotation(dua.normalized));
            time[0] = 0;
        }
    }
    void attack()
    {
        int damage = 0;
        if (time[0] > timesdwds)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 4))
            {
                animationperson.Attacked();
                if (dogu == "gum")
                {
                    damage = 5 * 7;
                    timesdwds = 0.5f;
                }
                else if (dogu == "chulgum")
                {
                    damage = 5 * 12;
                    timesdwds = 0.5f;
                }
                else if (dogu == "namuGock")
                {
                    damage = 5 * 4;
                    timesdwds = 0.5f;
                }
                else if (dogu == "dollGock")
                {
                    damage = 5 * 3;
                    timesdwds = 0.5f;
                }
                else if (dogu == "chulnamuGock")
                {
                    damage = 5 * 5;
                    timesdwds = 0.5f;
                }
                else if (dogu == "chulGock")
                {
                    damage = 5 * 4;
                    timesdwds = 0.5f;
                }
                else if (dogu == "dril")
                {
                    damage = 5 * 7;
                    timesdwds = 0.05f;
                }
                else if (dogu == "chuldangum")
                {
                    damage = 5 * 6;
                    timesdwds = 0.2f;
                }
                else
                {
                    timesdwds = 0.5f;
                    damage = 5;
                }
                damage = (int)(damage * dam_ratio);
                if (hit.collider.tag == "Player")
                {
                    hit.collider.GetComponent<Rigidbody>().AddForce((hit.point - transform.position).normalized + Vector3.up, ForceMode.VelocityChange);
                    if (hit.collider.GetComponent<PlayerHand>().PickUpF == "gapock")
                    {
                        hit.collider.GetComponent<Player_Hp>().PlayerHp -= (damage / 2) * PlayerSettings.Player.PlayerHitDmg;
                    }
                    else
                    {
                        hit.collider.GetComponent<Player_Hp>().PlayerHp -= damage * PlayerSettings.Player.PlayerHitDmg;
                    }
                    AudioManeger.Sound3D("punch", transform.position);
                }
                else if(hit.collider.tag == "SangMul")
                {
                    hit.collider.GetComponent<Rigidbody>().AddForce((hit.point - transform.position).normalized + Vector3.up, ForceMode.VelocityChange);
                    hit.collider.GetComponent<SangMul>().SangMul_Hp -= damage;
                    AudioManeger.Sound3D("punch", transform.position);
                }
                else if (hit.collider.tag == "Enemy" && enemypartys.CheckTeam(parentmove.Party, hit.collider.GetComponent<Enemymove>().Party) == "enemy")
                {
                    hit.collider.GetComponent<Rigidbody>().AddForce((hit.point - transform.position).normalized + Vector3.up, ForceMode.VelocityChange);
                    hit.collider.GetComponent<Enemymove>().Hp -= damage;
                    AudioManeger.Sound3D("punch", transform.position);
                }

                time[0] = 0;
            }
        }
    }
    public void tryattack()
    {
        if (dogu == "chong")
        {
            chongshut();
        }
        else if (dogu == "hwal")
        {
            hwalshut();
        }
        else
        {
            attack();
            animationperson.DisAimed();
        }
    }
}
