using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class saveandloadcommand_script : MonoBehaviour
{
    [SerializeField] string FolderPath;
    void Awake()
    {
        Debug.Log(PlayerPrefs.GetString("SaveAndLoadCommand"));
        PlayerPrefs.SetString("SaveAndLoadCommand", "none");
        PlayerPrefs.SetString("filepath", "none");
        PlayerPrefs.SetString("chattingLog", "off");
        Debug.Log(PlayerPrefs.GetString("SaveAndLoadCommand"));

        //FolderPath = Path.Combine(Application.dataPath, "jsonfilesavesfolderss");
        FolderPath = Path.Combine(Application.persistentDataPath, "jsonfilesavesfolderss");

        if (Directory.Exists(FolderPath))
        {
            DirectoryInfo di = new DirectoryInfo(FolderPath);
            foreach(var Item in di.GetFiles())
            {
                if(Path.GetExtension(Item.FullName) != ".json")
                {
                    continue;
                }
                Debug.Log(Item.Name);
                GetComponent<Savefileshow>().files.Add(Item);
            }
            Debug.Log("무ㅝ임??");
        }
        else
        {
            Debug.Log("없는데??");
        }
    }

    public void savefileLoad(string filepaths)
    {
        Debug.Log(PlayerPrefs.GetString("SaveAndLoadCommand"));
        PlayerPrefs.SetString("SaveAndLoadCommand", "load");
        PlayerPrefs.SetString("filepath", filepaths);
        //SceneManager.LoadScene("Main");
        loadingscenecs.LoadScene("Main");
    }

}
