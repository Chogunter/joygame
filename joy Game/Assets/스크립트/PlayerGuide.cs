using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuide : MonoBehaviour
{
    public float time;

    private bool B_Guide_bool = true;
    public bool Guide_Was_Shown = false;

    public GameObject B_guide;

    void Update()
    {
        time += Time.deltaTime;
        if(time > 12f)
        {
            B_guide.SetActive(true);
            if(time > 19f || !Guide_Was_Shown)
            {
                B_guide.SetActive(false);
            }
        }
    }
}
