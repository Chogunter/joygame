using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenChanger : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SceneChange()
    {
        Loading_Manager.isExit = true;
        SceneManager.LoadScene("Loddy Scene");
    }
    public void SceneReStart()
    {
        SceneManager.LoadScene("Main");
    }
}
