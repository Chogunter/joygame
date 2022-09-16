using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    public Vector3 campos;

    void Update()
    {
        Vector3 campos = this.gameObject.transform.position;
    }
}
