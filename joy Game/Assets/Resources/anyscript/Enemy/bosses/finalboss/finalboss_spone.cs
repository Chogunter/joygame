using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalboss_spone : MonoBehaviour
{
    GameObjectPool game_object_pool;
    public List<GameObject> bumwii;
    public bool isboss_sponed = false;

    Dig_Particles_cs DigParticleManager;

    float sponetime = 0;
    bool fffffffffff = false;
    bool sponeprepareonce = true;

    Player_sound_effect AudioManeger;

    Vector3 setadvanced_workbenchpos;

    private void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        DigParticleManager = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        sponetime = 0;
        fffffffffff = false;
        sponeprepareonce = true;

        setadvanced_workbenchpos = transform.position + Vector3.up * 0.5f;

        isboss_sponed = false;
    }
    int aaa = 0;

    private void Start()
    {
        SurchIsCleared();
    }

    void SurchIsCleared()
    {
        List<GameObject> fffffff = new List<GameObject>();
        for(int i = 0; i < game_object_pool.Object.Count; i++)
        {
            if(game_object_pool.Object[i].name == "advanced_workbench")
            {
                for(int j = 0; j < game_object_pool.Object[i].ObjectItem.Count; j++)
                {
                    fffffff.Add(game_object_pool.Object[i].ObjectItem[j]);
                }
                break;
            }
        }
        foreach(GameObject adadaaacadac in fffffff)
        {
            if(adadaaacadac.transform.position == setadvanced_workbenchpos)
            {
                isboss_sponed = true;
            }
        }
    }

    void Update()
    {
        if (fffffffffff)
        {
            sponetime += Time.deltaTime;
            if(sponetime > 4 && sponeprepareonce)
            {
                Vector3 finalsponepos = transform.position.x * Vector3.right + transform.position.z * Vector3.forward + Vector3.up * 30;
                DigParticleManager.Particle(finalsponepos, "finalboss_summon_preparation");
                sponeprepareonce = false;
                AudioManeger.Sound("subway_enter");
            }
            if (sponetime > 7)
            {
                realspone();
                fffffffffff = false;
            }
        }
        if (isboss_sponed)
        {
            return;
        }
        aaa = 0;
        for(int i = 0; i < bumwii.Count; i++)
        {
            if (bumwii[i].activeSelf)
            {
                aaa++;
            }
        }
        if(aaa >= 5)
        {
            boss_spone();
        }
    }

    void boss_spone()
    {
        isboss_sponed = true;
        for (int i = 0; i < bumwii.Count; i++)
        {
            if (bumwii[i].activeSelf)
            {
                bumwii[i].SetActive(false);
                DigParticleManager.Particle(bumwii[i].transform.position, "core_annihilation");
            }
        }
        Vector3 finalsponepos = transform.position.x * Vector3.right + transform.position.z * Vector3.forward + Vector3.up * 30;
        fffffffffff = true;
        AudioManeger.Sound("finalboss_ringing");
    }
    void realspone()
    {
        AudioManeger.Sound("beam");
        Vector3 finalsponepos = transform.position.x * Vector3.right + transform.position.z * Vector3.forward + Vector3.up * 30;
        DigParticleManager.Particle(finalsponepos, "final_boss_summon");
        //스폰
        var that = game_object_pool.InstantiatesObject("finalboss", finalsponepos - Vector3.up * 30, Quaternion.identity);
        that.GetComponent<final_boss>().Stage = gameObject;
    }

    public void clear()
    {
        game_object_pool.InstantiatesObject("advanced_workbench", setadvanced_workbenchpos, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<DoguThrow>())
        {
            return;
        }
        else if(other.GetComponent<DoguThrow>().The_Dogu != "puplecore")
        {
            return;
        }
        if (!bumwii.Contains(other.gameObject))
        {
            bumwii.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (bumwii.Contains(other.gameObject))
        {
            bumwii.Remove(other.gameObject);
        }
    }
}
