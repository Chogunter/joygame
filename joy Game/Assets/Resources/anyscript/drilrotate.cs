using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drilrotate : MonoBehaviour
{
    public float rotate;

    void Update()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            transform.Rotate(rotate * Time.deltaTime, 0f, 0f);
        }
    }
}
