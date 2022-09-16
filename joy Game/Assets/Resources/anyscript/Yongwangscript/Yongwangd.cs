using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yongwangd : MonoBehaviour
{
    public int chuld = 0;
    public int namud = 0;
    public int timed = 0;
    public int yoyoyoyooyoyo = 0;

    GameObject yongwangLotime;

    [SerializeField] ParticleSystem particle;
    bool once;

    public float timelate;
    private void Awake()
    {
        yongwangLotime = GameObject.Find("yongwangLotime");
    }

    private void Update()
    {
        if(yoyoyoyooyoyo > 0 && once)
        {
            once = false;
            particle.Play();
        }
        else if(yoyoyoyooyoyo == 0)
        {
            once = true;
            particle.Stop();
        }
        timelate += Time.deltaTime;
    }

    private void OnEnable()
    {
        timelate = 0;
        once = true;
        timed = 0;
        yoyoyoyooyoyo = 0;
    }
}
