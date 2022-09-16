using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopterscript : MonoBehaviour
{
    public GameObject wing;
    public GameObject backwing;

    public float speed;
    public float rotspeed;
    public float backrotspeed;
    public float wheelspeed;

    Rigidbody rb;

    Vector3 rot;
    bool wingwheel;
    bool backwingwheel;

    float x;
    float y;
    float w;

    GameObject Player;
    public GameObject SangJa;

    bool sss;

    float time;
    bool aaaeeeooo;

    public GameObject yonryo;
    public GameObject yonryosign;
    int yonryoryang;
    int yonryoryang1;
    int yonryoryang2;
    public GameObject velocitysign;
    public GameObject godo;

    bool IsPlayerrotset;
    public GameObject PlayerLooktarget;
    GameObject cam;

    [SerializeField] AudioSource audiosource;
    bool once;

    [SerializeField] float resistance;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, -1, 0);
        Player = GameObject.Find("Player");
        IsPlayerrotset = true;
        cam = GameObject.Find("Enpty");
    }
    private void OnEnable()
    {
        time = 0;
    }

    void Update()
    {
        if (((SangJa.GetComponent<SangJJasaveandload>().Item1 == "corepiece" &&
            SangJa.GetComponent<SangJJasaveandload>().num1 > 0) ||
            (SangJa.GetComponent<SangJJasaveandload>().Item2 == "corepiece" &&
            SangJa.GetComponent<SangJJasaveandload>().num2 > 0)) &&
            GetComponent<getonVehicle>().Bool)
        {
            aaaeeeooo = true;
            time += Time.deltaTime;
            if(SangJa.GetComponent<SangJJasaveandload>().Item1 == "corepiece" &&
                    SangJa.GetComponent<SangJJasaveandload>().num1 > 0)
            {
                yonryoryang1 = SangJa.GetComponent<SangJJasaveandload>().num1;
            }
            if (SangJa.GetComponent<SangJJasaveandload>().Item2 == "corepiece" &&
                    SangJa.GetComponent<SangJJasaveandload>().num2 > 0)
            {
                yonryoryang2 = SangJa.GetComponent<SangJJasaveandload>().num2;
            }
            yonryoryang = yonryoryang1 + yonryoryang2;
            if (yonryoryang > 250)
                yonryoryang = 250;
            if (time > 6f)
            {
                if(SangJa.GetComponent<SangJJasaveandload>().Item1 == "corepiece" &&
                    SangJa.GetComponent<SangJJasaveandload>().num1 > 0)
                {
                    SangJa.GetComponent<SangJJasaveandload>().num1 -= 1;
                }
                else if (SangJa.GetComponent<SangJJasaveandload>().Item2 == "corepiece" &&
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
            cam.GetComponent<CameraMover>().ishelgi = false;
            Player.GetComponent<PlayerMover>().ishelgi = false;
        }
        if (GetComponent<getonVehicle>().Bool)
        {
            cam.GetComponent<CameraMover>().ishelgi = IsPlayerrotset;
            Player.GetComponent<PlayerMover>().ishelgi = IsPlayerrotset;
            Player.GetComponent<CapsuleCollider>().isTrigger = true;
            if (Input.GetMouseButtonDown(2))
            {
                IsPlayerrotset = false;
            }
            if (Input.GetMouseButtonUp(2))
            {
                IsPlayerrotset = true;
            }
            if (IsPlayerrotset)
            {
                Player.transform.rotation = transform.rotation;
                
                cam.transform.rotation = transform.rotation;
            }
            yonryo.transform.localRotation = Quaternion.Euler(Vector3.up * yonryoryang);
            velocitysign.transform.localRotation = Quaternion.Euler(Vector3.up * rb.velocity.magnitude * 1);
            godo.transform.localPosition = Vector3.up * transform.rotation.x;
            godo.transform.localRotation = Quaternion.Euler(Vector3.forward * transform.rotation.eulerAngles.z);
            if(godo.transform.localPosition.y > 0.5f)
            {
                godo.transform.localPosition = Vector3.up * 0.5f;
            }
            if (godo.transform.localPosition.y < -0.5f)
            {
                godo.transform.localPosition = Vector3.up * -0.5f;
            }
            if (yonryoryang > 30)
                yonryosign.SetActive(false);
            else
                yonryosign.SetActive(true);


            if (aaaeeeooo)
            {
                sss = true;
                wingwheel = true;
                if (true)
                {
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Keypad4))
                    {
                        y = -1;
                    }
                    else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Keypad6))
                    {
                        y = 1;
                    }
                    else
                    {
                        y = 0;
                    }
                    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Keypad8))
                    {
                        x = 1;
                    }
                    else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Keypad5))
                    {
                        x = -1;
                    }
                    else
                    {
                        x = 0;
                    }
                    if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Keypad9))
                    {
                        w = -1;
                    }
                    else if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Keypad7))
                    {
                        w = 1;
                    }
                    else
                    {
                        w = 0;
                    }
                }

                rot = Vector3.up * y * wheelspeed + Vector3.right * x * wheelspeed + Vector3.forward * w * wheelspeed;
                transform.Rotate(rot * Time.deltaTime);
            }
        }
        else
        {
            if (sss)
            {
                wingwheel = false;
                Player.GetComponent<CapsuleCollider>().isTrigger = false;
                rb.velocity = Vector3.zero;
                wingwheel = false;
                sss = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if (wingwheel && aaaeeeooo)
        {
            wing.transform.Rotate(0, rotspeed, 0);
            backwing.transform.Rotate(rotspeed, 0, 0);
            if (once)
            {
                audiosource.Play();
                once = false;
            }
        }
        else
        {
            audiosource.Stop();
            once = true;
        }

        if (transform.position.y > 100)
        {
            transform.position = new Vector3(transform.position.x, 100, transform.position.z);
        }
        if (GetComponent<getonVehicle>().Bool && aaaeeeooo)
        {
            if ((Input.GetKey(KeyCode.Space) || (Input.GetKey(KeyCode.Keypad0)) && transform.position.y < 25))
            {
                rb.AddForce(speed * transform.up);
                //transform.Translate(transform.up * speed);
            }
            else if ((Input.GetKey(KeyCode.LeftControl)))
            {
                rb.AddForce(speed * -transform.up / 2);
                //transform.Translate(transform.up * -speed);
            }
        }
        if(rb.velocity.magnitude > 0)
        {
            rb.AddForce(-rb.velocity.normalized * resistance);
        }
    }
}
