using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackMulDDangasda : MonoBehaviour
{
    public bool sss = true;

    private void OnEnable()
    {
        sss = true;
    }

    private void OnTriggerStay(Collider other)
    {
        //if (other.tag == "JackMul1")
        //{
        //    sss = false;
        //}
        //else if (other.tag == "JackMul2")
        //{
        //    sss = false;
        //}
    }
}
