using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_boss_attacker : MonoBehaviour
{
    public List<GameObject> gamob;
    private void OnDisable()
    {
        gamob = new List<GameObject>() { };
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" || other.tag == "Monsters" ||
            other.tag == "Player" || other.tag == "SangMul" || 
            other.GetComponent<Buildingbreak>())
        {
            if (!gamob.Contains(other.gameObject))
            {
                gamob.Add(other.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (gamob.Contains(other.gameObject))
        {
            gamob.Remove(other.gameObject);
        }
    }
}
