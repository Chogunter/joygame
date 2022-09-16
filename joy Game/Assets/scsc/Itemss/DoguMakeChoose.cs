using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoguMakeChoose : MonoBehaviour
{
    public string DOguChoice = "Gum";

    public List<GameObject> DOOOGU = new List<GameObject>();

    public int num = 0;
    public Text text;

    void Update()
    {
        text.text = num.ToString();
        if(DOguChoice == "None")
        {
            DOOOGU[0].SetActive(true);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "Doll")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(true);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "Namu")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(true);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "Gogi")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(true);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "Gum")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(true);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "DollGock")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(true);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "NamuGock")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(true);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);
        }
        if (DOguChoice == "Hwal")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(true);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);

        }
        if (DOguChoice == "HwaSal")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(true);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);

        }
        if (DOguChoice == "namunamugock")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(true);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(false);

        }
        if (DOguChoice == "namudollgock")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(true);

            DOOOGU[11].SetActive(false);

        }
        if (DOguChoice == "chunsajin")
        {
            DOOOGU[0].SetActive(false);
            DOOOGU[1].SetActive(false);
            DOOOGU[2].SetActive(false);
            DOOOGU[3].SetActive(false);
            DOOOGU[4].SetActive(false);
            DOOOGU[5].SetActive(false);
            DOOOGU[6].SetActive(false);
            DOOOGU[7].SetActive(false);
            DOOOGU[8].SetActive(false);

            DOOOGU[9].SetActive(false);
            DOOOGU[10].SetActive(false);

            DOOOGU[11].SetActive(true);

        }
    }


}
