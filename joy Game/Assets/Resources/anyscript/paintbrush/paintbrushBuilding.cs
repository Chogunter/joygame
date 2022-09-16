using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class paintbrushBuilding : MonoBehaviour
{
    Renderer rend;

    [Serializable]
    public class colors
    {
        public string doguname;
        public Material dogucolor;
    }

    [SerializeField] List<colors> color;

    public string thatcolor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void ChangeColor(string doguname)
    {
        foreach(colors a in color)
        {
            if(a.doguname == doguname)
            {
                rend.material = a.dogucolor;
                thatcolor = doguname;
                Debug.Log("해당 오브젝트의 색상이 " + doguname + " 으로 바뀌었습니다.");
                return;
            }
        }
        Debug.Log(doguname + "라는 도구는 리스트에 존재하지 않습니다.");
    }
}
