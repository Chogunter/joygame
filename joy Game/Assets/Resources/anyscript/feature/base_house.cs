using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class base_house : MonoBehaviour
{
    public List<GameObject> sangjas;
    List<SangJJasaveandload> sangja = new List<SangJJasaveandload>();

    [Serializable]
    public class materials
    {
        public string item;
        public int min;
        public int max;
        public float percentage;
    }

    [Serializable]
    public class items
    {
        public List<materials> material = new List<materials>();
    }
    public List<items> itemm = new List<items>();

    Transform Player;

    public float[] time = new float[3]; // 0 : 아이템  1 : 거리재기  2 : 적 소환

    [SerializeField] float ITemCycleTime;
    [SerializeField] float MinPlayerDisForItemReset;
    [SerializeField] float EnemySummonTime;

    GameObjectPool game_object_pool;

    [Serializable]
    public class enemysummon
    {
        public Transform pos;
        public string enemy;
    }
    [SerializeField] List<enemysummon> summonList;

    [Serializable]
    public class ddddd
    {
        public string name;
        public int Hp;
        public GameObject aaa;
    }
    public List<ddddd> aaaaa = new List<ddddd>();
    public List<int> aaaaa_Hps;

    //[SerializeField] bool isonlyvehicle = false;
    //[SerializeField] float isonlyvehicle_resettime;

    void Resets()
    {
        for (int i = 0; i < sangjas.Count; i++)
        {
            if(sangja.Count >= sangjas.Count)
            {
                continue;
            }
            sangja.Add(sangjas[i].GetComponent<SangJJasaveandload>());
        }
        for(int j = 0; j < sangja.Count; j++)
        {
            sangja[j].Item1 = "none";
            sangja[j].Item2 = "none";
            sangja[j].num1 = 0;
            sangja[j].num2 = 0;
        }

        for (int i = 0; i < itemm.Count; i++)
        {
            for (int j = 0; j < itemm[i].material.Count; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    materials a = itemm[i].material[j];
                    int b = UnityEngine.Random.Range(1, 101);
                    if (100 - a.percentage <= b)
                    {
                        if (sangja[i].num1 == 0)
                        {
                            sangja[i].Item1 = a.item;
                            sangja[i].num1 = UnityEngine.Random.Range(a.min, a.max + 1);
                        }
                        else if (sangja[i].num2 == 0)
                        {
                            sangja[i].Item2 = a.item;
                            sangja[i].num2 = UnityEngine.Random.Range(a.min, a.max + 1);
                        }
                    }
                }
            }
        }
    }

    private void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Player = GameObject.Find("Player").transform;
        Hp_load();
        //Resets();
    }

    float dis;

    private void Update()
    {
        for(int i = 0; i < time.Length; i++)
        {
            time[i] += Time.deltaTime;
        }
        if(time[1] > 10)
        {
            dis = Vector3.Distance(transform.position, Player.position);
            time[1] = 0;
        }
        if(time[0] > ITemCycleTime)
        {
            if(dis > MinPlayerDisForItemReset)
            {
                Resets();
                time[0] = 0;
            }
        }
        if(time[2] > EnemySummonTime)
        {
            if (dis > MinPlayerDisForItemReset)
            {
                Summon();
                time[2] = 0;
            }
        }
    }

    public List<GameObject> enemyspone = new List<GameObject>();

    void Summon()
    {
        if (enemyspone != null)
        {
            for (int i = 0; i < enemyspone.Count; i++)
            {
                if (enemyspone[i].GetComponent<getonVehicle>())
                {
                    //if(isonlyvehicle && time[2] < isonlyvehicle_resettime)
                    //{
                    //    return;
                    //}
                    if (Vector3.Distance(transform.position, enemyspone[i].transform.position) <= 30)
                    {
                        enemyspone[i].SetActive(false);
                    }
                    continue;
                }
                if (enemyspone[i].activeSelf)
                {
                    //return;
                    enemyspone[i].SetActive(false);
                }
            }
            for (int i = 0; i < enemyspone.Count; i++)
            {
                enemyspone.RemoveAt(i);
            }
        }
        foreach(enemysummon a in summonList)
        {
            if (a.enemy == "Boat" || a.enemy == "Car" || a.enemy == "Helicopter")
            {
                for (int i = 0; i < enemyspone.Count; i++)
                {
                    if (enemyspone[i].GetComponent<getonVehicle>())
                    {
                        if (Vector3.Distance(a.pos.position, enemyspone[i].transform.position) <= 30)
                        {
                            goto abcde;
                        }
                    }
                }
            }
            var b = game_object_pool.InstantiatesObject(a.enemy, a.pos.position, a.pos.rotation);
            enemyspone.Add(b);
            abcde: continue;
        }
    }

    void Hp_load()
    {
        for(int i = 0; i < aaaaa.Count; i++)
        {
            if(aaaaa_Hps.Count - 1 < i)
            {
                break;
            }
            if(aaaaa[i].name == "namu")
            {
                aaaaa[i].aaa.GetComponent<NamuScript>().Hp = aaaaa_Hps[i];
            }
            else if (aaaaa[i].name == "doll")
            {
                aaaaa[i].aaa.GetComponent<DollScript>().Hp = aaaaa_Hps[i];
            }
            else if (aaaaa[i].name == "build")
            {
                aaaaa[i].aaa.GetComponent<Buildingbreak>().HP = aaaaa_Hps[i];
            }
            else if(aaaaa[i].name == "enemy")
            {
                aaaaa[i].aaa.GetComponent<Enemymove>().Hp = aaaaa_Hps[i];
            }
            else if(aaaaa[i].name == "monster")
            {
                aaaaa[i].aaa.GetComponent<monsterscript>().Hp = aaaaa_Hps[i];
            }
            else if (aaaaa[i].name == "close_boss")
            {
                aaaaa[i].aaa.GetComponent<close_boss>().Hp = aaaaa_Hps[i];
            }
            else if (aaaaa[i].name == "long_boss")
            {
                aaaaa[i].aaa.GetComponent<long_boss>().Hp = aaaaa_Hps[i];
            }
        }
    }
    public void Hp_Save()
    {
        for(int i = 0; i < aaaaa.Count; i++)
        {
            if(aaaaa_Hps.Count > i)
            {
                aaaaa_Hps[i] = aaaaa[i].Hp;
            }
            aaaaa_Hps.Add(aaaaa[i].Hp);
        }
    }
}
