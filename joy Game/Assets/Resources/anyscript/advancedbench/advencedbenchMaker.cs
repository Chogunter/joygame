using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advencedbenchMaker : MonoBehaviour
{
    bool Makes;
    bool AAAs;
    int AAA;

    int Namus;
    int Gogis;
    int JackMuls;
    int chulguis;
    int reds;
    int oranges;
    int puples;
    int pieces;
    int chulgocks;
    int jackmulddangs;

    [SerializeField] GameObject AdvencedBench_;
    PlayerHand ppl;
    itemslotscript advencedbench_s;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Player;
        Player = GameObject.Find("Player");
        ppl = Player.GetComponent<PlayerHand>();
        advencedbench_s = AdvencedBench_.GetComponent<itemslotscript>();
    }

    // 드릴
    // 철괴 500  코어조각 300  오랜지코어 1  보라색코어 1  철곡괭이 1

    // 흡입기
    // 고기 300 작물 3000 경작지 1 코어조각 30

    // 시계
    // 철괴 300 오랜지코어 1 빨간코어 1 보라색코어 1

    //총
    // 나무 2500 철괴 750 빨간코어 2

    //탄창
    // 철괴 200  코어조각 200 

    //수류탄
    // 철괴 300 코어조각 500

    //C4
    // 고기 50 철괴 300 코어조각 700 오랜지코어 1 빨간코어 2
    public void Click()
    {
        check();
        if(advencedbench_s.a == "dril")
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

            if (chulguis >= chulguidad && pieces >= piecedad && oranges >= orangedad && puples >= puppledad && chulgocks >= chulgockdad)
            {
                Make("dril", 1, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad);
            }
        }
        else if(advencedbench_s.a == "hubipgi")
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

            if (Gogis >= gogidad && JackMuls >= jackMuldad && jackmulddangs >= jackMulddangdad && pieces >= piecedad)
            {
                Make("hubipgi", 50, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad);// 0, 300, 3000, 1, 0, 0, 0, 0, 30, 0);
            }
        }
        else if (advencedbench_s.a == "sigea")
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

            if (chulguis >= chulguidad && oranges >= orangedad && reds >= reddad && puples >= puppledad)
            {
                Make("sigea", 1, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad); //0, 0, 0, 0, 300, 1, 1, 1, 0, 0);
            }
        }
        else if (advencedbench_s.a == "chong")
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

            if (Namus >= namudad && chulguis >= chulguidad && reds >= reddad)
            {
                Make("chong", 0, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad);// 2500, 0, 0, 0, 750, 0, 2, 0, 0, 0);
            }
        }
        else if (advencedbench_s.a == "tangchang")
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

            if (chulguis > chulguidad && pieces >= piecedad)
            {
                Make("tangchang", 4500, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad);// 0, 0, 0, 0, 300, 0, 0, 0, 200, 0);
            }
        }
        else if (advencedbench_s.a == "suryutang")
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

            if (chulguis >= chulguidad && pieces >= piecedad)
            {
                Make("suryutang", 200, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad);// 0, 0, 0, 0, 300, 0, 0, 0, 500, 0);
            }
        }
        else if (advencedbench_s.a == "C4")
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

            if (Gogis >= gogidad && chulguis >= chulguidad && pieces >= piecedad && oranges >= orangedad && reds >= reddad)
            {
                Make("C4", 25, amountdad, namudad, gogidad, jackMuldad, jackMulddangdad, chulguidad, orangedad, reddad, puppledad, piecedad, chulgockdad); //0, 50, 0, 0, 300, 1, 2, 0, 700, 0);
            }
        }
        Resets();
    }

    void check()
    {
        if (true)
        {
            if (ppl.PickUp1 == "namu")
                Namus += ppl.Amount1;
            if (ppl.PickUp2 == "namu")
                Namus += ppl.Amount2;
            if (ppl.PickUp3 == "namu")
                Namus += ppl.Amount3;
            if (ppl.PickUp4 == "namu")
                Namus += ppl.Amount4;
            if (ppl.PickUp5 == "namu")
                Namus += ppl.Amount5;
            if (ppl.PickUp6 == "namu")
                Namus += ppl.Amount6;
            if (ppl.PickUp7 == "namu")
                Namus += ppl.Amount7;
        } // 나무
        if (true)
        {
            if (ppl.PickUp1 == "gogi")
                Gogis += ppl.Amount1;
            if (ppl.PickUp2 == "gogi")
                Gogis += ppl.Amount2;
            if (ppl.PickUp3 == "gogi")
                Gogis += ppl.Amount3;
            if (ppl.PickUp4 == "gogi")
                Gogis += ppl.Amount4;
            if (ppl.PickUp5 == "gogi")
                Gogis += ppl.Amount5;
            if (ppl.PickUp6 == "gogi")
                Gogis += ppl.Amount6;
            if (ppl.PickUp7 == "gogi")
                Gogis += ppl.Amount7;
        } // 고기
        if (true)
        {
            if (ppl.PickUp1 == "jackMul")
                JackMuls += ppl.Amount1;
            if (ppl.PickUp2 == "jackMul")
                JackMuls += ppl.Amount2;
            if (ppl.PickUp3 == "jackMul")
                JackMuls += ppl.Amount3;
            if (ppl.PickUp4 == "jackMul")
                JackMuls += ppl.Amount4;
            if (ppl.PickUp5 == "jackMul")
                JackMuls += ppl.Amount5;
            if (ppl.PickUp6 == "jackMul")
                JackMuls += ppl.Amount6;
            if (ppl.PickUp7 == "jackMul")
                JackMuls += ppl.Amount7;
        } // 작물
        if (true)
        {
            if (ppl.PickUp1 == "chulgui")
                chulguis += ppl.Amount1;
            if (ppl.PickUp2 == "chulgui")
                chulguis += ppl.Amount2;
            if (ppl.PickUp3 == "chulgui")
                chulguis += ppl.Amount3;
            if (ppl.PickUp4 == "chulgui")
                chulguis += ppl.Amount4;
            if (ppl.PickUp5 == "chulgui")
                chulguis += ppl.Amount5;
            if (ppl.PickUp6 == "chulgui")
                chulguis += ppl.Amount6;
            if (ppl.PickUp7 == "chulgui")
                chulguis += ppl.Amount7;
        } // 철괴
        if (true)
        {
            if (ppl.PickUp1 == "jackMulddang")
                jackmulddangs += ppl.Amount1;
            if (ppl.PickUp2 == "jackMulddang")
                jackmulddangs += ppl.Amount2;
            if (ppl.PickUp3 == "jackMulddang")
                jackmulddangs += ppl.Amount3;
            if (ppl.PickUp4 == "jackMulddang")
                jackmulddangs += ppl.Amount4;
            if (ppl.PickUp5 == "jackMulddang")
                jackmulddangs += ppl.Amount5;
            if (ppl.PickUp6 == "jackMulddang")
                jackmulddangs += ppl.Amount6;
            if (ppl.PickUp7 == "jackMulddang")
                jackmulddangs += ppl.Amount7;
        } // 경작지 
        if (true)
        {
            if (ppl.PickUp1 == "chulGock")
                chulgocks += ppl.Amount1;
            if (ppl.PickUp2 == "chulGock")
                chulgocks += ppl.Amount2;
            if (ppl.PickUp3 == "chulGock")
                chulgocks += ppl.Amount3;
            if (ppl.PickUp4 == "chulGock")
                chulgocks += ppl.Amount4;
            if (ppl.PickUp5 == "chulGock")
                chulgocks += ppl.Amount5;
            if (ppl.PickUp6 == "chulGock")
                chulgocks += ppl.Amount6;
            if (ppl.PickUp7 == "chulGock")
                chulgocks += ppl.Amount7;
        } // 철곡
        if (true)
        {
            if (ppl.PickUp1 == "redcore")
                reds += ppl.Amount1;
            if (ppl.PickUp2 == "redcore")
                reds += ppl.Amount2;
            if (ppl.PickUp3 == "redcore")
                reds += ppl.Amount3;
            if (ppl.PickUp4 == "redcore")
                reds += ppl.Amount4;
            if (ppl.PickUp5 == "redcore")
                reds += ppl.Amount5;
            if (ppl.PickUp6 == "redcore")
                reds += ppl.Amount6;
            if (ppl.PickUp7 == "redcore")
                reds += ppl.Amount7;
        } // 빨간거
        if (true)
        {
            if (ppl.PickUp1 == "orangecore")
                oranges += ppl.Amount1;
            if (ppl.PickUp2 == "orangecore")
                oranges += ppl.Amount2;
            if (ppl.PickUp3 == "orangecore")
                oranges += ppl.Amount3;
            if (ppl.PickUp4 == "orangecore")
                oranges += ppl.Amount4;
            if (ppl.PickUp5 == "orangecore")
                oranges += ppl.Amount5;
            if (ppl.PickUp6 == "orangecore")
                oranges += ppl.Amount6;
            if (ppl.PickUp7 == "orangecore")
                oranges += ppl.Amount7;
        } // 오랜지
        if (true)
        {
            if (ppl.PickUp1 == "puplecore")
                puples += ppl.Amount1;
            if (ppl.PickUp2 == "puplecore")
                puples += ppl.Amount2;
            if (ppl.PickUp3 == "puplecore")
                puples += ppl.Amount3;
            if (ppl.PickUp4 == "puplecore")
                puples += ppl.Amount4;
            if (ppl.PickUp5 == "puplecore")
                puples += ppl.Amount5;
            if (ppl.PickUp6 == "puplecore")
                puples += ppl.Amount6;
            if (ppl.PickUp7 == "puplecore")
                puples += ppl.Amount7;
        } // 보라색
        if (true)
        {
            if (ppl.PickUp1 == "corepiece")
                pieces += ppl.Amount1;
            if (ppl.PickUp2 == "corepiece")
                pieces += ppl.Amount2;
            if (ppl.PickUp3 == "corepiece")
                pieces += ppl.Amount3;
            if (ppl.PickUp4 == "corepiece")
                pieces += ppl.Amount4;
            if (ppl.PickUp5 == "corepiece")
                pieces += ppl.Amount5;
            if (ppl.PickUp6 == "corepiece")
                pieces += ppl.Amount6;
            if (ppl.PickUp7 == "corepiece")
                pieces += ppl.Amount7;
        } // 조각
    }
    void Resets()
    {
        Namus = 0;
        Gogis = 0;
        chulguis = 0;
        chulgocks = 0;
        pieces = 0;
        reds = 0;
        puples = 0;
        oranges = 0;
        JackMuls = 0;
        jackmulddangs = 0;
    }

    void Make(string name,int itemmax, int amount , int namu, int gogi, int jackmul, int jackmulddang, int chulgui, int orange, int red, int puple, int piece, int chulgocks)
    {
        if(!canMake(name, itemmax, amount))
        {
            Debug.Log("아이템을 놓을 공간이 없습니다.");
            return;
        }
        play_record_info.Item_Make_Record.AddRecorder(name, amount);
        removefromhand("namu", namu);
        removefromhand("gogi", gogi);
        removefromhand("jackMul", jackmul);
        removefromhand("jackMulddang", jackmulddang);
        removefromhand("chulgui", chulgui);
        removefromhand("orangecore", orange);
        removefromhand("redcore", red);
        removefromhand("puplecore", puple);
        removefromhand("corepiece", piece);
        removefromhand("chulGock", chulgocks);

        output(name, itemmax, amount);
    }

    void removefromhand(string name, int namu)
    {
        if (namu > 0)
        {
            AAA = 0;
            Makes = true;
            AAAs = false;
            if (ppl.PickUp1 == name && Makes)
            {
                if (ppl.Amount1 > AAA && AAA > 0)
                {
                    ppl.Amount1 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount1 > namu)
                {
                    ppl.Amount1 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount1;
                        ppl.Amount1 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount1)
                    {
                        ppl.Amount1 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount1;
                        ppl.Amount1 = 0;
                    }
                }
            }
            if (ppl.PickUp2 == name && Makes)
            {
                if (ppl.Amount2 > AAA && AAA > 0)
                {
                    ppl.Amount2 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount2 > namu)
                {
                    ppl.Amount2 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount2;
                        ppl.Amount2 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount2)
                    {
                        ppl.Amount2 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount2;
                        ppl.Amount2 = 0;
                    }
                }
            }
            if (ppl.PickUp3 == name && Makes)
            {
                if (ppl.Amount3 > AAA && AAA > 0)
                {
                    ppl.Amount3 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount3 > namu)
                {
                    ppl.Amount3 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount3;
                        ppl.Amount3 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount3)
                    {
                        ppl.Amount3 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount3;
                        ppl.Amount3 = 0;
                    }
                }
            }
            if (ppl.PickUp4 == name && Makes)
            {
                if (ppl.Amount4 > AAA && AAA > 0)
                {
                    ppl.Amount4 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount4 > namu)
                {
                    ppl.Amount4 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount4;
                        ppl.Amount4 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount4)
                    {
                        ppl.Amount4 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount4;
                        ppl.Amount4 = 0;
                    }
                }
            }
            if (ppl.PickUp5 == name && Makes)
            {
                if (ppl.Amount5 > AAA && AAA > 0)
                {
                    ppl.Amount5 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount5 > namu)
                {
                    ppl.Amount5 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount5;
                        ppl.Amount5 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount5)
                    {
                        ppl.Amount5 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount5;
                        ppl.Amount5 = 0;
                    }
                }
            }
            if (ppl.PickUp6 == name && Makes)
            {
                if (ppl.Amount6 > AAA && AAA > 0)
                {
                    ppl.Amount6 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount6 > namu)
                {
                    ppl.Amount6 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount6;
                        ppl.Amount6 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount6)
                    {
                        ppl.Amount6 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount6;
                        ppl.Amount6 = 0;
                    }
                }
            }
            if (ppl.PickUp7 == name && Makes)
            {
                if (ppl.Amount7 > AAA && AAA > 0)
                {
                    ppl.Amount7 -= AAA;
                    AAA = 0;
                    Makes = false;
                }
                else if (ppl.Amount7 > namu)
                {
                    ppl.Amount7 -= namu;
                    Makes = false;
                }
                else if (AAA == 0)
                {
                    if (!AAAs)
                    {
                        AAA = namu - ppl.Amount7;
                        ppl.Amount7 = 0;
                        AAAs = true;
                    }
                }
                else
                {
                    if (AAA < ppl.Amount7)
                    {
                        ppl.Amount7 -= AAA;
                        AAA = 0;
                        Makes = false;
                    }
                    else
                    {
                        AAA = AAA - ppl.Amount7;
                        ppl.Amount7 = 0;
                    }
                }
            }
        }
    }

    int canMake_names;
    bool canMake(string name, int max, int amount)
    {
        canMake_names = 0;
        if (ppl.PickUp1 == name || ppl.PickUp1 == "none")
        {
            canMake_names = max - ppl.Amount1;
        }
        if (ppl.PickUp2 == name || ppl.PickUp2 == "none")
        {
            canMake_names = max - ppl.Amount2;
        }
        if (ppl.PickUp3 == name || ppl.PickUp3 == "none")
        {
            canMake_names = max - ppl.Amount3;
        }
        if (ppl.PickUp4 == name || ppl.PickUp4 == "none")
        {
            canMake_names = max - ppl.Amount4;
        }
        if (ppl.PickUp5 == name || ppl.PickUp5 == "none")
        {
            canMake_names = max - ppl.Amount5;
        }
        if (ppl.PickUp6 == name || ppl.PickUp6 == "none")
        {
            canMake_names = max - ppl.Amount6;
        }
        if (ppl.PickUp7 == name || ppl.PickUp7 == "none")
        {
            canMake_names = max - ppl.Amount7;
        }

        if(canMake_names >= amount)
        {
            return true;
        }
        return false;
    }
    int outputaaa;
    void output(string name, int max, int amount)
    {
        outputaaa = amount;
        if (name != "chong")
        {
            if (ppl.PickUp1 == name)
            {
                if (ppl.Amount1 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount1;
                    ppl.Amount1 = max;
                }
                else
                {
                    ppl.Amount1 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp2 == name)
            {
                if (ppl.Amount2 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount2;
                    ppl.Amount2 = max;
                }
                else
                {
                    ppl.Amount2 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp3 == name)
            {
                if (ppl.Amount3 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount3;
                    ppl.Amount3 = max;
                }
                else
                {
                    ppl.Amount3 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp4 == name)
            {
                if (ppl.Amount4 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount4;
                    ppl.Amount4 = max;
                }
                else
                {
                    ppl.Amount4 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp5 == name)
            {
                if (ppl.Amount5 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount5;
                    ppl.Amount5 = max;
                }
                else
                {
                    ppl.Amount5 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp6 == name)
            {
                if (ppl.Amount6 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount6;
                    ppl.Amount6 = max;
                }
                else
                {
                    ppl.Amount6 += outputaaa;
                    outputaaa = 0;
                }
            }
            if (ppl.PickUp7 == name)
            {
                if (ppl.Amount7 + outputaaa > max)
                {
                    outputaaa -= max - ppl.Amount7;
                    ppl.Amount7 = max;
                }
                else
                {
                    ppl.Amount7 += outputaaa;
                    outputaaa = 0;
                }
            }
        }

        Debug.Log(outputaaa);
        if (outputaaa > 0)
        {
            Debug.Log("Dawd");
            if(ppl.PickUp1 == "none")
            {
                ppl.PickUp1 = name;
                ppl.Amount1 += outputaaa;
                return;
            }
            if (ppl.PickUp2 == "none")
            {
                ppl.PickUp2 = name;
                ppl.Amount2 += outputaaa;
                return;
            }
            if (ppl.PickUp3 == "none")
            {
                ppl.PickUp3 = name;
                ppl.Amount3 += outputaaa;
                return;
            }
            if (ppl.PickUp4 == "none")
            {
                ppl.PickUp4 = name;
                ppl.Amount4 += outputaaa;
                return;
            }
            if (ppl.PickUp5 == "none")
            {
                ppl.PickUp5 = name;
                ppl.Amount5 += outputaaa;
                return;
            }
            if (ppl.PickUp6 == "none")
            {
                ppl.PickUp6 = name;
                ppl.Amount6 += outputaaa;
                return;
            }
            if (ppl.PickUp7 == "none")
            {
                ppl.PickUp7 = name;
                ppl.Amount7 += outputaaa;
                return;
            }
        }
    }
}
