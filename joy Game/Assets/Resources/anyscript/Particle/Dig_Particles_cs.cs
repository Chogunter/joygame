using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dig_Particles_cs : MonoBehaviour
{
    [SerializeField] List<ParticleSystem> Particles;
    [SerializeField] List<float> time_lates;
    [SerializeField] List<float> times;

    [Serializable]
    class ParticleClass
    {
        public string name;
        public GameObject ParticlePrefab;
        public float time_late;
    }
    [SerializeField] List<ParticleClass> particleList;
    GameObject ParticleObject;
    void Start()
    {
        //times.Add(0f);
        //Particles.Add(Instantiate(ParticleObject, Vector3.zero, Quaternion.identity).GetComponent<ParticleSystem>());
        //Particles[Particles.Count - 1].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
    void Update()
    {
        for(int i = 0; i <= times.Count - 1; i++)
        {
            if (times[i] < time_lates[i])
            {
                times[i] += Time.deltaTime;
            }
        }
        for(int j = 0; j <= times.Count - 1; j++)
        {
            if(times[j] > time_lates[j])
            {
                Particles[j].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
        }
    }
    public void Particle(Vector3 Worldpos, string name)
    {
        ParticleObject = null;
        foreach (ParticleClass particle in particleList)
        {
            if(particle.name == name)
            {
                ParticleObject = particle.ParticlePrefab;
            }
        }
        if(ParticleObject == null)
        {
            Debug.Log("요구하는 파티클을 찾을 수 없습니다.");
            return;
        }
        for (int i = 0; i < Particles.Count - 1; i++)
        {
            if(Particles[i] == null)
            {
                continue;
            }
            if (!Particles[i].isPlaying && Particles[i].name == name)
            {
                Particles[i].gameObject.transform.position = Worldpos;
                times[i] = 0;
                Particles[i].Play();
                return;
            }
        }
        times.Add(0f);
        foreach (ParticleClass particle in particleList)
        {
            if (particle.name == name)
            {
                time_lates.Add(particle.time_late);
            }
        }
        Particles.Add(Instantiate(ParticleObject, Worldpos, Quaternion.identity).GetComponent<ParticleSystem>()); 
        Particles[Particles.Count - 1].gameObject.transform.parent = this.transform;
        Particles[Particles.Count - 1].name = name;
        Particles[Particles.Count - 1].Play();
    }

}
