using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4tuchuck : MonoBehaviour
{
    RaycastHit hit;
    //[SerializeField] float force;
    [SerializeField] float dis;
    [SerializeField] GameObject that;
    List<GameObject> disobject;
    Rigidbody rb;
    GameObject Player;
    GameObject audios;
    GameObject Enpty;
    Dig_Particles_cs diger;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * force);
        Player = GameObject.Find("Player");
        audios = GameObject.Find("Player_sound");
        Enpty = GameObject.Find("Enpty");
        diger = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            disobject = that.GetComponent<C4pockbaldis>().gamob;
            pang(dis);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    void pang(float dis)
    {
        diger.Particle(transform.position, "C4");
        audios.GetComponent<Player_sound_effect>().Sound3D("boom", transform.position);
        if (Vector3.Distance(transform.position, audios.transform.position) <= 30f)
        { 
            float a = (30 - Vector3.Distance(transform.position, audios.transform.position)) / 15;
            if (a > 1)
                a = 1;
            if (a < 0)
                a = 0;
            Enpty.GetComponent<CameraMover>().screen_shake(a, 0.7f);
        }
        for (int i = 0; i < disobject.Count; i++)
        {
            if ((disobject[i] != null && (Vector3.Distance(transform.position, disobject[i].transform.position) < 5 && disobject[i].tag != "badack")) ||
                disobject[i] != null && disobject[i].tag == "badack" && Vector3.Distance(transform.position, disobject[i].transform.position + Vector3.up * 49) < 5)
            {
                if (disobject[i].tag == "Player")
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;

                    if (dam > 0)
                    {
                        disobject[i].GetComponent<Player_Hp>().PlayerHp -= dam;
                    }
                }
                else if (disobject[i].tag == "SangMul")
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        disobject[i].GetComponent<SangMul>().SangMul_Hp -= dam;
                    }
                }
                else if (disobject[i].tag == "Monsters")
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        disobject[i].GetComponent<monsterscript>().Hp -= dam;
                    }
                }
                else if (disobject[i].GetComponent<close_boss>())
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        if (disobject[i].GetComponent<close_boss>())
                        {
                            disobject[i].GetComponent<close_boss>().Hp -= dam;
                        }
                    }
                }
                else if (disobject[i].GetComponent<long_boss>())
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        if (disobject[i].GetComponent<long_boss>())
                        {
                            disobject[i].GetComponent<long_boss>().Hp -= dam;
                        }
                    }
                }
                else if (disobject[i].tag == "Enemy")
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        disobject[i].GetComponent<Enemymove>().Hp -= dam;
                    }
                }
                else if(disobject[i].tag == "badack")
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position + Vector3.up * 49, transform.position) * 60;
                    if (dam > 0)
                    {
                        disobject[i].GetComponent<Buildingbreak>().HP -= dam;
                    }
                }
                else if (disobject[i].GetComponent<Buildingbreak>())
                {
                    int dam;
                    dam = 3000 - (int)Vector3.Distance(disobject[i].transform.position, transform.position) * 60;
                    if (dam > 0)
                    {
                        disobject[i].GetComponent<Buildingbreak>().HP -= dam;
                    }
                }
                if (disobject[i].GetComponent<Rigidbody>())
                {
                    Vector3 vec = ((disobject[i].transform.position - transform.position).normalized) * 10 + Vector3.up * 5;
                    disobject[i].GetComponent<Rigidbody>().AddForce(vec, ForceMode.Impulse);
                    disobject[i].GetComponent<Rigidbody>().AddTorque(Vector3.up * 3 + Vector3.right * 3);
                }
            }
        }
    }
}
