using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class save_UI_in_main : MonoBehaviour
{
    [SerializeField] string FolderPath;
    public List<FileInfo> files = new List<FileInfo>();

    [SerializeField] InputField NameEnters;
    [SerializeField] GameObject FilesShows;
    [SerializeField] saveandload_script savescript;
    [SerializeField] GameObject overlapmessage;
    [SerializeField] bool askedforoverlap = false;
    List<GameObject> showsbundles = new List<GameObject>();
    [SerializeField] string Textiswhat;
    [SerializeField] float speed;
    Vector3 overlapmessage_topos;
    Vector3 overlapmessage_frompos;
    [SerializeField] GameObject contents;
    [SerializeField] GameObject padding;
    // Start is called before the first frame update
    void Start()
    {
        overlapmessage_topos = overlapmessage.transform.position + Vector3.up * 200;
        overlapmessage_frompos = overlapmessage.transform.position;
        //FolderPath = Path.Combine(Application.dataPath, "jsonfilesavesfolderss");
        FolderPath = Path.Combine(Application.persistentDataPath, "jsonfilesavesfolderss");

        if (Directory.Exists(FolderPath))
        {
            DirectoryInfo di = new DirectoryInfo(FolderPath);
            foreach (var Item in di.GetFiles())
            {
                if (Path.GetExtension(Item.FullName) != ".json")
                {
                    continue;
                }
                Instatefileshows(Item);
                files.Add(Item);;
            }
        }
        var showsbundle = Instantiate(padding);
        showsbundle.transform.SetParent(contents.transform);
    }
    void Instatefileshows(FileInfo a)
    {
        string dadadad = File.ReadAllText(a.FullName);
        var showsbundle = Instantiate(FilesShows);
        showsbundle.transform.SetParent(contents.transform);
        saveandload_script.SaveClass kkkk = JsonUtility.FromJson<saveandload_script.SaveClass>(dadadad);
        showsbundle.GetComponent<Savefileshows_In_main>().Name = kkkk.datanamepp;
        showsbundle.GetComponent<Savefileshows_In_main>().date = kkkk.date;
        showsbundle.GetComponent<Savefileshows_In_main>().aaa = this;
        showsbundle.GetComponent<Savefileshows_In_main>().Starta();
        showsbundles.Add(showsbundle);
    }

    void Update()
    {
        //Textiswhat = NameEnters.text;
        Textiswhat = (NameEnters.text != "") ? NameEnters.text : "";

        if (askedforoverlap)
        {
            overlapmessage.transform.position = Vector3.MoveTowards(overlapmessage.transform.position,
                overlapmessage_topos, speed * Time.deltaTime);
        }
        else
        {
            overlapmessage.transform.position = Vector3.MoveTowards(overlapmessage.transform.position,
                overlapmessage_frompos, speed * Time.deltaTime);
        }


        for(int i = 0; i < showsbundles.Count; i++)
        {
            string adadada = showsbundles[i].GetComponent<Savefileshows_In_main>().name;
            if (iscontainthatname(adadada))
            {
                showsbundles[i].SetActive(true);
            }
            else
            {
                showsbundles[i].SetActive(false);
            }
        }

    }
    bool iscontainthatname(string name)
    {
        if(Textiswhat == "")
        {
            return true;
        }
        if (name.Contains(Textiswhat))
        {
            return true;
        }
        return false;
    }
    void ask_for_overlap()
    {
        if (Textiswhat == "")
        {
            return;
        }
        askedforoverlap = true;
    }
    public void cancle()
    {
        askedforoverlap = false;
    }
    public void overlap()
    {
        if (Textiswhat == "")
        {
            return;
        }
        if (savescript.Save(FolderPath, Textiswhat, true) != 0)
        {
            Debug.LogError("이상한데요?!");
        }
        else
        {
            askedforoverlap = false;
        }
    }

    public void filechoose(string name)
    {
        NameEnters.text = name;
    }

    public void Saves()
    {
        if(Textiswhat == "")
        {
            return;
        }
        if(savescript.Save(FolderPath, Textiswhat, false) == 1)
        {
            ask_for_overlap();
        }
    }
}
