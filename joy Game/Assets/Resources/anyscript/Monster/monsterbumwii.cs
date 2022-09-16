using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterbumwii : MonoBehaviour
{
    public List<GameObject> dww;

    private void OnDisable()
    {
        dww = new List<GameObject>() { };
    }

    private void Update()
    {
        for(int i = dww.Count - 1; i >= 0; i--)
        {
            if (!dww[i].activeSelf)
            {
                dww.Remove(dww[i]);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!dww.Contains(other.gameObject))
        {
            dww.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (dww.Contains(other.gameObject))
        {
            dww.Remove(other.gameObject);
        }
    }
}
