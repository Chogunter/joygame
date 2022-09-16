using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangJJasaveandload : MonoBehaviour
{
    public string Item1;
    public int num1;
    public string Item2;
    public int num2;
    public bool Isdontbreak;

    GameObjectPool game_object_pool;
    private void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
    }

    private void OnDisable()
    {
        if (Loading_Manager.isExit == true) return;

        if (Item1 == null || num1 == 0)
        {
            Item1 = "none";
            num1 = 0;
        }
        if (Item2 == null || num2 == 0)
        {
            Item2 = "none";
            num2 = 0;
        }
        if (num1 <= 0 && num2 <= 0)
        {
            return;
        }
        if(Item1 == "chong")
        {
            var bullet = game_object_pool.InstantiatesObject("chong", transform.position + Vector3.up, Quaternion.identity);
            bullet.GetComponent<tangsave>().tang = num1 - 1;
            Item1 = "none";
            num1 = 0;
        }
        if (Item2 == "chong")
        {
            var bullet = game_object_pool.InstantiatesObject("chong", transform.position + Vector3.up, Quaternion.identity);
            bullet.GetComponent<tangsave>().tang = num2 - 1;
            Item2 = "none";
            num2 = 0;
        }
        var that = game_object_pool.InstantiatesObject("muckum", transform.position, Quaternion.identity);
        that.GetComponent<PlayerDiedMuckUm>().SangJaItems(Item1, num1, Item2, num2);
        Item1 = "none";
        num1 = 0;
        Item2 = "none";
        num2 = 0;
    }
}
