using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redcoretopiece : MonoBehaviour
{
    public int hp = 200;
    [SerializeField] int or_hp = 200;
    [SerializeField] private GameObject corepiece;

    GameObjectPool game_object_pool;

    private void Awake()
    {
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
    }

    private void OnEnable()
    {
        hp = or_hp;
    }

    void Update()
    {
        if(hp <= 0)
        {
            Break();
        }
    }

    void Break()
    {
        for (int i = 0; i < 40; i++)
        {
            game_object_pool.Instantiates("corepiece", transform.position, Quaternion.identity);
        }
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
