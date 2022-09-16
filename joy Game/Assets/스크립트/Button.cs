using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Button : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetString("countinuePath"));
    }
    public void OnClick()
    {
        PlayerPrefs.SetString("SaveAndLoadCommand", "Start");
        PlayerPrefs.SetString("filepath", "none");

        //SceneManager.LoadScene("Main");
        loadingscenecs.LoadScene("Main");
    }
    public void HowToPlayOnClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnCountinue()
    {
        string pathssss = PlayerPrefs.GetString("countinuePath");
        if (pathssss != null && pathssss != "")
        {
            PlayerPrefs.SetString("SaveAndLoadCommand", "load");
            PlayerPrefs.SetString("filepath", pathssss);

            loadingscenecs.LoadScene("Main");
        }
    }
}
