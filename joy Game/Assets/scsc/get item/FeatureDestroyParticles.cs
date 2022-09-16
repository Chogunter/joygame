using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureDestroyParticles : MonoBehaviour
{
    [SerializeField] List<Rigidbody> particles = new List<Rigidbody>();
    [SerializeField] List<Vector3> forcevec = new List<Vector3>();
    List<Vector3> particlepos = new List<Vector3>();
    List<Vector3> particlescale = new List<Vector3>();

    private void Awake()
    {
        for (int i = 0; i < particles.Count; i++)
        {
            particlepos.Add(particles[i].transform.localPosition);
            particlescale.Add(particles[i].transform.localScale);
        }
    }
    private void OnEnable()
    {
        for(int i = 0; i < particles.Count; i++)
        {
            particles[i].transform.localPosition = particlepos[i];
            particles[i].transform.localScale = particlescale[i];
            particles[i].velocity = Vector3.zero;
            particles[i].AddForce(forcevec[i].normalized * 400, ForceMode.Acceleration);
            particles[i].AddTorque(new Vector3(45,45,45));
        }
    }
    private void Update()
    {
        for (int i = 0; i < particles.Count; i++)
        {
            if(particles[i].transform.localScale.x > 0)
            {
                particles[i].transform.localScale -= Vector3.right * Time.deltaTime;
            }
            if (particles[i].transform.localScale.y > 0)
            {
                particles[i].transform.localScale -= Vector3.up * Time.deltaTime;
            }
            if (particles[i].transform.localScale.z > 0)
            {
                particles[i].transform.localScale -= Vector3.forward * Time.deltaTime;
            }
        }

        for (int i = 0; i < particles.Count; i++)
        {
            if(particles[i].transform.localScale.x > 0 ||
                particles[i].transform.localScale.y > 0 ||
                particles[i].transform.localScale.z > 0)
            {
                return;
            }
        }

        gameObject.SetActive(false);
    }
}
