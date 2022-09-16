using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangMulSpawner : MonoBehaviour
{
    public GameObject dongMul;
    private Vector3 pos;
    private int randomx; // -200 ~ 200
    private int randomz;
    private float time;
    public int SangMuls;
    void Start()
    {
        
    }
    void Update()
    {
        time += Time.deltaTime;

        if (SangMuls < 25)
        {
            if (time > 1f)
            {
                randomx = Random.Range(-200, 200);
                randomz = Random.Range(-200, 200);
                pos = new Vector3(randomx, 0, randomz) + this.transform.position;
                if (Vector3.Distance(this.transform.position, pos) > 50)
                {
                    Instantiate(dongMul, pos, Quaternion.identity);
                    Instantiate(dongMul, pos + new Vector3(3, 0, 0), Quaternion.identity);
                    Instantiate(dongMul, pos + new Vector3(-3, 0, 0), Quaternion.identity);
                    Instantiate(dongMul, pos + new Vector3(0, 0, 3), Quaternion.identity);
                    Instantiate(dongMul, pos + new Vector3(0, 0, -3), Quaternion.identity);
                    SangMuls += 5;
                    time = 0f;
                }
                else
                {
                    randomx = Random.Range(-200, 200);
                    randomz = Random.Range(-200, 200);
                    pos = new Vector3(randomx, 1, randomz);
                }
            }
        }
    }
}
