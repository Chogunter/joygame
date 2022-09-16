using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redbuildhang : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private List<GameObject> list;
    int iNt;
    public bool thatBuildinghasstock = false;
    void Start()
    {
        
    }

    void Update()
    {
        thatBuildinghasstock = !Player.GetComponent<DoguThrowAway>().canBuild;
        if (thatBuildinghasstock)
        {
            iNt = Player.GetComponent<DoguThrowAway>().thatBuilding;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == iNt)
                {
                    list[i].SetActive(true);
                }
                else
                {
                    list[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetActive(false);
            }
        }
    }
}
