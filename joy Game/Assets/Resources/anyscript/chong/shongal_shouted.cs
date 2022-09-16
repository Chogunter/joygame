using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shongal_shouted : MonoBehaviour
{
    public float speed;
    public int damage;
    bool aaa;
    public float time;
    public float killtime;
    Rigidbody rb;
    Dig_Particles_cs Diger;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Diger = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        aaa = true;
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
        aaa = true;
        time = 0;
    }

    RaycastHit hit;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, (transform.forward * speed).magnitude / Time.deltaTime))
        {
            transform.position = hit.point;
            ahit(hit.collider);
        }
        else
        {
            //transform.position += transform.forward.normalized * speed * Time.deltaTime;
            //rb.velocity = transform.forward.normalized * speed * Time.deltaTime;
            transform.position += transform.forward * speed * Time.deltaTime;
            time += Time.deltaTime;
            if (time > killtime)
            {
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        aaa = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        ahit(other);
    }

    private void ahit(Collider other)
    {
        if (!aaa || other.tag == "Donttrigger")
        {
            return;
        }
        if (other.tag == "SangMul")
        {
            Diger.Particle(transform.position, "blood");
            other.gameObject.GetComponent<SangMul>().SangMul_Hp -= damage;
        }
        else if (other.GetComponent<Buildingbreak>())
        {
            Diger.Particle(transform.position, "doll");
            other.gameObject.GetComponent<Buildingbreak>().HP -= damage;
        }
        else if (other.tag == "Monsters")
        {
            Diger.Particle(transform.position, "blood");
            other.gameObject.GetComponent<monsterscript>().Hp -= damage;
        }
        else if (other.tag == "Player")
        {
            Diger.Particle(transform.position, "blood");
            other.gameObject.GetComponent<Player_Hp>().PlayerHp -= damage;
        }
        else if (other.tag == "Enemy")
        {
            Diger.Particle(transform.position, "blood");
            other.gameObject.GetComponent<Enemymove>().Hp -= damage;
        }
        else if (other.GetComponent<close_boss>())
        {
            other.GetComponent<close_boss>().Hp -= damage;
        }
        else if (other.GetComponent<long_boss>())
        {
            other.GetComponent<long_boss>().Hp -= damage;
        }
        else if (other.tag == "Item Namu")
        {
            Diger.Particle(transform.position, "namu");
        }
        else if (other.tag == "Item Doll")
        {
            Diger.Particle(transform.position, "doll");
        }
        else if (other.tag == "Item chul")
        {
            Diger.Particle(transform.position, "chul");
        }
        else
        {
            Diger.Particle(transform.position, "chongalParticle");
        }
        //Debug.Log(other.name);
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
