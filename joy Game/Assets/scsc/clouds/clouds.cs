using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
{
    Vector3 size = new Vector3();
    WaitForSeconds sec = new WaitForSeconds(0.05f);
    Vector3 a = new Vector3();
    int i;
    Coroutine coroutine;

    private void OnEnable()
    {
        i = 0;
        size = transform.localScale;
        a = size / 20;
        transform.localScale = Vector3.one * 3;
        coroutine = StartCoroutine(ani());
    }

    IEnumerator ani()
    {
        ++i;
        transform.localScale += a;
        yield return sec;
        if (i < 19)
        {
            coroutine = StartCoroutine(ani());
        }
    }
}
