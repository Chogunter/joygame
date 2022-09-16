using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoguMakeCHooser : MonoBehaviour
{
    //활 = 나무50 + 고기20 / 있으면 화살 나무15 + 돌10 (2개)
    //검 = 나무30 + 돌150
    //돌곡 = 나무75 + 돌100
    //나무곡 = 나무75 + 돌65
    //나무돌곡 = 나무250
    //나무나무곡 = 나무200
    private bool HwalDool = false;

    GameObject DoguSlot;
    GameObject Dogu_changes1;
    GameObject Dogu_changes2;
    void Start()
    {
        DoguSlot = GameObject.Find("DoguSlot");
        Dogu_changes1 = GameObject.Find("Dogu_changes1");
        Dogu_changes2 = GameObject.Find("Dogu_changes2");
    }
    public void ChungSAJNIN()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "chunsajin";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("chunsajin");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Gogi";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = gogiada;//150;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = namuadad;// 300;
    }
    public void NamuNamuGock()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "namunamugock";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("chunsajin");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "None";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = 0;
    }
    public void NamuDollGock()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "namudollgock";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("namudollgock");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;// 250;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "None";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = 0;
    }

    public void NamuGock()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "NamuGock";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("NamuGock");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Doll";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = dolnnada;
    }
    public void DollGock()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "DollGock";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;


        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("DollGock");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Doll";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = dolnnada;
    }
    public void Gum()
    {
        DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "Gum";
        DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

        Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("Gum");
        int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
        int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
        int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

        Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
        Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
        Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Doll";
        Dogu_changes2.GetComponent<DoguMakeChoose>().num = dolnnada;
    }
    public void Hwal()
    {
        //GameObject.Find("Player").GetComponent<PlayerHand>().PickUp1
        if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp1 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp2 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp3 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp4 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp5 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp6 == "hwal")
            HwalDool = true;
        else if (GameObject.Find("Player").GetComponent<PlayerHand>().PickUp7 == "hwal")
            HwalDool = true;
        else
            HwalDool = false;

        if (!HwalDool)
        {
            Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("Hwal");

            DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "Hwal";
            DoguSlot.GetComponent<DoguMakeChoose>().num = 1;

            int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
            int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
            int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

            Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
            Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
            Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Gogi";
            Dogu_changes2.GetComponent<DoguMakeChoose>().num = gogiada;
        }
        else
        {
            DoguSlot.GetComponent<DoguMakeChoose>().DOguChoice = "HwaSal";
            DoguSlot.GetComponent<DoguMakeChoose>().num = 2;

            Item_make_info.MakerItem aaaaa = Item_make_info.Dogu.Contatin("Gum");
            int namuadad = Item_make_info.Searchfor("namu", aaaaa.materials).amount;
            int dolnnada = Item_make_info.Searchfor("doll", aaaaa.materials).amount;
            int gogiada = Item_make_info.Searchfor("gogi", aaaaa.materials).amount;

            Dogu_changes1.GetComponent<DoguMakeChoose>().DOguChoice = "Namu";
            Dogu_changes1.GetComponent<DoguMakeChoose>().num = namuadad;
            Dogu_changes2.GetComponent<DoguMakeChoose>().DOguChoice = "Doll";
            Dogu_changes2.GetComponent<DoguMakeChoose>().num = dolnnada;
        }
    }
}
