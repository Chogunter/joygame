using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childbuildingnoing : MonoBehaviour
{
    public bool the_e;
    [SerializeField] int a;

    private void FixedUpdate()
    {
        if (a == 0)
        {
            the_e = true;
            a = 1;
        }
        else
        {
            the_e = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag != "Donttrigger")
        {
            a = 0;
            //the_e = true;
            //Debug.Log(other.name);
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag != "Donttrigger")
    //    {
    //        the_e = false;
    //    }
    //}
}
