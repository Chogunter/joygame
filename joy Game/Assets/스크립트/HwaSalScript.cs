using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HwaSalScript : MonoBehaviour
{
    public int force;
    Rigidbody rb;
    private bool s = true;
    public float time = 0f;
    float time2;

    Vector3 move;
    [SerializeField] bool IsPlayersthisg;

    GameObject target;
    GameObject rotrotrot;

    Player_sound_effect AudioManeger;
    Dig_Particles_cs DigParticleManager;
    CameraMover Shake;
    void Awake()
    {
        target = GameObject.Find("1");
        rotrotrot = GameObject.Find("Enpty");
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        DigParticleManager = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        Shake = GameObject.Find("Enpty").GetComponent<CameraMover>();
        rb = GetComponent<Rigidbody>();

    }

    private void OnEnable()
    {
        rb.velocity = Vector3.zero;
        time = 0;
        if (IsPlayersthisg)
        {
            transform.rotation = rotrotrot.transform.rotation;
            move = target.transform.position;
        }
    }
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        //time2 += Time.deltaTime;

        //transform.position = Vector3.MoveTowards(transform.position, move, 0.5f);
        rb.AddForce(transform.forward * force);

        if (time > 2f)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SangMul")
        {
            DigParticleManager.Particle(transform.position, "blood");
            Shake.screen_shake(0.1f, 0.1f);
            other.GetComponent<SangMul>().Hwasalhit();
            //Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManeger.Sound3D("punch", transform.position);
        }
        else if (other.tag == "Monsters")
        {
            DigParticleManager.Particle(transform.position, "blood");
            Shake.screen_shake(0.1f, 0.1f);
            other.GetComponent<monsterscript>().Hp -= 20;
            //Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManeger.Sound3D("punch", transform.position);
        }
        else if (other.tag == "boss")
        {
            Shake.screen_shake(0.1f, 0.1f);
            other.GetComponent<monsterscript>().Hp -= 5;
            //Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManeger.Sound3D("punch", transform.position);
        }
        else if (other.tag == "Enemy" && IsPlayersthisg)
        {
            DigParticleManager.Particle(transform.position, "blood");
            Shake.screen_shake(0.1f, 0.1f);
            other.GetComponent<Enemymove>().Hp -= 20;
            //Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManeger.Sound3D("punch", transform.position);
        }
        else if (other.tag == "Player" && !IsPlayersthisg)
        {
            DigParticleManager.Particle(transform.position, "blood");
            Shake.screen_shake(0.1f, 0.1f);
            other.GetComponent<Player_Hp>().PlayerHp -= 20;
            //Destroy(gameObject);
            gameObject.SetActive(false);
            AudioManeger.Sound3D("punch", transform.position);
        }
        else if(time > 0.1f && other.tag != "Donttrigger")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
