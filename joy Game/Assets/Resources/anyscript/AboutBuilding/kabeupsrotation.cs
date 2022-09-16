using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabeupsrotation : MonoBehaviour
{
    GameObject Player;
    Vector3 playerpos2;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        Debug.Log(GetAngle(transform.position, Player.transform.position));
    }

    public static float GetAngle(Vector3 from, Vector3 to)
    {
        Vector3 v = to - from;
        return Mathf.Atan2(v.x, v.z) * Mathf.Rad2Deg;
    }
}
