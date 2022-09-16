using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class house : MonoBehaviour
{
    [SerializeField] List<GameObject> sangjas;
    List<SangJJasaveandload> sangja = new List<SangJJasaveandload>();

    [Serializable]
    public class materials
    {
        public string item;
        public int min;
        public int max;
        public float percentage;
    }

    [Serializable]
    public class items
    {
        public List<materials> material = new List<materials>();
    }
    public List<items> itemm = new List<items>();

    [Serializable]
    public class BuildingName 
    {
        public string Name;
        public List<GameObject> BuildingItem = new List<GameObject>();
    }

    [SerializeField] List<BuildingName> Buildings = new List<BuildingName>();

    GameObjectPool game_object_pool;
    void Resets()
    {
        for(int i = 0; i < sangjas.Count; i++)
        {
            sangja.Add(sangjas[i].GetComponent<SangJJasaveandload>());
        }

        for(int i = 0; i < itemm.Count; i++)
        {
            for(int j = 0; j < itemm[i].material.Count; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    materials a = itemm[i].material[j];
                    int b = UnityEngine.Random.Range(1, 101);
                    if (100 - a.percentage <= b)
                    {
                        if (sangja[i].num1 == 0)
                        {
                            sangja[i].Item1 = a.item;
                            sangja[i].num1 = UnityEngine.Random.Range(a.min, a.max + 1);
                        }
                        else if (sangja[i].num2 == 0)
                        {
                            sangja[i].Item2 = a.item;
                            sangja[i].num2 = UnityEngine.Random.Range(a.min, a.max + 1);
                        }
                    }
                }
            }
        }
    }

    private void Start()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Resets();
        AddPool();
    }

    void AddPool()
    {
        foreach(BuildingName a in Buildings)
        {
            if(a == null)
            {
                continue;
            }
            if (a.BuildingItem == null)
            {
                continue;
            }
            foreach (GameObject b in a.BuildingItem)
            {
                if (b == null)
                {
                    continue;
                }
                game_object_pool.AddGameObjectInPool(a.Name, b);
            }
        }
    }
}
