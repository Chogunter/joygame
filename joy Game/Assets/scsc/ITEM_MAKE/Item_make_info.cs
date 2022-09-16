using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Item_make_info
{
    [System.Serializable]
    public class item
    {
        public string name;
        public int amount;
    }
    [System.Serializable]
    public class MakerItem
    {
        public string itemname;
        public int amount;
        public List<item> materials = new List<item>();
    }
    public static List<MakerItem> Makers = new List<MakerItem>();

    public static class ToiBi
    {
        public static List<MakerItem> Makers = new List<MakerItem>();

        public static MakerItem Contatin(string item_name)
        {
            foreach(MakerItem a in Makers)
            {
                if(a.itemname == item_name)
                {
                    return a;
                }
            }
            return null;
        }
    }
    public static class JeaJackDea
    {
        public static List<MakerItem> Makers = new List<MakerItem>();
        public static MakerItem Contatin(string item_name)
        {
            foreach (MakerItem a in Makers)
            {
                if (a.itemname == item_name)
                {
                    return a;
                }
            }
            return null;
        }
    }
    public static class HabSungGi
    {
        public static List<MakerItem> Makers = new List<MakerItem>();
        public static MakerItem Contatin(string item_name)
        {
            foreach (MakerItem a in Makers)
            {
                if (a.itemname == item_name)
                {
                    return a;
                }
            }
            return null;
        }
    }
    public static class Advenced
    {
        public static List<MakerItem> Makers = new List<MakerItem>();
        public static MakerItem Contatin(string item_name)
        {
            foreach (MakerItem a in Makers)
            {
                if (a.itemname == item_name)
                {
                    return a;
                }
            }
            return null;
        }
    }
    public static class Dogu
    {
        public static List<MakerItem> Makers = new List<MakerItem>();
        public static MakerItem Contatin(string item_name)
        {
            foreach (MakerItem a in Makers)
            {
                if (a.itemname == item_name)
                {
                    return a;
                }
            }
            return null;
        }
    }

    public static item Searchfor(string name, List<item> material)
    {
        foreach(item a in material)
        {
            if(a.name == name)
            {
                return a;
            }
        }
        Debug.Log($"{name} 은/는 발견되지 않았습니다."); 
        foreach (item a in material)
        {
            Debug.Log(a.name.ToString() + " " + a.amount.ToString());
        }

        item nullitem = new item();

        return nullitem;
    }

    public static void FreeItems()
    {
        for(int i = 0; i < Makers.Count; i++)
        {
            Makers[i].materials = new List<item>();
        }
    }

}
