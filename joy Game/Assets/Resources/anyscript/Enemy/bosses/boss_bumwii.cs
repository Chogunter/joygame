using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_bumwii : MonoBehaviour
{
    public List<GameObject> gamob;

    private void OnDisable()
    {
        gamob = new List<GameObject>() { };
    }

    private void Update()
    {
        for(int i = gamob.Count - 1; i >= 0; i--)
        {
            if (!gamob[i].activeSelf)
            {
                gamob.RemoveAt(i);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" || other.tag == "Monsters" ||
            other.tag == "Player" || other.tag == "SangMul")
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
