using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_Manager : MonoBehaviour
{
    [SerializeField]
    List<MonoBehaviour> normalcs = new List<MonoBehaviour>();
    Rigidbody rb;
    bool islimited = true;
    Vector3 latepos;
    public bool limitmoving = true;
    [SerializeField] List<MonoBehaviour> Excepts = new List<MonoBehaviour>();

    void Start()
    {
        if (limitmoving)
        {
            MonoBehaviour[] mosadasd = gameObject.GetComponents<MonoBehaviour>();

            foreach (MonoBehaviour thatcs in mosadasd)
            {
                if (thatcs != this && thatcs.enabled && !Excepts.Contains(thatcs))
                {
                    normalcs.Add(thatcs);
                }
            }

            if (gameObject.GetComponent<Rigidbody>() && !gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                rb = gameObject.GetComponent<Rigidbody>();
            }
            latepos = transform.position;

            if (!Loading_Manager.isLoaded)
            {
                CloseComponent();
            }
        }
    }

    private void Update()
    {
        if (limitmoving && islimited)
        {
            transform.position = latepos;
            latepos = transform.position;
        }
        if(limitmoving && Loading_Manager.isLoaded)
        {
            OpenComponent();
        }
    }

    public void CloseComponent()
    {
        //Loading_Manager.OKDIA that = new Loading_Manager.OKDIA();
        //that.gameobject = gameObject;
        //that.called = false;
        //Loading_Manager.needToCalled.Add(that);
        Loading_Manager.NeedToBeCalled.Add(gameObject);

        foreach(MonoBehaviour thatcs in normalcs)
        {
            thatcs.enabled = false;
        }
        if (rb)
        {
            rb.isKinematic = true;
        }
        islimited = true;
    }
    public void OpenComponent()
    {
        foreach (MonoBehaviour thatcs in normalcs)
        {
            thatcs.enabled = true;
        }
        if (rb)
        {
            rb.isKinematic = false;
        }
        islimited = false;
    }
}
