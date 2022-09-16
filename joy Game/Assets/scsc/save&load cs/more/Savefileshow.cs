using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Savefileshow : MonoBehaviour
{
    public List<FileInfo> files = new List<FileInfo>();
    [SerializeField] GameObject contents;
    [SerializeField] GameObject filedatashows;
    [SerializeField] GameObject padding;
    void Start()
    {
        foreach(FileInfo ad in files)
        {
            InputToContents(ad);
        }

        var adadad = Instantiate(padding);
        adadad.transform.SetParent(contents.transform);
    }
    private void InputToContents(FileInfo a)
    {
        string a_data = File.ReadAllText(a.FullName);
        saveandload_script.SaveClass datesaveclass = JsonUtility.FromJson<saveandload_script.SaveClass>(a_data);
        string datas = "Name : " + datesaveclass.datanamepp + "\nDate : " + datesaveclass.date;

        var adadad = Instantiate(filedatashows);
        adadad.GetComponent<savefileTextshow>().data = datas;
        adadad.GetComponent<savefileTextshow>().filedatas = a;
        adadad.transform.SetParent(contents.transform);
    }
}
