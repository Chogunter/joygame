using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Z_Chimdeaclickeffect : MonoBehaviour
{
    float time;

    private void OnEnable()
    {
        time = 0f;
    }
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 1.5f)
        {
            gameObject.SetActive(false);
        }
    }
}
