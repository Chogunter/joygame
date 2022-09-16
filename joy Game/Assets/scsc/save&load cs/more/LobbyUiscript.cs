using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyUiscript : MonoBehaviour
{
    [System.Serializable]
    public class UIlevel
    {
        public int at;
        public GameObject that;
    }

    public List<UIlevel> Uis = new List<UIlevel>();
    public int aaaa;

    void Start()
    {
        aaaa = 0;
    }
    void Update()
    {
        for(int i = 0; i < Uis.Count; i++)
        {
            if(Uis[i].at == aaaa)
            {
                Uis[i].that.SetActive(true);
            }
            else
            {
                Uis[i].that.SetActive(false);
            }
        }
    }
    public void Toone()
    {
        aaaa = 1;
    }
    public void Tozero()
    {
        aaaa = 0;
    }
    public void ToChanges(int i)
    {
        aaaa = i;
    }
}
