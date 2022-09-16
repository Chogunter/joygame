using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadkillscript : MonoBehaviour
{
    public float velocity;
    [SerializeField] private float damage;
    [SerializeField] private float killvelocity;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "SangMul")
        {
            if(velocity > killvelocity)
            {
                if ((int)(velocity * damage - killvelocity * damage) > 50)
                {
                    other.GetComponent<SangMul>().SangMul_Hp -= 50;
                }
                else
                {
                    other.GetComponent<SangMul>().SangMul_Hp -= (int)(velocity * damage - killvelocity * damage);
                }
            }
        }

        if (other.tag == "Enemy")
        {
            if (velocity > killvelocity)
            {
                if ((int)(velocity * damage - killvelocity * damage) > 50)
                {
                    other.GetComponent<Enemymove>().Hp -= 50;
                }
                else
                {
                    other.GetComponent<Enemymove>().Hp -= (int)(velocity * damage - killvelocity * damage);
                }
            }
        }

        if (other.tag == "Monsters")
        {
            if (velocity > killvelocity)
            {
                if ((int)(velocity * damage - killvelocity * damage) > 50)
                {
                    other.GetComponent<monsterscript>().Hp -= 50;
                }
                else
                {
                    other.GetComponent<monsterscript>().Hp -= (int)(velocity * damage - killvelocity * damage);
                }
            }
        }

        if (other.tag == "boss")
        {
            if (other.GetComponent<close_boss>())
            {
                if (velocity > killvelocity)
                {
                    if ((int)(velocity * damage - killvelocity * damage) > 50)
                    {
                        other.GetComponent<close_boss>().Hp -= 50;
                    }
                    else
                    {
                        other.GetComponent<close_boss>().Hp -= (int)(velocity * damage - killvelocity * damage);
                    }
                }
            }
            if (other.GetComponent<long_boss>())
            {
                if (velocity > killvelocity)
                {
                    if ((int)(velocity * damage - killvelocity * damage) > 50)
                    {
                        other.GetComponent<long_boss>().Hp -= 50;
                    }
                    else
                    {
                        other.GetComponent<long_boss>().Hp -= (int)(velocity * damage - killvelocity * damage);
                    }
                }
            }
        }
        if (other.GetComponent<Buildingbreak>())
        {
            if (velocity > killvelocity)
            {
                if ((int)(velocity * damage - killvelocity * damage) > 200)
                {
                    other.GetComponent<Buildingbreak>().HP -= 200;
                }
                else
                {
                    other.GetComponent<Buildingbreak>().HP -= (int)(velocity * damage - killvelocity * damage);
                }
            }
        }
    }
}
