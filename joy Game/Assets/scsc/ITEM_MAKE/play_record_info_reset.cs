using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_record_info_reset : MonoBehaviour
{
    PlayerHand hand;
    Invenmaniger inven;

    private void Awake()
    {
        hand = GameObject.Find("Player").GetComponent<PlayerHand>();
        inven = GameObject.Find("Inventory").GetComponent<Invenmaniger>();
    }

    private void Start()
    {
        StartCoroutine(ScanGetItems());
    }

    IEnumerator ScanGetItems()
    {
        yield return new WaitForSeconds(2f);
        List<int> amounts = new List<int>();
        List<string> items = new List<string>();

        items.Add(hand.PickUp1);
        items.Add(hand.PickUp2);
        items.Add(hand.PickUp3);
        items.Add(hand.PickUp4);
        items.Add(hand.PickUp5);
        items.Add(hand.PickUp6);
        items.Add(hand.PickUp7);
        items.Add(hand.PickUpF);
        amounts.Add(hand.Amount1);
        amounts.Add(hand.Amount2);
        amounts.Add(hand.Amount3);
        amounts.Add(hand.Amount4);
        amounts.Add(hand.Amount5);
        amounts.Add(hand.Amount6);
        amounts.Add(hand.Amount7);
        amounts.Add(hand.AmountF);

        for(int i = 0; i < inven.items.Length; i++)
        {
            items.Add(inven.items[i]);
        }
        for (int i = 0; i < inven.nums.Length; i++)
        {
            amounts.Add(inven.nums[i]);
        }

        for(int i = 0; i < items.Count; i++)
        {
            play_record_info.GetItemRecord.SetRecorder(items[i]);
        }

        StartCoroutine(ScanGetItems());
    }
}
