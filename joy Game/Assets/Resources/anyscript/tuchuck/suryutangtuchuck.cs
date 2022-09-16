using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suryutangtuchuck : MonoBehaviour
{
    RaycastHit hit;
    Rigidbody rb;
    //[SerializeField] float force;
    [SerializeField] float dis;
    [SerializeField] GameObject thisthat;
    public float time = 0;
    public List<GameObject> disobject;
    GameObject Player;
    GameObject audios;
    GameObject Enpty;
    Dig_Particles_cs diger;
    void Awake()
    {
        Player = GameObject.Find("Player");
        audios = GameObject.Find("Player_sound");
        Enpty = GameObject.Find("Enpty");
        diger = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * force);
    }

    private void OnEnable()
    {
        time = 0;
        rb.AddTorque(Vector3.right * 10);
    }
    void Update()
    {
        disobject = thisthat.GetComponent<suryutangpockbaldis>().gamob;
        time += Time.deltaTime;
        if(time > 3)
        {
            pang(dis);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    void pang(float dis)
    {
        diger.Particle(transform.position, "suryutang");
        audios.GetComponent<Player_sound_effect>().Sound3D("boom", transform.position);
        if (Vector3.Distance(transform.position, audios.transform.position) <= 25f)
        {
            float a = (25 - Vector3.Distance(transform.position, audios.transform.position)) / 15;
            if (a > 1)
                a = 1;
            if (a < 0)
                a = 0;
            Enpty.GetComponent<CameraMover>().screen_shake(a, 0.4f);
        }
        for (int i = 0; i < disobject.Count; i++)
        {
            if ((disobject[i] != null && (Vector3.Distance(transform.position, disobject[i].transform.position) < 14 && disobject[i].tag != "badack")) ||
                disobject[i] != null && disobject[i].tag == "badack" && Vector3.Distance(transform.position, disobject[i].transform.position + Vector3.up * 49) < 14)
            {
                if (disobject[i].tag == "Player")
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (hit.collider.tag == "Player")
                        {
                            int dam;
                            if (Player.GetComponent<PlayerHand>().PickUpF == "gapock")
                            {
                                dam = (600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45) / 2;
                            }
                            else
                            {
                                dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            }
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<Player_Hp>().PlayerHp -= dam;
                            }
                        }
                    }
                }
                else if (disobject[i].tag == "SangMul")
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (hit.collider.tag == "SangMul")
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<SangMul>().SangMul_Hp -= dam;
                            }
                        }
                    }
                }
                else if (disobject[i].tag == "Monsters")
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (hit.collider.tag == "Monsters")
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<monsterscript>().Hp -= dam;
                            }
                        }
                    }
                }
                else if (disobject[i].GetComponent<close_boss>())
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (disobject[i].GetComponent<close_boss>())
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            if (dam > 0)
                            {
                                if (disobject[i].GetComponent<close_boss>())
                                {
                                    disobject[i].GetComponent<close_boss>().Hp -= dam;
                                }
                            }
                        }
                    }
                }
                else if (disobject[i].GetComponent<long_boss>())
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (disobject[i].GetComponent<long_boss>())
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            if (dam > 0)
                            {
                                if (disobject[i].GetComponent<long_boss>())
                                {
                                    disobject[i].GetComponent<long_boss>().Hp -= dam;
                                }
                            }
                        }
                    }
                }
                else if (disobject[i].tag == "Enemy")
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (hit.collider.tag == "Enemy")
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 45;
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<Enemymove>().Hp -= dam;
                            }
                        }
                    }
                }
                else if (disobject[i].tag == "badack")
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (hit.collider.tag == "badack")
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position + Vector3.up * 49, transform.position) * 60;
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<Buildingbreak>().HP -= dam;
                            }
                        }
                    }
                }
                else if (disobject[i].GetComponent<Buildingbreak>())
                {
                    if (Physics.Raycast(transform.position, disobject[i].transform.position - transform.position, out hit, dis))
                    {
                        if (disobject[i].GetComponent<Buildingbreak>())
                        {
                            int dam;
                            dam = 600 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                            if (dam > 0)
                            {
                                disobject[i].GetComponent<Buildingbreak>().HP -= dam;
                            }
                        }
                    }
                }
                if (disobject[i].GetComponent<Rigidbody>())
                {
                    Vector3 vec = ((disobject[i].transform.position - transform.position).normalized) * 3 + Vector3.up * 2;
                    disobject[i].GetComponent<Rigidbody>().AddForce(vec, ForceMode.Impulse);
                    disobject[i].GetComponent<Rigidbody>().AddTorque(Vector3.up * 3 + Vector3.right * 3);
                }
            }
        }
    }
}
