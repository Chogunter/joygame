using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnscript : MonoBehaviour
{
    [SerializeField] GameObject respawnimage;
    [SerializeField] GameObject dieimage;
    [SerializeField] GameObject Player;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnClick()
    {
        respawnimage.SetActive(true);
        dieimage.SetActive(false);
    }
    public void choosed(GameObject chimdea)
    {
        respawnimage.SetActive(false);
        Player.GetComponent<Player_Hp>().responepos = chimdea.transform.position + Vector3.up;
        Player.GetComponent<Player_Hp>().Respone();
    }
    public void Nochimdea()
    {
        respawnimage.SetActive(false);
        Player.GetComponent<Player_Hp>().responepos = Vector3.zero + Vector3.up * 2.57f;
        Player.GetComponent<Player_Hp>().Respone();
    }
}
