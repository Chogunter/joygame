using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yongwanglotime : MonoBehaviour
{
    public List<float> time;

    void Update()
    {
        for(int i = 1; i < time.Count; i++)
        {
            time[i] += Time.deltaTime;
        }
    }
}
