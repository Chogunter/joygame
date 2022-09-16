using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4pockbaldis : MonoBehaviour
{
    public List<GameObject> gamob;

    private void OnTriggerEnter(Collider other)
    {
        if (!gamob.Contains(other.gameObject))
        {
            gamob.Add(other.gameObject);
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
