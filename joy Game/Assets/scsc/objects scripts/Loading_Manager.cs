using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Loading_Manager
{
    public static bool isLoaded;
    public static bool isExit;

    //public class OKDIA
    //{
    //    public GameObject gameobject;
    //    public bool called;
    //}
    //public static List<OKDIA> needToCalled = new List<OKDIA>();
    public static List<GameObject> NeedToBeCalled = new List<GameObject>();
}
