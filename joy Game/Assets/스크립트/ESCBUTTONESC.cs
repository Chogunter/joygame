using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCBUTTONESC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("Player").GetComponent<ESC>().asaa += 1;
            gameObject.SetActive(false);
        }
    }
    public void Quit()
    {
        GameObject.Find("Player").GetComponent<ESC>().asaa += 1;
        gameObject.SetActive(false);
    }
}
