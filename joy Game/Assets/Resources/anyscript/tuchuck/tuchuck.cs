using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuchuck : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Cursor;

    [SerializeField] GameObject suryutang;
    [SerializeField] GameObject c4;

    [SerializeField] float force;
    bool sss;

    GameObjectPool game_object_pool;
    void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
    }

    void Update()
    {
        if (canGetKey.IsESCturnedon)
        {
            return;
        }
        if(Cursor.GetComponent<ItemCursor>().Using_Item == "suryutang")
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                sss = true;
            }
            else if(sss && Input.GetKeyUp(KeyCode.G))
            {
                var that = game_object_pool.InstantiatesObject("suryutang_tuchuck", transform.position + transform.forward, transform.rotation);
                Rigidbody that_rb = that.GetComponent<Rigidbody>();
                that_rb.AddForce(that.transform.forward * force);
                if (true)
                {
                    if(Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= 1;
                    }
                }
                sss = false;
            }
            else if(sss && Input.anyKeyDown)
            {
                sss = false;
            }
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "C4")
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                sss = true;
            }
            else if (sss && Input.GetKeyUp(KeyCode.G))
            {
                var that = game_object_pool.InstantiatesObject("C4_tuchuck", transform.position + transform.forward * 2, transform.rotation);
                Rigidbody that_rb = that.GetComponent<Rigidbody>();
                that_rb.AddForce(that.transform.forward * force);
                if (true)
                {
                    if (Cursor.GetComponent<ItemCursor>().Using_Slot == 1)
                    {
                        Player.GetComponent<PlayerHand>().Amount1 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 2)
                    {
                        Player.GetComponent<PlayerHand>().Amount2 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 3)
                    {
                        Player.GetComponent<PlayerHand>().Amount3 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 4)
                    {
                        Player.GetComponent<PlayerHand>().Amount4 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 5)
                    {
                        Player.GetComponent<PlayerHand>().Amount5 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 6)
                    {
                        Player.GetComponent<PlayerHand>().Amount6 -= 1;
                    }
                    else if (Cursor.GetComponent<ItemCursor>().Using_Slot == 7)
                    {
                        Player.GetComponent<PlayerHand>().Amount7 -= 1;
                    }
                }
                sss = false;
            }
            else if (sss && Input.anyKeyDown)
            {
                sss = false;
            }
        }
        else
        {
            sss = false;
        }
    }
}
