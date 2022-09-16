using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuckUmLookatUUUU : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.LookAt(Player.transform.position);
    }
}
