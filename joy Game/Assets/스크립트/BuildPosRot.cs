using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPosRot : MonoBehaviour
{
    public GameObject mm;
    public GameObject the;
    bool sss = true;
    public GameObject JiBung_hang;
    public GameObject SamGack_hang;
    public GameObject Kabe_hang;

    void Update()
    {
        if (the.GetComponent<buildposgetrey>().Is)
        {
            transform.position = the.GetComponent<buildposgetrey>().pos;
            transform.rotation = the.GetComponent<buildposgetrey>().rot;
            JiBung_hang.transform.localRotation = Quaternion.identity;
            if(the.GetComponent<buildposgetrey>().index == 3 && the.GetComponent<buildposgetrey>().theguy == "samgack")
            {
                SamGack_hang.transform.localRotation = Quaternion.identity;
            }
            else
            {
                SamGack_hang.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
            }
            if (the.GetComponent<buildposgetrey>().index == 0 && the.GetComponent<buildposgetrey>().theguy == "samgack")
            {
                Kabe_hang.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
            }
            else
            {
                Kabe_hang.transform.localRotation = Quaternion.identity;
            }
            sss = true;
        }
        else
        {
            JiBung_hang.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 60));
            SamGack_hang.transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
            transform.position = mm.transform.position;
            if (sss)
            {
                transform.rotation = Quaternion.identity;
                sss = false;
            }
        }
    }
}
