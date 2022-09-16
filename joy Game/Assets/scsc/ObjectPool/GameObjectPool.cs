using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameObjectPool : MonoBehaviour
{
    [Serializable]
    class ObjectNameAndPrefab
    {
        public string ItemName;
        public GameObject ItemPrefab;
    }
    [SerializeField] List<ObjectNameAndPrefab> ObjectName = new List<ObjectNameAndPrefab>(); 

    [Serializable]
    public class Objects
    {
        public string name;
        public List<GameObject> ObjectItem = new List<GameObject>();
    }

    public List<Objects> Object = new List<Objects>();

    void Start()
    {

    }
    void Update()
    {
        
    }

    GameObject aaa;
    public void Instantiates(string Item, Vector3 pos, Quaternion rot)
    {
        aaa = null;
        foreach(Objects ob in Object)
        {
            if(ob.name == Item) //오브젝트가 생성된적이 있음
            {
                foreach(GameObject a in ob.ObjectItem)
                {
                    if (!a.activeSelf) //사용가능한 오브젝트 있음
                    {
                        if (a.GetComponent<Rigidbody>())
                        {
                            a.GetComponent<Rigidbody>().velocity = Vector3.zero;
                        }
                        a.transform.position = pos;
                        a.transform.rotation = rot;
                        a.SetActive(true);
                        return;
                    }
                }
                //사용가능한 오브젝트가 없음
                foreach(ObjectNameAndPrefab aaaaa in ObjectName)
                {
                    if(aaaaa.ItemName == Item)
                    {
                        aaa = aaaaa.ItemPrefab;
                    }
                }
                if (aaa == null)
                {
                    Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
                    return;
                }
                var that = Instantiate(aaa, pos, rot);
                that.name = Item;
                that.transform.parent = transform;
                ob.ObjectItem.Add(that);
                return;
            }
        }
        //오브젝트가 생성된 적이 없음
        foreach (ObjectNameAndPrefab aaaaa in ObjectName)
        {
            if (aaaaa.ItemName == Item)
            {
                aaa = aaaaa.ItemPrefab;
            }
        }
        if(aaa == null)
        {
            Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
            return;
        }
        var thats = Instantiate(aaa, pos, rot);
        thats.name = Item;
        thats.transform.SetParent(transform);
        Objects ab = new Objects()
        {
            name = Item
        };
        ab.ObjectItem.Add(thats);
        Object.Add(ab);
        return;
    }

    public GameObject InstantiatesObject(string Item, Vector3 pos, Quaternion rot)
    {
        aaa = null;
        foreach (Objects ob in Object)
        {
            if (ob.name == Item) //오브젝트가 생성된적이 있음
            {
                foreach (GameObject a in ob.ObjectItem)
                {
                    if (!a.activeSelf) //사용가능한 오브젝트 있음
                    {
                        if (a.GetComponent<Rigidbody>())
                        {
                            a.GetComponent<Rigidbody>().velocity = Vector3.zero;
                        }
                        a.transform.position = pos;
                        a.transform.rotation = rot;
                        a.SetActive(true);
                        return a;
                    }
                }
                //사용가능한 오브젝트가 없음
                foreach (ObjectNameAndPrefab aaaaa in ObjectName)
                {
                    if (aaaaa.ItemName == Item)
                    {
                        aaa = aaaaa.ItemPrefab;
                    }
                }
                if (aaa == null)
                {
                    Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
                    return null;
                }
                var that = Instantiate(aaa, pos, rot);
                that.name = Item;
                that.transform.parent = transform;
                ob.ObjectItem.Add(that);
                return that;
            }
        }
        //오브젝트가 생성된 적이 없음
        foreach (ObjectNameAndPrefab aaaaa in ObjectName)
        {
            if (aaaaa.ItemName == Item)
            {
                aaa = aaaaa.ItemPrefab;
            }
        }
        if (aaa == null)
        {
            Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
            return null;
        }
        var thats = Instantiate(aaa, pos, rot);
        thats.name = Item;
        thats.transform.SetParent(transform);
        Objects ab = new Objects()
        {
            name = Item
        };
        ab.ObjectItem.Add(thats);
        Object.Add(ab);
        return thats;
    }

    public void AddGameObjectInPool(string Item, GameObject ObjectgameObject)
    {
        aaa = null;
        foreach (Objects ob in Object)
        {
            if (ob.name == Item) //오브젝트가 생성된적이 있음
            {
                ObjectgameObject.name = Item;
                ObjectgameObject.transform.parent = transform;
                ob.ObjectItem.Add(ObjectgameObject);
                return;
            }
        }
        //오브젝트가 생성된 적이 없음
        ObjectgameObject.name = Item;
        ObjectgameObject.transform.SetParent(transform);
        Objects ab = new Objects()
        {
            name = Item
        };
        ab.ObjectItem.Add(ObjectgameObject);
        Object.Add(ab);
        return;
    }

    public void MustInstitate(string Item, Vector3 pos, Quaternion rot)
    {
        aaa = null;
        foreach (Objects ob in Object)
        {
            if (ob.name == Item) //오브젝트가 생성된적이 있음
            {
                //사용가능한 오브젝트가 없음
                foreach (ObjectNameAndPrefab aaaaa in ObjectName)
                {
                    if (aaaaa.ItemName == Item)
                    {
                        aaa = aaaaa.ItemPrefab;
                    }
                }
                if (aaa == null)
                {
                    Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
                    return;
                }
                var that = Instantiate(aaa, pos, rot);
                that.name = Item;
                that.transform.parent = transform;
                ob.ObjectItem.Add(that);
                return;
            }
        }
        //오브젝트가 생성된 적이 없음
        foreach (ObjectNameAndPrefab aaaaa in ObjectName)
        {
            if (aaaaa.ItemName == Item)
            {
                aaa = aaaaa.ItemPrefab;
            }
        }
        if (aaa == null)
        {
            Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
            return;
        }
        var thats = Instantiate(aaa, pos, rot);
        thats.name = Item;
        thats.transform.SetParent(transform);
        Objects ab = new Objects()
        {
            name = Item
        };
        ab.ObjectItem.Add(thats);
        Object.Add(ab);
        return;
    }
    public GameObject MustInstitateObject(string Item, Vector3 pos, Quaternion rot)
    {
        aaa = null;
        foreach (Objects ob in Object)
        {
            if (ob.name == Item) //오브젝트가 생성된적이 있음
            {
                foreach (ObjectNameAndPrefab aaaaa in ObjectName)
                {
                    if (aaaaa.ItemName == Item)
                    {
                        aaa = aaaaa.ItemPrefab;
                    }
                }
                if (aaa == null)
                {
                    Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
                    return null;
                }
                var that = Instantiate(aaa, pos, rot);
                that.name = Item;
                that.transform.parent = transform;
                ob.ObjectItem.Add(that);
                return that;
            }
        }
        //오브젝트가 생성된 적이 없음
        foreach (ObjectNameAndPrefab aaaaa in ObjectName)
        {
            if (aaaaa.ItemName == Item)
            {
                aaa = aaaaa.ItemPrefab;
            }
        }
        if (aaa == null)
        {
            Debug.Log("ObjectName 리스트에는 " + Item + " (이)라는 항목이 없습니다.");
            return null;
        }
        var thats = Instantiate(aaa, pos, rot);
        thats.name = Item;
        thats.transform.SetParent(transform);
        Objects ab = new Objects()
        {
            name = Item
        };
        ab.ObjectItem.Add(thats);
        Object.Add(ab);
        return thats;
    }
}
