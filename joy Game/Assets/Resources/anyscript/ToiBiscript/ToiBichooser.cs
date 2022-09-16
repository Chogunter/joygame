using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiBichooser : MonoBehaviour
{
    //경작지 : 나무 150 작물 20 고기 150
    //묘목 : 나무 30 작물 40 고기 100

    GameObject ToiBiTong_;
    GameObject ToiBiTong_1;
    GameObject ToiBiTong_2;
    GameObject ToiBiTong_3;

    private void Start()
    {
        ToiBiTong_ = GameObject.Find("ToiBiTong_");
        ToiBiTong_1 = GameObject.Find("ToiBiTong_ (1)");
        ToiBiTong_2 = GameObject.Find("ToiBiTong_ (2)");
        ToiBiTong_3 = GameObject.Find("ToiBiTong_ (3)");
    }
    public void Myomock()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.ToiBi.Contatin("myomock");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;

        ToiBiTong_.GetComponent<ToiBichoose>().theitem = "myomock";
        ToiBiTong_.GetComponent<ToiBichoose>().num = 1;

        ToiBiTong_1.GetComponent<ToiBichoose>().theitem = "namu";
        ToiBiTong_1.GetComponent<ToiBichoose>().num = namudad;
        ToiBiTong_2.GetComponent<ToiBichoose>().theitem = "jackMul";
        ToiBiTong_2.GetComponent<ToiBichoose>().num = jackMuldad;
        ToiBiTong_3.GetComponent<ToiBichoose>().theitem = "gogi";
        ToiBiTong_3.GetComponent<ToiBichoose>().num = gogidad;
    }
    public void Jackmulldang()
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.ToiBi.Contatin("jackMulddang");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;

        ToiBiTong_.GetComponent<ToiBichoose>().theitem = "jackMulddang";
        ToiBiTong_.GetComponent<ToiBichoose>().num = 1;

        ToiBiTong_1.GetComponent<ToiBichoose>().theitem = "namu";
        ToiBiTong_1.GetComponent<ToiBichoose>().num = namudad;
        ToiBiTong_2.GetComponent<ToiBichoose>().theitem = "jackMul";
        ToiBiTong_2.GetComponent<ToiBichoose>().num = jackMuldad;
        ToiBiTong_3.GetComponent<ToiBichoose>().theitem = "gogi";
        ToiBiTong_3.GetComponent<ToiBichoose>().num = gogidad;
    }
}
