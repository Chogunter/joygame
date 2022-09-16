using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_remove : MonoBehaviour
{
    public GameObject namu;
    public GameObject doll;
    public int namus;
    public int dolls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Cursorremove")
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                for(int i = 0; i < namus; i++)
                {
                    Instantiate(namu, transform.position, Quaternion.identity);
                }
                for (int i = 0; i < dolls; i++)
                {
                    Instantiate(doll, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
        }
    }
}
