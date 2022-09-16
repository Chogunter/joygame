using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatepuplecore : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
