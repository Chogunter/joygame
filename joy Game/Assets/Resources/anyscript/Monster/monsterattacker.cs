using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterattacker : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] GameObject monsterbumwii;
    GameObject Player;
    float time;
    [SerializeField] List<GameObject> dww;
    [SerializeField] ParticleSystem particle;
    float particletime;
    void Start()
    {
        //Physics.IgnoreCollision(monster.GetComponent<BoxCollider>(), GetComponent<BoxCollider>());
        //Physics.IgnoreCollision(monsterbumwii.GetComponent<SphereCollider>(), GetComponent<BoxCollider>());
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        particletime += Time.deltaTime;
        time += Time.deltaTime;
        if(particletime > 2)
        {
            particle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
        if (time > 0.5f)
        {
            particletime = 0;
            particle.Play();
            if (dww != null)
            {
                for (int i = 0; i < dww.Count; i++)
                {
                    if (dww[i] != null)
                    {
                        if (dww[i].tag == "SangMul")
                        {
                            dww[i].GetComponent<SangMul>().SangMul_Hp -= 60;
                        }
                        else if (dww[i].tag == "Enemy")
                        {
                            dww[i].GetComponent<Enemymove>().Hp -= 80;
                        }
                        else if (dww[i].GetComponent<close_boss>())
                        {
                            dww[i].GetComponent<close_boss>().Hp -= 50;
                        }
                        else if (dww[i].GetComponent<long_boss>())
                        {
                            dww[i].GetComponent<long_boss>().Hp -= 50;
                        }
                        else if (dww[i].tag == "Player")
                        {
                            if (Player.GetComponent<PlayerHand>().PickUpF == "gapock")
                                dww[i].GetComponent<Player_Hp>().PlayerHp -= 20 * PlayerSettings.Player.PlayerHitDmg;
                            else
                                dww[i].GetComponent<Player_Hp>().PlayerHp -= 80 * PlayerSettings.Player.PlayerHitDmg;
                        }
                        else if (dww[i].GetComponent<Buildingbreak>())
                        {
                            dww[i].GetComponent<Buildingbreak>().HP -= 100;
                        }
                    }
                }
                time = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!dww.Contains(other.gameObject))
        {
            dww.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (dww.Contains(other.gameObject))
        {
            dww.Remove(other.gameObject);
        }
    }
}
