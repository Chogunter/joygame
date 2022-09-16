using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habsungchoose : MonoBehaviour
{
    public List<string> Unlockedthing = new List<string>();

    public GameObject slot1;
    public GameObject slot2;

    public GameObject orange1;
    public GameObject red1;
    public GameObject puple1;

    private void Awake()
    {
        Unlockedthing.Add("greencore");
        slot1.GetComponent<itemslotscript>().a = "none";
        slot1.GetComponent<itemslotscript>().amount = 0;
        slot2.GetComponent<itemslotscript>().a = "none";
        slot2.GetComponent<itemslotscript>().amount = 0;
    }

    private void Update()
    {
        for(int i = 0; i < Unlockedthing.Count; i++)
        {
            if(Unlockedthing[i] == "orangecore")
            {
                orange1.SetActive(true);
            }
            if (Unlockedthing[i] == "redcore")
            {
                red1.SetActive(true);
            }
            if (Unlockedthing[i] == "puplecore")
            {
                puple1.SetActive(true);
            }
        }
    }

    public void Greencore()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("greencore");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;

        slot1.GetComponent<itemslotscript>().a = "greencore";
        slot1.GetComponent<itemslotscript>().amount = 1;

        slot2.GetComponent<itemslotscript>().a = "namu";
        slot2.GetComponent<itemslotscript>().amount = namudad;
    }
    public void Orangecore()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("orangecore");
        int namudad = Item_make_info.Searchfor("greencore", thatInfo.materials).amount;

        slot1.GetComponent<itemslotscript>().a = "orangecore";
        slot1.GetComponent<itemslotscript>().amount = 1;

        slot2.GetComponent<itemslotscript>().a = "greencore";
        slot2.GetComponent<itemslotscript>().amount = namudad;
    }
    public void Redcore()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("redcore");
        int namudad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;

        slot1.GetComponent<itemslotscript>().a = "redcore";
        slot1.GetComponent<itemslotscript>().amount = 1;

        slot2.GetComponent<itemslotscript>().a = "orangecore";
        slot2.GetComponent<itemslotscript>().amount = namudad;
    }
    public void Puplecore()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("puplecore");
        int namudad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;

        slot1.GetComponent<itemslotscript>().a = "puplecore";
        slot1.GetComponent<itemslotscript>().amount = 1;

        slot2.GetComponent<itemslotscript>().a = "redcore";
        slot2.GetComponent<itemslotscript>().amount = namudad;
    }
    public void Corepiece()
    {
        //?없는데요
        slot1.GetComponent<itemslotscript>().a = "corepiece";
        slot1.GetComponent<itemslotscript>().amount = 40;

        slot2.GetComponent<itemslotscript>().a = "redcore";
        slot2.GetComponent<itemslotscript>().amount = 1;
    }
}
