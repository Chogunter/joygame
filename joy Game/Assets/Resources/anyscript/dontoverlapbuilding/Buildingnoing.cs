using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildingnoing : MonoBehaviour
{
    GameObject Player;
    [SerializeField] private GameObject notsameposobject;
    void Awake()
    {
        Player = GameObject.Find("Player");
        //Physics.IgnoreCollision(this.GetComponent<Collider>(), GameObject.Find("ground").GetComponent<Collider>());
    }

    void Update()
    {
        if (true)
        {
            if (notsameposobject.GetComponent<childbuildingnoing>().the_e)
            {
                Player.GetComponent<DoguThrowAway>().canBuild = false;
            }
            else
            {
                Player.GetComponent<DoguThrowAway>().canBuild = true;
            }
        }
    }
}
