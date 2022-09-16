using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_lightparticle_effect : MonoBehaviour
{
    //Particles[j].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

    [SerializeField] TimeManager time_manager;
    [SerializeField] ParticleSystem lightfroweffect; // 5sec
    [SerializeField] float[] time_time;//3600 //11200

    void Start()
    {
        StartCoroutine(particle_time());
    }

    WaitForSeconds wait_sec = new WaitForSeconds(5f);
    IEnumerator particle_time()
    {

        if(time_manager.times > time_time[0] && time_manager.times < time_time[1])
        {
            lightfroweffect.Play();
        }
        else
        {
            //lightfroweffect.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
        yield return wait_sec;

        StartCoroutine(particle_time());
    }
}
