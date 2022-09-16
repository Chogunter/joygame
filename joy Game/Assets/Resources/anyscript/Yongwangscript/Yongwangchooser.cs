using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yongwangchooser : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject thr;

    public int kai;
    public int kaikaikitan;

    private void Start()
    {
        one.GetComponent<Yongwangchoose>().dogu = "chulgui";
        two.GetComponent<Yongwangchoose>().dogu = "namu";
        thr.GetComponent<Yongwangchoose>().dogu = "chul";
    }
    void Update()
    {
        one.GetComponent<Yongwangchoose>().num = kaikaikitan;
        two.GetComponent<Yongwangchoose>().num = kai * 2;
        thr.GetComponent<Yongwangchoose>().num = kai * 2;
    }
}
