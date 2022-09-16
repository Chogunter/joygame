using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoguItemChang : MonoBehaviour
{
    public GameObject DoguChang;
    public int aAaAaA = 0;

    GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (!this.GetComponent<ESC>().IsInputFieldUsing)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Player.GetComponent<ESC>().anyint > 0)
                {
                    aAaAaA = 0;
                    Player.GetComponent<ESC>().anyint = 0;
                }
                else
                {
                    aAaAaA += 1;
                }
            }
        }
        //if (aAaAaA % 2 == 0)
        //{
        //    DoguChang.SetActive(false);
        //}
        //else if (aAaAaA % 2 == 1)
        //{
        //    DoguChang.SetActive(true);
        //}
    }
}
