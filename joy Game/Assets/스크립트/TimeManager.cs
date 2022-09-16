using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float times; // 14400

    public GameObject suntime1;
    public GameObject suntime2;
    public GameObject sun;
    //public Text text;

    public float time;
    [SerializeField] private float nightFogDensity;
    [SerializeField] private float fogupdown;
    [SerializeField] private float fogtimes = 0.1f;
    private float fogtime;
    [SerializeField] float timescale = 1;
    public int days = 0;

    public Text text;

    [SerializeField] AnimationCurve fogs;

    void Start()
    {
        StartCoroutine(UpdateRecord());
    }

    IEnumerator UpdateRecord()
    {
        yield return new WaitForSeconds(3);
        play_record_info.PlayedTimeRecord.Settime(time);

        StartCoroutine(UpdateRecord());
    }

    void Update()
    {
        //text.text = (sun.transform.rotation.y * 1440 / 360).ToString();
        time += Time.deltaTime * timescale;
        fogtime += Time.deltaTime;

        //Debug.Log(times * 360f / 1440f / 10f);
        float fogtimessadad = fogs.Evaluate(times / 14400);
        if (fogtimessadad >= 0.1f && fogtimessadad <= 1f)
        {
            RenderSettings.fogDensity = fogtimessadad * nightFogDensity;
        }
        else if(fogtimessadad < 0.001f)
        {
            RenderSettings.fogDensity = 0;
        }
        else if (fogtimessadad > 1f)
        {
            RenderSettings.fogDensity = nightFogDensity;
        }


        //if (time > 0.2f)
        //{
        //    if ((times * 360f / 1440f / 10f) > 101f && (times * 360f / 1440f / 10f) < 255f)
        //    {
        //        times += 3;
        //        //ToNight();
        //        time = 0f;
        //    }
        //    else
        //    {
        //        times += 1;
        //        //ToMorning();
        //        time = 0f;
        //    }
        //    text.text = (times * 360f / 1440f / 10f).ToString();
        //}
        if (true)
        {
            if ((times * 360f / 1440f / 10f) > 101f && (times * 360f / 1440f / 10f) < 255f)
            {
                times += Time.deltaTime * 3 * timescale;
                //ToNight();
                //time = 0f;
            }
            else
            {
                times += Time.deltaTime * timescale;
                //ToMorning();
                //time = 0f;
            }
            text.text = (times * 360f / 1440f / 10f).ToString();
        }

        if ((times * 360f / 1440f / 10f) > 360f)
        {
            play_record_info.PlayedTimeRecord.Addday();
            days++;
            times = 0;
        }
        
        //Debug.Log((times).ToString());
        suntime1.transform.localRotation = Quaternion.Euler(0f, 0f, (times * 360f) / 1440f / 10f);
        suntime2.transform.localRotation = Quaternion.Euler(0f, 0f, (times * 360f) / 1440f / 10f);
        sun.transform.rotation = Quaternion.Euler((times * 360f) / 1440f / 10f, 0f, -25f);
    }

    public void Time1()
    {
        times += 150;
    }
    public void Timeno1()
    {
        times -= 150;
    }

    private void ToNight()
    {
        if (fogtime > fogtimes)
        {
            if (RenderSettings.fogDensity < nightFogDensity)
            {
                RenderSettings.fogDensity += fogupdown;
            }
            else
            {
                RenderSettings.fogDensity = nightFogDensity;
            }
        }
    }
    private void ToMorning()
    {
        if (fogtime > fogtimes)
        {
            if (RenderSettings.fogDensity > 0)
            {
                RenderSettings.fogDensity -= fogupdown;
            }
        }
    }
}
