using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class savefileTextshow : MonoBehaviour
{
    [SerializeField] Text datashow;
    public string data;
    public FileInfo filedatas;
    void Start()
    {
        datashow.text = data;
    }
    public void ButtonClick()
    {
        GameObject.Find("save and Load manager").GetComponent<saveandloadcommand_script>().savefileLoad(filedatas.FullName);
    }
}
