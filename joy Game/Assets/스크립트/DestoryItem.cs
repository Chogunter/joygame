using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -2)
        {
            if(this.tag == "SangMul")
            {
                GameObject.Find("Player").GetComponent<DoguThrowAway>().SangMuls -= 1;
            }
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
