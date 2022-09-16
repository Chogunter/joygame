using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCButoon : MonoBehaviour
{
    //public GameObject sun;
    public GameObject Exit;
    public GameObject Time;
    public GameObject Key;
    public GameObject ESC;

    private float time = 0;
    private int GameTime = 12;

    public void OnKeyClick()
    {
        Exit.SetActive(false);
        Key.SetActive(true);
        Time.SetActive(false);
        GameObject.Find("Player").GetComponent<ESC>().asaa += 1;
    }

    public void OnExitClick()
    {
        Exit.SetActive(true);
        Key.SetActive(false);
        Time.SetActive(false);
        GameObject.Find("Player").GetComponent<ESC>().asaa += 1;

    }

    public void OnTImeClick()
    {
        Exit.SetActive(false);
        Key.SetActive(false);
        Time.SetActive(true);
    }
    public void OnSaveClick()
    {
        ESC.SetActive(false);
        GameObject.Find("Player").GetComponent<ESC>().saveUiint += 1;
        GameObject.Find("Player").GetComponent<ESC>().asaa += 1;

    }
}
