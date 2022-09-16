using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_make_info_reset : MonoBehaviour
{
    [System.Serializable]
    public class MakerItema
    {
        public string sort_name; // ToiBi JeaJackDea  HabSungGi  Advenced  Dogu

        public Item_make_info.MakerItem Makera;
    }
    [SerializeField] List<MakerItema> MakerItems = new List<MakerItema>();

    public List<Item_make_info.MakerItem> UpdatedMakers = new List<Item_make_info.MakerItem>();

    private void Awake()
    {
        foreach(MakerItema a in MakerItems)
        {
            AddMakers(a.sort_name, a.Makera.itemname, a.Makera.amount, a.Makera.materials);
        }
    }

    private void Start()
    {
        UpdatedMakers = Item_make_info.Makers;
    }

    void AddMakers(string sort, string name, int amount, List<Item_make_info.item> items)
    {
        Item_make_info.MakerItem that = new Item_make_info.MakerItem();

        that.itemname = name;
        that.amount = amount;
        
        for(int i = 0; i < items.Count; i++)
        {
            Item_make_info.item ab = new Item_make_info.item();
            ab.amount = items[i].amount;
            ab.name = items[i].name;

            that.materials.Add(ab);
        }

        if (sort == "Dogu")
        {
            Item_make_info.Dogu.Makers.Add(that);
        }
        else if (sort == "ToiBi")
        {
            Item_make_info.ToiBi.Makers.Add(that);
        }
        else if (sort == "JeaJackDea")
        {
            Item_make_info.JeaJackDea.Makers.Add(that);
        }
        else if (sort == "HabSungGi")
        {
            Item_make_info.HabSungGi.Makers.Add(that);
        }
        else if (sort == "Advenced")
        {
            Item_make_info.Advenced.Makers.Add(that);
        }

        Item_make_info.Makers.Add(that);
    }
}
