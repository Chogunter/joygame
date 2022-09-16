using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personmodelmanager : MonoBehaviour
{
    [SerializeField] Material body_color;
    [SerializeField] Material eye_color;

    [System.Serializable]
    public class bodypart
    {
        public string name;
        public Transform part;
    }

    [SerializeField] List<bodypart> bodys = new List<bodypart>();
    [SerializeField] List<Vector3> bodypos = new List<Vector3>();
    [SerializeField] List<Quaternion> bodyrot = new List<Quaternion>();
    [SerializeField] List<Renderer> bodycolorpart = new List<Renderer>();
    [SerializeField] List<Renderer> eyecolorpart = new List<Renderer>();

    Animator animator;

    [Header("파라미터들")]
    public bool isStoped;
    public bool isRunning;
    public bool isAttack;
    public bool isAming;
    public bool isDie;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        for(int i = 0; i < bodys.Count; i++)
        {
            bodypos.Add(bodys[i].part.localPosition);
            bodyrot.Add(bodys[i].part.localRotation);
        }
    }

    public void RestBodys()
    {
        for (int i = 0; i < bodypos.Count; i++)
        {
            bodys[i].part.localPosition = bodypos[i];
            bodys[i].part.localRotation = bodyrot[i];
        }
        transform.localEulerAngles = Vector3.zero;
        transform.localPosition = Vector3.zero;
    }

    private void OnDisable()
    {
        RestBodys();
    }

    private void OnEnable()
    {
        RestBodys(); 
        //animator.Rebind();
        //animator.Play("Person_animation", -1, 0f);

        isStoped = true;
        isRunning = false;
        isAttack = false;
        isAming = false;
        isDie = false;
        if (body_color != null)
        {
            for (int i = 0; i < bodycolorpart.Count; i++)
            {
                bodycolorpart[i].material = body_color;
            }
        }

        if (eye_color != null)
        {
            for (int i = 0; i < eyecolorpart.Count; i++)
            {
                eyecolorpart[i].material = eye_color;
            }
        }
    }
    void Update()
    {
        if (isDie)
        {
            isStoped = true;
            isRunning = false;
            isAttack = false;
            isAming = false;
            animator.SetBool("die", true);
        }
        animator.SetBool("Stoped", isStoped);
        animator.SetBool("Running", isRunning);
        animator.SetBool("attack", isAttack);
        animator.SetBool("aming", isAming);
    }
}
