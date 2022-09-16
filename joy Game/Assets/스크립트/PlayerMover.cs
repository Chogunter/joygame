using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMover : MonoBehaviour
{

    public Text ScriptTxt;
    public Text ScriptTxt2;
    public Camera cam; //메인카메라

    public float speed = 0.5f; // 이동속도
    public float realspeed;

    private Rigidbody playerRigidbody;

    public float Jumppower = 200f;
    private int JumpCount = 0;
    private bool isGround = false;

    private float time;

    public float energy = 10;
    private float energyTime;
    public float energyTimelate;

    public bool DoguUsing = false;

    public Text text;
    public Slider slider;
    public int giryock;
    public GameObject slider2;

    public Vector3 pos;
    public Vector3 move;

    private bool Badain;

    private bool moves;
    private bool movessssss;

    public bool dontrun;

    public float wheelspeed;

    RaycastHit hit;
    public float raydistance;

    bool jumpping;

    public bool IsgetonVehicle;
    public bool ishelgi = false;
    public GameObject inven;

    GameObject AudioManager;
    float time123 = 12f;
    float time1231 = 10f;
    bool a = false;
    bool adadawd = false;

    bool badainfirst = false;

    [SerializeField] ParticleSystem JumpParticle;
    [SerializeField] float JumpParticle_time;
    float JumpParticle_late_time;

    bool canlandsound;
    bool running;
    bool torun = true;
    bool towalk = false;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        AudioManager = GameObject.Find("Player_sound");
    }

    private void Update()
    {
        running = GetComponent<Player_Hp>().running;
        if (true)
        {
            Jumppower = PlayerSettings.Player.PLayerJumpPower;
            energy = PlayerSettings.Player.PlayerEnergyMax;
        }

        if (true) //파티클관련
        {
            if (JumpParticle_late_time < JumpParticle_time)
            {
                JumpParticle_late_time += Time.deltaTime;
            }
            else
            {
                JumpParticle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
        }

        if (!DoguUsing && !IsgetonVehicle)
        {
            if (adadawd)
            {
                time123 += Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ||
                Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) ||
                Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                adadawd = true;
            }
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) ||
                Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) ||
                Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) ||
                Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                a = true;
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) ||
                 Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) ||
                 Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) ||
                 Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_walk");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("run");
                time123 = 12;
                adadawd = false;
                a = false;

                time123 = 12;
            }
            //Debug.Log("running : " + running.ToString() + "\ntime123 : " + time123.ToString());

            if (isGround && adadawd && ((!running && time123 > 12) || (running && time123 > 9)))
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("run");
                if (running)
                {
                    AudioManager.GetComponent<Player_sound_effect>().Sound("run");
                }
                else
                {
                    AudioManager.GetComponent<Player_sound_effect>().Sound("walk");
                }
                time123 = 0;
            }
            if(isGround && adadawd && ((!running && time123 < 12) || (running && time123 < 9)))
            {
                if (running && torun)
                {
                    towalk = true;
                    torun = false;
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("run");
                    AudioManager.GetComponent<Player_sound_effect>().SoundWithTime("run", time123 / 1.33f);
                }
                if (!running && towalk)
                {
                    towalk = false;
                    torun = true;
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("run");
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
                    AudioManager.GetComponent<Player_sound_effect>().SoundWithTime("walk", time123);
                }
            }
            if (Badain && adadawd && time123 > 12)
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_walk");
                AudioManager.GetComponent<Player_sound_effect>().Sound("water_walk");
                time123 = 0;
            }
            if (!isGround && !Badain)
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("run");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_walk");
                time123 = 12;
                a = false;
                adadawd = false;
            }
            if (Badain)
            {
                time1231 += Time.deltaTime;
                if (time1231 > 10)
                {
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_pp");
                    AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_pour");
                    AudioManager.GetComponent<Player_sound_effect>().Sound("water_pour");
                    AudioManager.GetComponent<Player_sound_effect>().Sound("water_pp");
                    time1231 = 0;
                }
            }
            else
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_pour");
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_pp");
                time1231 = 10;
            }
            if (badainfirst && Badain)
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("diving");
                AudioManager.GetComponent<Player_sound_effect>().Sound("diving");
                badainfirst = false;
            }
            if (!Badain)
            {
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("diving");
                badainfirst = true;
            }
        }
        else
        {
            AudioManager.GetComponent<Player_sound_effect>().Soundoff("walk");
            AudioManager.GetComponent<Player_sound_effect>().Soundoff("water_walk");
        }

        bool sss;
        if (GetComponent<PlayerHand>().PickUp1 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp2 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp3 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp4 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp5 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp6 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUp7 == "dril")
            sss = true;
        else if (GetComponent<PlayerHand>().PickUpF == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[0] == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[1] == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[2] == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[3] == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[4] == "dril")
            sss = true;
        else if (inven.GetComponent<Invenmaniger>().items[5] == "dril")
            sss = true;
        else
            sss = false;
        speed = this.GetComponent<PlayerOption>().PlayerSpeed;
        wheelspeed = this.GetComponent<PlayerOption>().Moussegamdo;
        if (giryock >= 1)
        {
            this.GetComponent<Player_Hp>().HPs = true;
        }

        if (this.transform.position.y < -0.4f)
        {
            transform.position = new Vector3(transform.position.x, -0.4f, transform.position.z);
        }
        if(this.transform.position.y <= -0.4f)
        {
            Badain = true;
            this.GetComponent<Player_Hp>().running = false;
            realspeed = speed * 0.6f;
            energyTimelate += Time.deltaTime * 3;
            if (energyTimelate > energy)
                energyTimelate = energy;
            playerRigidbody.velocity = Vector3.zero;
        }
        else
        {
            Badain = false;
        }

        giryock = (int)energyTimelate;
        text.text = giryock + " / " + energy.ToString();
        slider.value = energyTimelate / energy;
        if (giryock <= 0)
            slider2.SetActive(false);
        if (energyTimelate > 0)
            slider2.SetActive(true);

        pos = this.gameObject.transform.position;
        ScriptTxt.text = realspeed.ToString();

        ScriptTxt2.text = energyTimelate.ToString();
        time += Time.deltaTime;
        if (DoguUsing || IsgetonVehicle)
        {
            move = Vector3.zero;
        }
        if (!DoguUsing && !ishelgi)
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X") * wheelspeed, 0f, Space.World);
        }
        if (!DoguUsing && !IsgetonVehicle)
        {
            if (true)
            {
                //transform.Rotate(0, Input.GetAxis("Mouse X") * wheelspeed, 0);
            }
            if (Physics.Raycast(transform.position, move * realspeed * Time.deltaTime * 3, out hit, raydistance))
            {
                //if(hit.collider.tag == "Sangja" || hit.collider.tag == "habsungi" ||
                //    hit.collider.tag == "yongwang" || hit.collider.tag == "chimdea" ||
                //    hit.collider.tag == "toibi" || hit.collider.tag == "JeaJack" ||
                //    hit.collider.tag == "build" || (transform.parent && hit.transform.parent.gameObject.tag == "Mun"))
                //{
                //    realspeed = 2;
                //}
                realspeed = 2;
            }
            float y = Input.GetAxis("Horizontal");
            float x = Input.GetAxis("Vertical");

            Vector3 dir = cam.transform.rotation * Vector3.forward;
            Vector3 dir2 = cam.transform.rotation * new Vector3(1, 0, 0);

            transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);

            //move = new Vector3(y, 0, x);
            move = transform.forward * x + transform.right * y;
            move.Normalize();
            //transform.Translate(move * Time.deltaTime * realspeed);
            //playerRigidbody.velocity = move;
            Move();

            if (Input.GetKey(KeyCode.Space) && isGround && !jumpping)
            {
                JumpParticle_late_time = 0;
                JumpParticle.Simulate(1, true, true);
                JumpParticle.Play(true);
                playerRigidbody.velocity = Vector3.zero;
                playerRigidbody.AddForce(Vector3.up * Jumppower, ForceMode.Impulse);
                AudioManager.GetComponent<Player_sound_effect>().Soundoff("jump");
                AudioManager.GetComponent<Player_sound_effect>().Sound("jump");
                jumpping = true;
            }
        }
        if (sss)
        {
            energyTimelate += Time.deltaTime;
            if(energyTimelate > energy)
            {
                energyTimelate = energy;
            }
            realspeed = speed;
            this.GetComponent<Player_Hp>().running = false; 
        }
        else if (!Badain)
        {
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && !DoguUsing && !dontrun)
            {
                //realspeed = speed * 2;
                if (energyTimelate > energy)
                {
                    realspeed = speed * 1.05f;
                    this.GetComponent<Player_Hp>().running = false;
                }
                else
                {
                    this.GetComponent<Player_Hp>().running = true;
                    realspeed = speed * 1.5f;
                    energyTimelate += Time.deltaTime;
                }
            }
            else
            {
                realspeed = speed;
                this.GetComponent<Player_Hp>().running = false;
                if (energyTimelate > 0)
                {
                    energyTimelate -= Time.deltaTime;
                }
            }
        }
        if (Badain)
        {
            if (Physics.Raycast(transform.position + Vector3.up * 0.23f, transform.forward, out landhit, 1))
            {
                if (landhit.collider.tag == "ground")
                {
                    if (!Physics.Raycast(transform.position + Vector3.up * 0.5f, transform.forward, out landhit, 1))
                    {
                        JumpCount = 0;
                        jumpping = false;
                        isGround = true;
                    }
                }
            }
        }
        //Debug.DrawRay(transform.position + Vector3.up * 0.23f, transform.forward * 1, Color.blue, 0.3f);
        //Debug.DrawRay(transform.position + Vector3.up * 0.5f, transform.forward * 1, Color.blue, 0.3f);

        if (!movessssss)
        {
            moves = true;


            canlandsound = (playerRigidbody.velocity.y < -8);
            damland = playerRigidbody.velocity.y;
        }
    }
    RaycastHit landhit;
    float damland;

    public void Velocityzero()
    {
        playerRigidbody.velocity = Vector3.zero;
    }
    //////////////////////////////////////////////////////////////b


    RaycastHit hhhit;
    void Move()
    {
        transform.position += move * Time.deltaTime * realspeed;
    }

    private void OnTriggerStay(Collider other)
    {
        //if(other.tag == "Bada")
        //{
        //    Badain = true;
        //    realspeed = speed * 0.7f;
        //    energyTimelate += Time.deltaTime;
        //    if (energyTimelate > energy)
        //        energyTimelate = energy;
        //}
        //else
        //{
        //    Badain = false;
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.7f && canlandsound)
        {
            AudioManager.GetComponent<Player_sound_effect>().Soundoff("jump-land");
            AudioManager.GetComponent<Player_sound_effect>().Sound("jump-land");
            if (damland < -15)
            {
                Debug.Log((int)(damland * 6));
                GetComponent<Player_Hp>().PlayerHp += (int)(damland * 6);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        movessssss = true;
        if (collision.contacts[0].normal.y > 0.7f)
        {
            //playerRigidbody.velocity = Vector3.zero;
            moves = true;
            jumpping = false;
        }
        else
            moves = false;
        if (!DoguUsing)
        {
            if(collision.gameObject.tag == "BadaGround")
            {
                isGround = false;
            }
            else if (collision.contacts[0].normal.y > 0.7f)
            {
                JumpCount = 0;
                isGround = true;
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        movessssss = false;
        canlandsound = false;
        if (!DoguUsing)
        {
           isGround = false;
        }
    }
}

