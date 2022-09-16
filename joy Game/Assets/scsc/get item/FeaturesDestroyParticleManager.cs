using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesDestroyParticleManager : MonoBehaviour
{
    [SerializeField] string particle;
    [SerializeField] Vector3 articlelocalpos;
    GameObjectPool gamepool;
    Player_sound_effect AudioManeger;

    private void Awake()
    {
        gamepool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        AudioManeger = GameObject.Find("Player_sound").GetComponent<Player_sound_effect>();
    }

    private void OnDisable()
    {
        if (Loading_Manager.isExit == true) return;
        AudioManeger.Sound("debris");
        gamepool.Instantiates(particle, articlelocalpos + transform.position, Quaternion.identity);
    }
}
