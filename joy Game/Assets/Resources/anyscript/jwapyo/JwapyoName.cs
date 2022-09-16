using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JwapyoName : MonoBehaviour
{
    GameObject Player;
    [SerializeField] GameObject Jwapyo;
    [SerializeField] Text Name;
    public int index;
    private void Awake()
    {
        Player = GameObject.Find("Player");
    }
    private void OnEnable()
    {
        Player.GetComponent<ESC>().JwapyoName += 1;
    }

    void Update()
    {
        if (Player.GetComponent<ESC>().JwapyoName % 2 == 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Jwapyo.GetComponent<jwapyo>().NameSet(Name.text, index);
                Name.text = "";
                Player.GetComponent<ESC>().JwapyoName += 1;
                gameObject.SetActive(false);
            }
        }
    }
}
