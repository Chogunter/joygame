using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackMulscript : MonoBehaviour
{
    public float time;
    public float randomtime;
    public GameObject olderthing;
    public GameObject JackMuls;

    public bool isolderthing;

    private GameObject a;

    bool s = true;

    GameObjectPool gameobjectpool;

    private void Awake()
    {
        gameobjectpool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
    }
    private void OnEnable()
    {
        for (int i = 0; i < Loading_Manager.NeedToBeCalled.Count; i++)
        {
            if (Loading_Manager.NeedToBeCalled[i] == gameObject)
            {
                Loading_Manager.NeedToBeCalled[i] = null;
                return;
            }
        }
        time = 0;
    }

    void Update()
    {
        if (!isolderthing)
        {
            if (s)
            {
                randomtime = Random.Range(20, 30);
                s = false;
            }
            time += Time.deltaTime;
            if (time > randomtime)
            {
                //Instantiate(olderthing, this.transform.position, this.transform.rotation);
                //Destroy(gameObject);
                gameobjectpool.Instantiates("jackmul2", this.transform.position, this.transform.rotation);
                gameObject.SetActive(false);
            }
        }
    }
    public void GetJackMul()
    {
        a.GetComponent<JackMulDDangasda>().sss = true;
        gameobjectpool.Instantiates("jackmulItem", this.transform.position + new Vector3(0, 1, 0), this.transform.rotation);
        gameobjectpool.Instantiates("jackmulItem", this.transform.position + new Vector3(0, 1, 0), this.transform.rotation);
        //Destroy(this.transform.parent.gameObject);
        this.transform.parent.gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "JackMulpos")
        {
            a = other.gameObject;
            a.GetComponent<JackMulDDangasda>().sss = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JackMulpos")
        {
            a = other.gameObject;
            a.GetComponent<JackMulDDangasda>().sss = false;
        }
    }
}
