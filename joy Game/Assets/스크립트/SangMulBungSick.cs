using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SangMulBungSick : MonoBehaviour
{
    public GameObject BungSick;
    public GameObject BungSickGuildlyojim;
    private float time;
    public int random;
    private bool sss = true;

    GameObject Player;
    GameObjectPool game_object_pool;
    // Start is called before the first frame update
    void Start()
    {
        random = 0;
        Player = GameObject.Find("Player");
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 10f)
        {
            random = Random.Range(0, 50);
            time = 0f;
            sss = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "SangMul")
        {
            if (random == 1 && sss)
            {
                if (this.GetComponentInParent<SangMul>().gildulilljim)
                {
                    game_object_pool.Instantiates("sangmul_domesticated", this.transform.position + new Vector3(1f, 0.5f, 1f), Quaternion.identity);


                }
                else
                {
                    game_object_pool.Instantiates("sangmul", this.transform.position + new Vector3(1f, 0.5f, 1f), Quaternion.identity);
                    Player.GetComponent<DoguThrowAway>().SangMuls += 1;
                }
                random = 60;
                sss = false;
            }
        }
    }
}
