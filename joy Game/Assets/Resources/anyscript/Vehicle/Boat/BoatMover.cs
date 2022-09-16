using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMover : MonoBehaviour
{
    Rigidbody rb;
    float posy;
    public float speed;
    public bool Bool;
    bool sss;
    [SerializeField]
    bool bbb;
    Vector3 pos;
    public GameObject SangJa;
    bool aaaeeeooo;
    float time;
    //ParticleSystem particlesystem;

    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>(); //0:켜기 1:끄기
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioSource audiosourcedrive;
    bool engineononce;
    bool engineoffonce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posy = transform.position.y;
        pos = transform.position;
        //particlesystem = gameObject.GetComponent<ParticleSystem>();
    }
    
    void Update()
    {
        if (aaaeeeooo)
        {
            if (engineononce)
            {
                Audioplay(audioClips[0], true);
                audiosourcedrive.Play();
                engineononce = false;
            }
            engineoffonce = true;
        }
        else
        {
            if (engineoffonce)
            {
                Audioplay(audioClips[1], true);
                audiosourcedrive.Stop();
                engineoffonce = false;
            }
            engineononce = true;
        }
        if(((SangJa.GetComponent<SangJJasaveandload>().Item1 == "namu" &&
            SangJa.GetComponent<SangJJasaveandload>().num1 > 0) ||
            (SangJa.GetComponent<SangJJasaveandload>().Item2 == "namu" &&
            SangJa.GetComponent<SangJJasaveandload>().num2 > 0)) &&
            GetComponent<getonVehicle>().Bool)
        {
            time += Time.deltaTime;
            aaaeeeooo = true;
            if(time > 2f)
            {
                if(SangJa.GetComponent<SangJJasaveandload>().Item1 == "namu" &&
                    SangJa.GetComponent<SangJJasaveandload>().num1 > 0)
                {
                    SangJa.GetComponent<SangJJasaveandload>().num1 -= 1;
                }
                else if (SangJa.GetComponent<SangJJasaveandload>().Item2 == "namu" &&
                    SangJa.GetComponent<SangJJasaveandload>().num2 > 0)
                {
                    SangJa.GetComponent<SangJJasaveandload>().num2 -= 1;
                }
                time = 0f;
            }
        }
        else
        {
            aaaeeeooo = false;
        }
        //transform.position = new Vector3(transform.position.x, posy, transform.position.z);
        if (GetComponent<getonVehicle>().Bool && aaaeeeooo)
        {
            Bool = true;
            pos = transform.position;
            rb.isKinematic = false;
        }
        else
        {
            Bool = false;
            transform.position = pos;
            rb.isKinematic = true;
        }
        if(rb.velocity.z > 2.5f || rb.velocity.x > 2.5f || rb.velocity.z < -2.5f || rb.velocity.x < -2.5f)
        {
            sss = true;
        }
        else
        {
            sss = false;
        }
        if(rb.velocity.z > 60f || rb.velocity.x > 60f || rb.velocity.z < -60f || rb.velocity.x < -60f)
        {
            bbb = false;
        }
        else
        {
            bbb = true;
        }
    }
    private void FixedUpdate()
    {
        if (Bool)
        {
            if (Input.GetKey(KeyCode.W) && bbb)
            {
                rb.AddRelativeForce(Vector3.forward * speed);
            }
            if (sss)
            {

                float y = Input.GetAxis("Horizontal");
                transform.Rotate(y * Vector3.up);
            }
        }
    }

    void Audioplay(AudioClip audio, bool ad)
    {
        if (ad)
        {
            audiosource.Stop();
        }
        if (!audiosource.isPlaying)
        {
            audiosource.clip = audio;
            audiosource.Play();
        }
    }
}
