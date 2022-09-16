using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoguRotation : MonoBehaviour
{
    private float last_time = 0.4f;
    private bool s = false;
    private bool w = false;
    public bool attack = false;
    private bool hawl = false;
    //public Text text;
    public GameObject Itemcursor;
    void Update()
    {
        last_time += Time.deltaTime;
        //text.text = last_time.ToString();
        if (Itemcursor.GetComponent<ItemCursor>().Using_Item == "hwal" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "hubipgi" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "dril" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "redcore" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "puplecore" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "orangecore" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "greencore" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "chunsajin" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "chunsajinmk2" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "sigea" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "chong" ||
            Itemcursor.GetComponent<ItemCursor>().Using_Item == "gogi")
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else
        {
            if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
            {
                if (last_time > 1f)
                {
                    last_time = 0;
                    s = true;
                    w = true;
                }
                else if (last_time > 0.7f)
                {
                    if (w)
                    {
                        transform.localRotation = Quaternion.Euler(new Vector3(25, 0, 0));
                        if (Input.GetMouseButton(0))
                        {
                            attack = false;
                        }
                        w = false;
                    }
                }
                else if (last_time > 0.3f)
                {
                    if (s)
                    {
                        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                        if (Input.GetMouseButton(0))
                        {
                            attack = true;
                        }
                        s = false;
                    }
                }
            }
            else
            {
                if (!s && w)
                {
                    transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                    s = true;
                    if (Input.GetMouseButton(0))
                    {
                        attack = false;
                    }
                }
                else if (!s && !w)
                {
                    s = true;
                    w = true;
                    attack = false;
                }
                last_time = 0;

            }
        }
    }
}
