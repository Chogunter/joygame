using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSceneInMain : MonoBehaviour
{
    public static bool is_loaded;
    [SerializeField] GameObject thatone;
    [SerializeField] Text loadingtext;
    [SerializeField] Text timelatetext;

    int aaaa = 0;
    int timelate = 0;

    void Awake()
    {
        is_loaded = false;
    }
    private void Start()
    {
        StartCoroutine(waitS());
    }
    //void Update()
    //{

    //}
    private void FixedUpdate()
    {
        if (is_loaded)
        {
            StopCoroutine(waitS());
            gameObject.SetActive(false);
        }
        thatone.transform.Rotate(0, 0, 20);
        if(aaaa == 0)
        {
            loadingtext.text = "Loading";
        }
        else if(aaaa == 1)
        {
            loadingtext.text = "Loading .";
        }
        else if (aaaa == 2)
        {
            loadingtext.text = "Loading . .";
        }
        else if (aaaa == 3)
        {
            loadingtext.text = "Loading . . .";
        }
        else
        {
            aaaa = 0;
        }
        if (timelate < 60)
        {
            timelatetext.text = timelate.ToString() + " s ";
        }
        else
        {
            timelatetext.text = (timelate / 60).ToString() + " m " + (timelate % 60).ToString() + " s ";
        }
    }

    IEnumerator waitS()
    {
        while (!is_loaded)
        {
            yield return new WaitForSeconds(1.0f);
            aaaa++;
            timelate++;
        }
    }
}
