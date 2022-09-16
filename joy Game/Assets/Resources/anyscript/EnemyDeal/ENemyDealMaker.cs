using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENemyDealMaker : MonoBehaviour
{
    EnemyDealChoose chooser;
    bool Makes;
    bool AAAs;
    int AAA;
    PlayerHand ppl;
    [SerializeField] itemslotscript DealMakes;
    public Enemymove DealEnemy;
    GameObject Player;

    private void Start()
    {
        chooser = GetComponent<EnemyDealChoose>();
        Player = GameObject.Find("Player");
        ppl = Player.GetComponent<PlayerHand>();
    }


    public void Make()
    {
        Item_make_info.MakerItem that = chooser.GetDealItem(DealMakes.a);

        if (canMake(that.itemname, chooser.GetMax(that.itemname), that.amount) || that.itemname == "employ")
        {
            foreach (Item_make_info.item a in that.materials)
            {
                if (check(a.name) < a.amount)
                {
                    return;
                }
            }
            //통과 == 갯수 충족
            foreach (Item_make_info.item a in that.materials)
            {
                removefromhand(a.name, a.amount);
            }
            if(that.itemname == "employ")
            {
                DealEnemy.isPlayerTeam = true;
                Player.GetComponent<ESC>().anyint += 1;
                return;
            }
            output(that.itemname, chooser.GetMax(that.itemname), that.amount);
        }
    }

    int nya = 0;
    int check(string name)
    {
        nya = 0;
        if (ppl.PickUp1 == name)
            nya += ppl.Amount1;
        if (ppl.PickUp2 == name)
            nya += ppl.Amount2;
        if (ppl.PickUp3 == name)
            nya += ppl.Amount3;
        if (ppl.PickUp4 == name)
            nya += ppl.Amount4;
        if (ppl.PickUp5 == name)
            nya += ppl.Amount5;
        if (ppl.PickUp6 == name)
            nya += ppl.Amount6;
        if (ppl.PickUp7 == name)
            nya += ppl.Amount7;
        return nya;
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

        if (canMake_names >= amount)
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
            if (ppl.PickUp1 == "none")
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
