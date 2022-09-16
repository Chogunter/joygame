using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atest : MonoBehaviour
{
    public Texture2D image2;
    public Texture2D image3;

    public Material iwdi;

    void Start()
    {
        
    }

    void Update()
    {
        iwdi.SetTexture("_MainTex", image3);
    }
}
