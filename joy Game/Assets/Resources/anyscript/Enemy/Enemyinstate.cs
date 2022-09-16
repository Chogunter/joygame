using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyinstate : MonoBehaviour
{
    public List<GameObject> enemy;
    [SerializeField] GameObject Enemy_ob;

    [SerializeField] List<GameObject> teamss;
    void Start()
    {
        //InstateEnemy(50, Vector3.zero, "anything", 100, 0);
    }

    void Update()
    {
        
    }
    void InstateEnemy(int number, Vector3 pos, string type, int Hp, float offense_power)
    {
        for (int x = 0; x < number; x++)
        {
            if (enemy != null)
            {
                for (int i = 0; i < enemy.Count; i++)
                {
                    if (enemy[i].activeSelf == false)
                    {
                        enemy[i].SetActive(true);
                        enemy[i].GetComponent<Enemymove>().Max_Hp = Hp;
                        enemy[i].GetComponent<Enemymove>().Hp = Hp;
                        enemy[i].GetComponent<Enemymove>().type = type;
                        enemy[i].GetComponent<Enemymove>().Look.GetComponent<EnemyLook>().dam_ratio = offense_power;
                        enemy[i].transform.position = pos;
                        teamss.Add(enemy[i]);
                        break;
                    }
                }
            }
            var that = Instantiate(Enemy_ob);
            enemy.Add(that);
            that.SetActive(true);
            that.GetComponent<Enemymove>().Max_Hp = Hp;
            that.GetComponent<Enemymove>().Hp = Hp;
            that.GetComponent<Enemymove>().type = type;
            that.GetComponent<Enemymove>().Look.GetComponent<EnemyLook>().dam_ratio = offense_power;
            that.transform.position = pos;
            teamss.Add(that);
        }
        for(int j = 0; j < teamss.Count; j++)
        {
            for (int k = 0; k < teamss.Count; k++)
            {
                teamss[j].GetComponent<Enemymove>().teams.Add(teamss[k]);
            }
        }
    }
}
