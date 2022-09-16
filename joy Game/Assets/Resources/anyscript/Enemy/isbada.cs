using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isbada : MonoBehaviour
{
    public bool isground = false;

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.tag == "Donttrigger")
        {
            return;
        }
        isground = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Donttrigger")
        {
            return;
        }
        isground = false;
    }
}
