using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildingbreak : MonoBehaviour
{
    public int HP;
    public int or_Hp;
    GameObject Cursor;
    bool ssssss = true;
    Dig_Particles_cs DigParticleManager;
    Player_sound_effect AudioManeger;
    GameObject Player;
    void Awake()
    {
        Player = GameObject.Find("Player");
        DigParticleManager = GameObject.Find("dig_Particles").GetComponent<Dig_Particles_cs>();
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
        or_Hp = HP;
        Cursor = GameObject.Find("Cursor Item");
        if (this.gameObject.tag == "Sangja" && this.gameObject.GetComponent<SangJJasaveandload>().Isdontbreak)
            ssssss = false;
    }
    private void OnEnable()
    {
        for (int i = 0; i < Loading_Manager.NeedToBeCalled.Count; i++)
        {
            if (Loading_Manager.NeedToBeCalled[i] == gameObject)
            {
                Loading_Manager.NeedToBeCalled[i] = null;
                return;
            }
        }
        HP = or_Hp;
    }
    void Update()
    {
        if (HP <= 0 && ssssss)
        {
            if (this.GetComponent<chimdeaadd>())
            {
                this.GetComponent<chimdeaadd>().removelist();
            }
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 20)
        {
            //Debug.Log(Vector3.Distance(transform.position, Player.transform.position));
            AudioManeger.Sound("debris");
        }
        DigParticleManager.Particle(transform.position, "building_destroy");
    }
    public void originhit()
    {
        if (Cursor.GetComponent<ItemCursor>().Using_Item == "gum")
        {
            HP -= 10;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulgum")
        {
            HP -= 25;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "namuGock")
        {
            HP -= 44;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dollGock")
        {
            HP -= 80;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulnamuGock")
        {
            HP -= 50;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulGock")
        {
            HP -= 96;
        }
        else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dril")
        {
            HP -= 350;
        }
        else
        {
            HP -= 20;
        }
    }
}
