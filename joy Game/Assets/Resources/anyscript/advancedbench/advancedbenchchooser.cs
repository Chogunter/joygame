using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advancedbenchchooser : MonoBehaviour
{
    [SerializeField] List<GameObject> nyang;
    List<itemslotscript> nya = new List<itemslotscript>();
    private void Start()
    {
        for(int i = 0; i < nyang.Count; i++)
        {
            if(nya == null)
            {
                nya.Add(nyang[i].GetComponent<itemslotscript>());
                continue;
            }
            if(nya.Count - 1 >= i)
            {
                nya[i] = nyang[i].GetComponent<itemslotscript>();
                continue;
            }
            nya.Add(nyang[i].GetComponent<itemslotscript>());
        }
    }

    public void DrilMake() // 철괴 500  코어조각 300  오랜지코어 1  보라색코어 1  철곡괭이 1
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("dril");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "dril";
        nya[0].amount = amountdad;

        nya[1].a = "chulgui";
        nya[1].amount = chulguidad;

        nya[2].a = "corepiece";
        nya[2].amount = piecedad;

        nya[3].a = "orangecore";
        nya[3].amount = orangedad;

        nya[4].a = "puplecore";
        nya[4].amount = puppledad;

        nya[5].a = "chulGock";
        nya[5].amount = chulgockdad;
    }
    public void HubipgiMake() // 고기 300 작물 3000 경작지 1 코어조각 30 
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("hubipgi");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "hubipgi";
        nya[0].amount = amountdad;

        nya[1].a = "gogi";
        nya[1].amount = gogidad;

        nya[2].a = "jackMul";
        nya[2].amount = jackMuldad;

        nya[3].a = "jackMulddang";
        nya[3].amount = jackMulddangdad;

        nya[4].a = "corepiece";
        nya[4].amount = piecedad;

        nya[5].a = "none";
        nya[5].amount = 0;
    }

    public void SIgeaMake() // 철괴 300 오랜지코어 1 빨간코어 1 보라색코어 1
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("sigea");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "sigea";
        nya[0].amount = amountdad;

        nya[1].a = "chulgui";
        nya[1].amount = chulguidad;

        nya[2].a = "orangecore";
        nya[2].amount = orangedad;

        nya[3].a = "redcore";
        nya[3].amount = reddad;

        nya[4].a = "puplecore";
        nya[4].amount = puppledad;

        nya[5].a = "none";
        nya[5].amount = 0;
    }

    public void ChongMake() // 나무 2500 철괴 750 빨간코어 2
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("chong");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "chong";
        nya[0].amount = amountdad;

        nya[1].a = "namu";
        nya[1].amount = namudad;

        nya[2].a = "chulgui";
        nya[2].amount = chulguidad;

        nya[3].a = "redcore";
        nya[3].amount = reddad;

        nya[4].a = "none";
        nya[4].amount = 0;

        nya[5].a = "none";
        nya[5].amount = 0;
    }

    public void TangchangMake() // 철괴 200  코어조각 200 
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("tangchang");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "tangchang";
        nya[0].amount = amountdad;

        nya[1].a = "chulgui";
        nya[1].amount = chulguidad;

        nya[2].a = "corepiece";
        nya[2].amount = piecedad;

        nya[3].a = "none";
        nya[3].amount = 0;

        nya[4].a = "none";
        nya[4].amount = 0;

        nya[5].a = "none";
        nya[5].amount = 0;
    }
    public void SuryutangMake() // 철괴 300 코어조각 500
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("suryutang");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "suryutang";
        nya[0].amount = amountdad;

        nya[1].a = "chulgui";
        nya[1].amount = chulguidad;

        nya[2].a = "corepiece";
        nya[2].amount = piecedad;

        nya[3].a = "none";
        nya[3].amount = 0;

        nya[4].a = "none";
        nya[4].amount = 0;

        nya[5].a = "none";
        nya[5].amount = 0;
    }

    public void C4Make() // 고기 50 철괴 300 코어조각 700 오랜지코어 1 빨간코어 2
    {
        Item_make_info.MakerItem thatInfo = Item_make_info.Advenced.Contatin("C4");
        int namudad = Item_make_info.Searchfor("namu", thatInfo.materials).amount;
        int gogidad = Item_make_info.Searchfor("gogi", thatInfo.materials).amount;
        int jackMuldad = Item_make_info.Searchfor("jackMul", thatInfo.materials).amount;
        int jackMulddangdad = Item_make_info.Searchfor("jackMulddang", thatInfo.materials).amount;
        int chulguidad = Item_make_info.Searchfor("chulgui", thatInfo.materials).amount;
        int orangedad = Item_make_info.Searchfor("orangecore", thatInfo.materials).amount;
        int reddad = Item_make_info.Searchfor("redcore", thatInfo.materials).amount;
        int puppledad = Item_make_info.Searchfor("puplecore", thatInfo.materials).amount;
        int piecedad = Item_make_info.Searchfor("corepiece", thatInfo.materials).amount;
        int chulgockdad = Item_make_info.Searchfor("chulGock", thatInfo.materials).amount;
        int amountdad = thatInfo.amount;

        nya[0].a = "C4";
        nya[0].amount = amountdad;

        nya[1].a = "gogi";
        nya[1].amount = gogidad;

        nya[2].a = "chulgui";
        nya[2].amount = chulguidad;

        nya[3].a = "corepiece";
        nya[3].amount = piecedad;

        nya[4].a = "orangecore";
        nya[4].amount = orangedad;

        nya[5].a = "redcore";
        nya[5].amount = reddad;
    }
}
