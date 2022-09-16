using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildposgetrey : MonoBehaviour
{
    public Vector3 pos;
    public Quaternion rot;
    RaycastHit hit;
    public float MaxDistance;
    public int index;
    public int realindex;
    public bool Is;
    float scroll;
    public string theguy;

    GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
        {
            if(hit.collider.tag == "easybuildpos")
            {
                if (realindex != 99)
                {
                    //Debug.Log(hit.collider.tag);
                    theguy = hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy;
                    if (hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy == "badack")
                    {
                        if (index == 0 || index == 1 || index == 3 || index == 4 || index == 2)
                        {
                            if (!hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex > 5)
                            {
                                return;
                            }
                            Is = true;
                            pos = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.position;
                            rot = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.rotation;
                            if (hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex != 99)
                            {
                                scroll += Input.GetAxis("Mouse ScrollWheel") / 2;
                                if (scroll > 1 || (scroll < 0 && scroll > -1))
                                {
                                    if (index == 2)
                                    {
                                        realindex = 6;
                                    }
                                    else if (index == 4)
                                    {
                                        realindex = 5;
                                    }
                                }
                                else
                                {
                                    realindex = index;
                                }
                                if (scroll > 2 || scroll < -1)
                                {
                                    scroll = 0;
                                }
                            }
                            else
                            {
                                realindex = index;
                                scroll = 0.5f;
                            }
                        }
                        else
                        {
                            Is = false;
                            realindex = index;
                        }
                    }
                    else if (hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy == "kabe")
                    {
                        if (index == 0 || index == 2 || index == 3 || index == 4 || index == 1)
                        {
                            if (!hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex > 5)
                            {
                                return;
                            }
                            Is = true;
                            pos = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.position;
                            rot = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.rotation;
                            if (hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex != 99)
                            {
                                if(GetAngle(hit.transform.parent.position, Player.transform.position) > 0)
                                {
                                    realindex = index;
                                }
                                else
                                {
                                    if (index == 2)
                                    {
                                        realindex = 6;
                                    }
                                    else if (index == 4)
                                    {
                                        realindex = 5;
                                    }
                                }
                                //Debug.Log(GetAngle(hit.transform.parent.position, Player.transform.position));
                            }
                        }
                        else
                        {
                            Is = false;
                            realindex = index;
                        }
                    }
                    else if (hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy == "jibung")
                    {
                        if (index == 4 || index == 0 || index == 3 || index == 1 || index == 2)
                        {
                            if (!hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex > 5)
                            {
                                return;
                            }
                            Is = true;
                            pos = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.position;
                            rot = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.rotation;
                        }
                        else
                        {
                            Is = false;
                            realindex = index;
                        }
                    }
                    else if (hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy == "chunjan")
                    {
                        if (index == 2 || index == 1 || index == 0 || index == 3 || index == 4)
                        {
                            if (!hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex > 5)
                            {
                                return;
                            }
                            Is = true;
                            pos = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.position;
                            rot = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.rotation;
                            if (hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex != 99)
                            {
                                //Debug.Log(scroll);
                                scroll += Input.GetAxis("Mouse ScrollWheel") / 2;
                                if (scroll > 1 || (scroll < 0 && scroll > -1))
                                {
                                    if (index == 2)
                                    {
                                        realindex = 6;
                                    }
                                    else if (index == 4)
                                    {
                                        realindex = 5;
                                    }
                                }
                                else
                                {
                                    realindex = index;
                                }
                                if (scroll > 2 || scroll < -1)
                                {
                                    scroll = 0;
                                }
                            }
                            else
                            {
                                realindex = index;
                                scroll = 0.5f;
                            }
                        }
                        else
                        {
                            Is = false;
                            realindex = index;
                        }
                    }
                    else if (hit.collider.gameObject.GetComponent<eastbuildpos>().thatguy == "samgack")
                    {
                        if (index == 3 || index == 0 || index == 4 || index == 2 || index == 1)
                        {
                            if (!hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex > 5)
                            {
                                return;
                            }
                            Is = true;
                            pos = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.position;
                            rot = hit.collider.gameObject.GetComponent<eastbuildpos>().thepos[realindex].transform.rotation;
                            if (hit.collider.gameObject.GetComponent<eastbuildpos>().various && realindex != 99)
                            {
                                scroll += Input.GetAxis("Mouse ScrollWheel") / 2;
                                if (scroll > 1 || (scroll < 0 && scroll > -1))
                                {
                                    if (index == 2)
                                    {
                                        realindex = 6;
                                    }
                                    else if (index == 4)
                                    {
                                        realindex = 5;
                                    }
                                }
                                else
                                {
                                    realindex = index;
                                }
                                if (scroll > 2 || scroll < -1)
                                {
                                    scroll = 0;
                                }
                            }
                            else
                            {
                                realindex = index;
                                scroll = 0;
                            }
                        }
                        else
                        {
                            Is = false;
                            realindex = index;
                        }
                    }
                }
                else
                {
                    realindex = index;
                }
            }
            else
            {
                Is = false;
                realindex = index;
            }
        }
        else
        {
            realindex = index;
        }
    }

    public static float GetAngle(Vector3 from, Vector3 to)
    {
        Vector3 v = to - from;
        return Mathf.Atan2(v.x, v.z) * Mathf.Rad2Deg;
    }

}
