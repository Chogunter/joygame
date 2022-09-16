using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyteammaneger : MonoBehaviour
{
    public List<GameObject> enemys;
    List<Enemymove> Enemycs = new List<Enemymove>();

    public List<bool> enemybool = new List<bool>();

    private void Awake()
    {
        for(int i = 0; i < enemys.Count; i++)
        {
            Enemycs.Add(enemys[i].GetComponent<Enemymove>());
        }
    }
    private void OnEnable()
    {
        //for (int i = 0; i < Loading_Manager.NeedToBeCalled.Count; i++)
        //{
        //    if (Loading_Manager.NeedToBeCalled[i] == gameObject)
        //    {
        //        Loading_Manager.NeedToBeCalled[i] = null;
        //        return;
        //    }
        //}
        for (int i = 0; i < enemys.Count; i++)
        {
            enemys[i].SetActive(true);
        }
        for(int i = 0; i < enemys.Count; i++)
        {
            for(int j = 0; j < Enemycs.Count; j++)
            {
                if(Enemycs[i].teams.Count > j)
                {
                    Enemycs[i].teams[j] = enemys[j];
                    continue;
                }
                Enemycs[i].teams.Add(enemys[j]);
            }
        }
    }

    void Update()
    {
        for(int i = 0; i < enemys.Count; i++)
        {
            if(enemybool.Count > i)
            {
                enemybool[i] = enemys[i].activeSelf;
            }
            enemybool.Add(enemys[i].activeSelf);
        }
        for(int i = 0; i < enemys.Count; i++)
        {
            if (enemys[i].activeSelf)
            {
                return;
            }
        }
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
