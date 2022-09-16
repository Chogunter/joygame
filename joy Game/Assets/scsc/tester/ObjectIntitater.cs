using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIntitater : MonoBehaviour
{
    [System.Serializable]
    public class Objecter
    {
        public string Object;
        public Vector3 pos;
        public Vector3 rot;
    }
    [SerializeField] List<Objecter> institateObject = new List<Objecter>();

    GameObjectPool gamepool;

    void Start()
    {
        gamepool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();

        for(int i = 0; i < institateObject.Count; i++)
        {
            gamepool.Instantiates(institateObject[i].Object, institateObject[i].pos, Quaternion.Euler(institateObject[i].rot));
        }
    }
}
