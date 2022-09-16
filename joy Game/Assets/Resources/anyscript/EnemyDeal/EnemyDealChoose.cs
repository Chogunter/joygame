using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealChoose : MonoBehaviour
{
    public List<Item_make_info.MakerItem> MakeItemList = new List<Item_make_info.MakerItem>();
    [SerializeField] itemslotscript DealItem;
    [SerializeField] List<itemslotscript> Materialslots = new List<itemslotscript>();
    [SerializeField] ENemyDealMaker Maker;

    [System.Serializable]
    public class DealItemButton
    {
        public string DealItemName;
        public GameObject ItemDealButton;
        public bool ExistInList;
        public int Max;
    }

    [SerializeField] List<DealItemButton> ItemDealButtons = new List<DealItemButton>();
    [SerializeField] Vector2 ButtonListStandardPos;
    [SerializeField] float ButtonListInterval;

    public int GetMax(string name)
    {
        foreach(DealItemButton a in ItemDealButtons)
        {
            if (a.DealItemName == name)
            {
                return a.Max;
            }
        }
        Debug.Log($"{name} 아이템은 무엇임니까? ㅇㅅㅇ;;");
        return 1;
    }

    public void ResetDealItem(List<Item_make_info.MakerItem> DealItems, Enemymove enemy)
    {
        MakeItemList = DealItems;
        Maker.DealEnemy = enemy;

        DealItem.a = "none";
        DealItem.amount = 0;
        for (int i = 0; i < 3; i++)
        {
            Materialslots[i].a = "none";
            Materialslots[i].amount = 0;
        }

        for (int j = 0; j < ItemDealButtons.Count; j++)
        {
            ItemDealButtons[j].ExistInList = false;
        }

        for (int i = 0; i < MakeItemList.Count; i++)
        {
            for (int j = 0; j < ItemDealButtons.Count; j++)
            {
                if (ItemDealButtons[j].DealItemName == MakeItemList[i].itemname)
                {
                    ItemDealButtons[j].ExistInList = true;
                }
            }
        }
        a = 0;
        for (int j = 0; j < ItemDealButtons.Count; j++)
        {
            if (!ItemDealButtons[j].ExistInList)
            {
                ItemDealButtons[j].ItemDealButton.SetActive(false);
                continue;
            }

            a++;
            ItemDealButtons[j].ItemDealButton.SetActive(true);
            ItemDealButtons[j].ItemDealButton.transform.localPosition = ButtonListStandardPos + Vector2.right * ButtonListInterval * a;

        }

    }
    int a;

    public void chooseDealItem(string name)
    {
        Item_make_info.MakerItem Itema = GetDealItem(name);

        if(Itema.itemname != "none")
        {
            DealItem.a = Itema.itemname;
            DealItem.amount = Itema.amount;
        }
        else
        {
            Debug.Log($"{name} 거래 항목은 존재하지 않거나 거래 가능 조건에 맞지 않습니다.");
            DealItem.a = "none";
            DealItem.amount = 0;
            for (int i = 0; i < 3; i++)
            {
                Materialslots[i].a = "none";
                Materialslots[i].amount = 0;
            }
            return;
        }

        if(Itema.materials.Count > 3)
        {
            Debug.Log($"{name} 아이템을 위한 재료의 크기가 한도를 넘었습니다.");
            DealItem.a = "none";
            DealItem.amount = 0;
            for (int i = 0; i < 3; i++)
            {
                Materialslots[i].a = "none";
                Materialslots[i].amount = 0;
            }
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            if(i > Itema.materials.Count - 1)
            {
                Materialslots[i].a = "none";
                Materialslots[i].amount = 0;
                continue;
            }
            Materialslots[i].a = Itema.materials[i].name;
            Materialslots[i].amount = Itema.materials[i].amount;
        }

    }
    public Item_make_info.MakerItem GetDealItem(string name)
    {
        foreach(Item_make_info.MakerItem a in MakeItemList)
        {
            if(a.itemname == name)
            {
                return a;
            }
        }
        Debug.Log($"{name} 이라는 아이템을 찾을 수 없습니다.");
        return new Item_make_info.MakerItem();
    }
}
