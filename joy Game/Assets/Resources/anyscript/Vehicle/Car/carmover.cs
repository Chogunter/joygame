using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmover : MonoBehaviour
{
    public WheelCollider colliderFR;

    public WheelCollider colliderFL;

    public WheelCollider colliderRR;

    public WheelCollider colliderRL;



    // 바퀴 회전을 위한 Transform

    public Transform wheelTransformFL;

    public Transform wheelTransformFR;

    public Transform wheelTransformRL;

    public Transform wheelTransformRR;



    public int maxTorque;

    Rigidbody rigidbody;
    GameObject Player;
    public GameObject SangJa;
    public GameObject SangJacarrier;
    [SerializeField]
    bool aaaeeeooo;
    public GameObject handle;
    bool isbada;
    bool sss;
    public GameObject roadkillzone;
    public GameObject instrument_panel;


    [SerializeField] List<AudioClip> audioclips = new List<AudioClip>(); // 0:켜기 1:가속 2:감속 3:끄기
    [SerializeField] float[] time;
    AudioSource audiosource;
    bool engineonconce;
    bool engineoffonce;
    [SerializeField] AudioSource audioooooo;
    //float lastvelocity;
    // Use this for initialization

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
        maxTorque = 45;

        rigidbody.centerOfMass = new Vector3(0, -1, 0); // 무게중심이 높으면 차가 쉽게 전복된다
        Player = GameObject.Find("Player");
    }

    private void OnEnable()
    {
        isbada = false;
    }

    private void Update()
    {
        roadkillzone.GetComponent<roadkillscript>().velocity = rigidbody.velocity.magnitude;
        instrument_panel.transform.localRotation = Quaternion.Euler(rigidbody.velocity.magnitude * Vector3.up * 3);
        if (transform.position.y <= -0.5)
        {
            if (!isbada)
            {
                this.GetComponent<getonVehicle>().Getoff(-transform.right);
                isbada = true;
            }
            if (transform.position.y <= -5.5)
            {
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (this.GetComponent<getonVehicle>().Bool)
        {
            Player.GetComponent<CapsuleCollider>().isTrigger = true;
            sss = true;

            if (((SangJa.GetComponent<SangJJasaveandload>().Item1 == "orangecore" &&
            SangJa.GetComponent<SangJJasaveandload>().num1 > 0) ||
            (SangJa.GetComponent<SangJJasaveandload>().Item2 == "orangecore" &&
            SangJa.GetComponent<SangJJasaveandload>().num2 > 0)))
            {
                aaaeeeooo = true;
            }
            else
            {
                aaaeeeooo = false;
            }
        }
        else
        {
            if (sss)
            {
                Player.GetComponent<CapsuleCollider>().isTrigger = false;
                sss = false;
            }
            if (!isbada)
            {
                rigidbody.velocity = Vector3.zero;
            }
        }
        //if(rigidbody.velocity.magnitude > lastvelocity)
        //{
        //    Audioplay(audioclips[1], false);
        //}
        //else if(rigidbody.velocity.magnitude < lastvelocity)
        //{
        //    Audioplay(audioclips[2], false);
        //}
        //lastvelocity = rigidbody.velocity.magnitude;
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if (this.GetComponent<getonVehicle>().Bool && aaaeeeooo)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                Audioplay(audioclips[1], false);
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                Audioplay(audioclips[2], false);
            }

            engineoffonce = true;
            if (engineonconce)
            {
                Audioplay(audioclips[0], true);
                audioooooo.Play();
                engineonconce = false;
            }
            handle.transform.localRotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * 45);
            //전진, 후진

            colliderRR.motorTorque = maxTorque * Input.GetAxis("Vertical");

            colliderRL.motorTorque = maxTorque * Input.GetAxis("Vertical");



            //좌우 방향전환

            colliderFR.steerAngle = 30 * Input.GetAxis("Horizontal");

            colliderFL.steerAngle = 30 * Input.GetAxis("Horizontal");



            // 바퀴회전효과

            wheelTransformFL.Rotate(0, colliderFL.rpm / 60 * 360 * Time.fixedDeltaTime, 0);

            wheelTransformFR.Rotate(0, colliderFR.rpm / 60 * 360 * Time.fixedDeltaTime, 0);

            wheelTransformRL.Rotate(0, colliderRL.rpm / 60 * 360 * Time.fixedDeltaTime, 0);

            wheelTransformRR.Rotate(0, colliderRR.rpm / 60 * 360 * Time.fixedDeltaTime, 0);
        }
        else
        {
            if (engineoffonce)
            {
                Audioplay(audioclips[3], true);
                audioooooo.Stop();
                engineoffonce = false;
            }
            colliderRR.motorTorque = 0;
            colliderRL.motorTorque = 0;
            colliderFR.steerAngle = 0;
            colliderFL.steerAngle = 0;
            engineonconce = true;
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
