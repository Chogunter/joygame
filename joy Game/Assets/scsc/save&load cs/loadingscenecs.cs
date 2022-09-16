using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingscenecs : MonoBehaviour
{
    public static string nextScene;
    [SerializeField] Image progressBar;
    [SerializeField] Slider progressBarslider;
    [SerializeField] Text text;
    private void Start() 
    { 
        StartCoroutine(LoadScene()); 
    }
    public static void LoadScene(string sceneName) 
    { 
        nextScene = sceneName; 
        SceneManager.LoadScene("LoadingSceneToStart"); 
    }
    IEnumerator LoadScene() 
    { 
        yield return null; 
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene); 
        op.allowSceneActivation = false; 
        float timer = 0.0f; 
        while (!op.isDone) 
        { 
            yield return null; 
            timer += Time.deltaTime;
            //text.text = timer.ToString();
            if (op.progress < 0.9f) 
            {
                //progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, op.progress, timer); 
                //if (progressBar.fillAmount >= op.progress) 
                //{ 
                //    timer = 0f; 
                //} 
                progressBarslider.value = Mathf.Lerp(progressBarslider.value, op.progress, timer);
                if (progressBarslider.value >= op.progress)
                {
                    timer = 0f;
                }
            }
            else 
            {
                //progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, 1f, timer); 
                //if (progressBar.fillAmount == 1.0f) 
                //{
                //    op.allowSceneActivation = true; yield break; 
                //} 
                progressBarslider.value = Mathf.Lerp(progressBarslider.value, 1f, timer);
                if (progressBarslider.value == 1.0f)
                {
                    op.allowSceneActivation = true; 
                    yield break;
                }
            }
        } 
    }
}
