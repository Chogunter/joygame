using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeaJackchooser : MonoBehaviour
{
    //철 곡 : 나무 200 철괴 50 작물 5 
    //철도끼 : 나무 200 철괴 45 작물 5
    //철 검 : 나무 150 철괴 120 작물 5 
    //단검 : 나무 50 철 60 작물 5
    //리무버 : 나무 500 고기 200 작물 250 
    //청사진mk2 : 나무 250 고기 300 작물 200
    GameObject JeaJackDea_;
    GameObject JeaJackDea_1;
    GameObject JeaJackDea_2;
    GameObject JeaJackDea_3;

    private void Start()
    {
        JeaJackDea_ = GameObject.Find("JeaJackDea_");
        JeaJackDea_1 = GameObject.Find("JeaJackDea_ (1)");
        JeaJackDea_2 = GameObject.Find("JeaJackDea_ (2)");
        JeaJackDea_3 = GameObject.Find("JeaJackDea_ (3)");
    }
    public void chulgock()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("chulGock");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "chulGock";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "chulgui";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = chulguidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void chulnamugock()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("chulnamuGock");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "chulnamuGock";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "chulgui";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = chulguidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void chulgum()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("chulgum");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "chulgum";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "chulgui";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = chulguidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void chuldangum()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("chuldangum");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "chuldangum";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "chulgui";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = chulguidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void remover()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("remover");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "remover";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "Gogi";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = gogidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void mk2()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("chunsajinmk2");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "chunsajinmk2";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "Namu";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = namudad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "Gogi";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = gogidad;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "jackMul";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = jackMuldad;
    }
    public void gapock()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.JeaJackDea.Contatin("gapock");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;

        JeaJackDea_.GetComponent<JeaJackchoose>().Ahhh = "gapock";
        JeaJackDea_.GetComponent<JeaJackchoose>().num = 1;

        JeaJackDea_1.GetComponent<JeaJackchoose>().Ahhh = "chulgui";
        JeaJackDea_1.GetComponent<JeaJackchoose>().num = chulguidad;
        JeaJackDea_2.GetComponent<JeaJackchoose>().Ahhh = "None";
        JeaJackDea_2.GetComponent<JeaJackchoose>().num = 0;
        JeaJackDea_3.GetComponent<JeaJackchoose>().Ahhh = "None";
        JeaJackDea_3.GetComponent<JeaJackchoose>().num = 0;
    }
}
