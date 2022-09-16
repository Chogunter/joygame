using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangsave : MonoBehaviour
{
    public int tang;

    private void Update()
    {
        GetComponent<chonglitem>().ItemAmount = tang + 1;
    }
}
