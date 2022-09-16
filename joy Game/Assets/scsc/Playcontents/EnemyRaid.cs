using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRaid : MonoBehaviour
{
    [System.Serializable]
    public class RaidSingle
    {
        public string enemy;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class RaidBundle
    {
        public float StartDay;
        public float StartTime;
        public float RaidCycleday;
        public float RaidCycleStartTime;
        public List<RaidSingle> raids = new List<RaidSingle>();
        public float lateRaidDay;
    }

    [SerializeField] List<RaidBundle> RaidBundles = new List<RaidBundle>();
    List<RaidBundle> RaidBundledsdsds = new List<RaidBundle>();
    [SerializeField] TimeManager timemanager;
    List<RaidBundle> cycleraid = new List<RaidBundle>();
    [SerializeField] GameObjectPool game_objetc_pool;
    [SerializeField] Transform Player;

    void Start()
    {
        foreach (RaidBundle a in RaidBundles)
        {
            RaidBundledsdsds.Add(a);
        }
    }

    void Update()
    {
        foreach(RaidBundle a in RaidBundledsdsds)
        {
            if(timemanager.days >= a.StartDay)
            {
                if(timemanager.times > a.StartTime)
                {
                    cycleraid.Add(a);
                    a.lateRaidDay = timemanager.days;
                    attack(a);
                }
            }
        }
        foreach(RaidBundle b in cycleraid)
        {
            if (RaidBundledsdsds.Contains(b))
            {
                RaidBundledsdsds.Remove(b);
            }
            if(b.RaidCycleday + b.lateRaidDay <= timemanager.days)
            {
                if (b.RaidCycleStartTime <= timemanager.times)
                {
                    b.lateRaidDay = timemanager.days;
                    attack(b);
                }

            }

        }

    }

    void attack(RaidBundle ba)
    {
        Debug.Log("Attack!");
        foreach(RaidSingle a in ba.raids)
        {
            game_objetc_pool.Instantiates(a.enemy, a.pos + Player.position, a.rot);
        }
    }
}
