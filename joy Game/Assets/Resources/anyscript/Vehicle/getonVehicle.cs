using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getonVehicle : MonoBehaviour
{
    public GameObject getonpos;
    GameObject Player;
    public Vector3 originalpos;

    public bool Bool = false;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }
    private void Update()
    {
        if (Bool)
        {
            Player.transform.position = getonpos.transform.position;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (GetComponent<carmover>())
                {
                    Getoff(-transform.right * 2);
                }
                else if (GetComponent<BoatMover>())
                {
                    Getoff(Vector3.up);
                }
                else if (GetComponent<Helicopterscript>())
                {
                    Getoff(-transform.right * 2);
                    Player.GetComponent<PlayerMover>().Velocityzero();
                }
            }
        }
        if (Player.GetComponent<Player_Hp>().IsDie && Bool)
        {
            if (GetComponent<carmover>())
            {
                Getoff(-transform.right);
            }
            else if (GetComponent<BoatMover>())
            {
                Getoff(Vector3.up);
            }
            else if (GetComponent<Helicopterscript>())
            {
                Getoff(-transform.right);
                Player.GetComponent<PlayerMover>().Velocityzero();
            }
        }
    }
    public void Geton()
    {
        //originalpos = getonpos.transform.position + Vector3.up;
        Player.GetComponent<PlayerMover>().IsgetonVehicle = true;
        Bool = true;
    }
    public void Getoff(Vector3 pos)
    {
        Player.GetComponent<PlayerMover>().IsgetonVehicle = false;
        Player.transform.position = getonpos.transform.position + pos;
        Player.GetComponent<CapsuleCollider>().isTrigger = false;
        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Bool = false;
    }

    private void OnDestroy()
    {
        if (Bool)
        {
            if (GetComponent<carmover>())
            {
                Getoff(-transform.right);
            }
            else if (GetComponent<BoatMover>())
            {
                Getoff(Vector3.up);
            }
            else if (GetComponent<Helicopterscript>())
            {
                Getoff(-transform.right);
                Player.GetComponent<PlayerMover>().Velocityzero();
            }
        }
    }
}
