using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personanimationparamitormanager : MonoBehaviour
{
    Personmodelmanager personmodelmanager;

    [SerializeField] float stoped_speed_max;
    [SerializeField] float running_speed_min;
    Vector2 lastpos;
    Vector2 current;
    public float velocity;
    [SerializeField] bool off;
    void Awake()
    {
        personmodelmanager = GetComponent<Personmodelmanager>();
    }
    private void OnEnable()
    {
        //lastpos = transform.position;

        lastpos = new Vector2(transform.position.x, transform.position.z);
        current = new Vector2(transform.position.x, transform.position.z);
        once = 0;

        StartCoroutine(coVelocity());
    }
    int once;
    void Update()
    {
        if (!off)
        {
            disattacktimelate += Time.deltaTime;
            personmodelmanager.isStoped = velocity <= stoped_speed_max;
            personmodelmanager.isRunning = velocity >= running_speed_min;

            if (personmodelmanager.isAttack && disattacktimelate > 1.2f)
            {
                personmodelmanager.isAttack = false;
            }
        }
        if (once <= 10)
        {
            current = new Vector2(transform.position.x, transform.position.z);
            velocity = Vector2.Distance(lastpos, current) / Time.deltaTime;
            lastpos = new Vector2(transform.position.x, transform.position.z);
            once++;
        }
    }
    float coVelocityTurm = 1f;
    IEnumerator coVelocity()
    {
        current = new Vector2(transform.position.x, transform.position.z);
        velocity = Vector2.Distance(lastpos, current) / coVelocityTurm;
        yield return new WaitForSeconds(coVelocityTurm);
        StartCoroutine(coVelocity());
        lastpos = new Vector2(transform.position.x, transform.position.z);
    }

    float disattacktimelate;

    public void Attacked()
    {
        disattacktimelate = 0;
        personmodelmanager.isAttack = true;
    }
    public void Aimed()
    {
        personmodelmanager.isAming = true;
    }
    public void DisAimed()
    {
        personmodelmanager.isAming = false;
    }
    public void Die()
    {
        StopCoroutine(coVelocity());
        personmodelmanager.isDie = true;
    }
}
