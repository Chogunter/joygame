using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myomockscript : MonoBehaviour
{
    public float time;
    public float needtime;
    public GameObject olderthanyou;

    bool s = true;

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
        s = true;
        time = 0;
    }

    void Update()
    {
        if (s)
        {
            needtime = Random.Range(250, 300);
            s = false;
        }
        time += Time.deltaTime;
        if(time >= needtime)
        {
            GameObjectPool gameobjectpool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
            gameobjectpool.Instantiates("namu_myomock", transform.position + new Vector3(0, 2, 0), transform.rotation);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
