using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chonglitem : MonoBehaviour
{
    PlayerHand Player_Hand;
    public int Hp;
    [SerializeField] int or_Hp = 1;
    public int ItemAmount;
    // Start is called before the first frame update
    void Awake()
    {
        Player_Hand = GameObject.Find("Player").GetComponent<PlayerHand>();
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
        Hp = or_Hp;
    }

    //private void Update()
    //{
    //    if(Hp <= 0)
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}

    // Update is called once per frame
    public void GetItem()
    {
        if (or_Hp > 0)
        {
            if (Player_Hand.PickUp1 == "none")
            {
                Player_Hand.PickUp1 = "chong";

                Hp = 0;
                Player_Hand.Amount1 = ItemAmount;
                gameObject.SetActive(false);

            }
            else if (Player_Hand.PickUp2 == "none")
            {
                Player_Hand.PickUp2 = "chong";

                Hp = 0;
                Player_Hand.Amount2 = ItemAmount;
                gameObject.SetActive(false);
            }
            else if (Player_Hand.PickUp3 == "none")
            {
                Player_Hand.PickUp3 = "chong";

                Hp = 0;
                Player_Hand.Amount3 = ItemAmount;
                gameObject.SetActive(false);
            }
            else if (Player_Hand.PickUp4 == "none")
            {
                Player_Hand.PickUp4 = "chong";

                Hp = 0;
                Player_Hand.Amount4 = ItemAmount;
                gameObject.SetActive(false);
            }
            else if (Player_Hand.PickUp5 == "none")
            {
                Player_Hand.PickUp5 = "chong";

                Hp = 0;
                Player_Hand.Amount5 = ItemAmount;
                gameObject.SetActive(false);
            }
            else if (Player_Hand.PickUp6 == "none")
            {
                Player_Hand.PickUp6 = "chong";

                Hp = 0;
                Player_Hand.Amount6 = ItemAmount;
                gameObject.SetActive(false);
            }
            else if (Player_Hand.PickUp7 == "none")
            {
                Player_Hand.PickUp7 = "chong";

                Hp = 0;
                Player_Hand.Amount7 = ItemAmount;
                gameObject.SetActive(false);
            }
        }
    }
}
