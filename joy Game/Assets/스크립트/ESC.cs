using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ESC : MonoBehaviour
{
    public GameObject Esc;
    public int sss = 0;
    public int InputFieldsss = 0;
    public int Inven = 0;
    public int asaa = 0;

    public Text text;

    public bool IsInputFieldUsing;

    public GameObject InputField;

    public bool NoorYes;

    public int anyint;
    public bool anybool;
    public int theanyintthing;

    public GameObject plussign1;
    public GameObject plussign2;

    public int Diechang;
    public int JwapyoName;
    public bool dontP;

    GameObject Enpty;

    public GameObject DoguChang;

    public GameObject SaveUI;
    public int saveUiint;

    void Start()
    {
        Enpty = GameObject.Find("Enpty");
    }

    void Update()
    {
        if (JwapyoName % 2 == 1)
        {
            this.GetComponent<DoguItemChang>().aAaAaA = 0;
        }

        if(saveUiint % 2 == 1 && asaa % 2 == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                asaa = 0;
            }
            SaveUI.SetActive(true);
        }
        else
        {
            saveUiint = 0;
            SaveUI.SetActive(false);
        }
        if (sss % 2 == 1 || this.GetComponent<DoguItemChang>().aAaAaA % 2 == 1 || asaa % 2 == 1 || InputFieldsss % 2 == 1 || anyint % 2 == 1 || Diechang % 2 == 1 || Inven % 2 == 1 || saveUiint % 2 == 1)
        {
            JwapyoName = 0;
            dontP = true;
        }
        else
        {
            dontP = false;
        }

        if (sss % 2 == 1 || this.GetComponent<DoguItemChang>().aAaAaA % 2 == 1 || asaa % 2 == 1 || InputFieldsss % 2 == 1 || anyint % 2 == 1 || Diechang % 2 == 1 || Inven % 2 == 1 || JwapyoName % 2 == 1 || saveUiint % 2 == 1)
        {
            canGetKey.IsESCturnedon = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            this.GetComponent<PlayerMover>().DoguUsing = true;
            GameObject.Find("Enpty").GetComponent<CameraMover>().DoGuUSING = true;
            NoorYes = false;
            if (JwapyoName % 2 == 1)
            {
                this.GetComponent<DoguItemChang>().aAaAaA = 0;
            }
            //this.transform.rotation = this.transform.rotation;
            plussign1.SetActive(false);
            plussign2.SetActive(false);
        }
        else
        {
            canGetKey.IsESCturnedon = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            this.GetComponent<PlayerMover>().DoguUsing = false;
            GameObject.Find("Enpty").GetComponent<CameraMover>().DoGuUSING = false;
            NoorYes = true;
            plussign1.SetActive(true);
            plussign2.SetActive(true);
        }
        if (Enpty.GetComponent<jwapyo>().isusing)
        {
            return;
        }
        //////////////// 제작대나 그런것들
        if (sss % 2 == 1 || this.GetComponent<DoguItemChang>().aAaAaA % 2 == 1 || asaa % 2 == 1 || InputFieldsss % 2 == 1)
        {
            anybool = false;
            anyint = 0;
        }
        else
        {
            anybool = true;
        }
        ///////////////
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sss += 1;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!InputField.GetComponent<InputField>().isFocused)
            {
                InputFieldsss += 1;
            }
        }
        if (InputFieldsss % 2 == 1)
        {
            if (JwapyoName % 2 == 1)
            {
                InputFieldsss = 0;
            }
            else
            {
                if (sss % 2 == 1)
                {
                    InputField.SetActive(false);
                }
                else
                {
                    IsInputFieldUsing = true;
                    //Cursor.visible = true;
                    //GameObject.Find("Player").GetComponent<PlayerMover>().DoguUsing = true;
                    //GameObject.Find("Enpty").GetComponent<CameraMover>().DoGuUSING = true;

                    InputField.SetActive(true);
                }
            }
        }
        else
        {
            InputField.SetActive(false);
            IsInputFieldUsing = false;
        }
        if(this.GetComponent<DoguItemChang>().aAaAaA % 2 == 0)
        {
            DoguChang.SetActive(false);
        }
        else
        {
            DoguChang.SetActive(true);
        }

        if (sss % 2 == 1)
        {
            this.GetComponent<DoguItemChang>().aAaAaA = 0;
            //Cursor.visible = true;
            //GameObject.Find("Player").GetComponent<PlayerMover>().DoguUsing = true;
            //GameObject.Find("Enpty").GetComponent<CameraMover>().DoGuUSING = true;
            if (asaa % 2 == 1)
            {
                Esc.SetActive(false);
            }
            else
            {
                Esc.SetActive(true);
            }
        }
        else
        {
            if(this.GetComponent<DoguItemChang>().aAaAaA % 2 == 0)
            {
                //Cursor.visible = false;
                //GameObject.Find("Player").GetComponent<PlayerMover>().DoguUsing = false;
                //GameObject.Find("Enpty").GetComponent<CameraMover>().DoGuUSING = false;
            }
            Esc.SetActive(false);
        }

        //if (GameObject.Find("Player").GetComponent<DoguItemChang>().aAaAaA % 2 == 1)
        //{
        //    Cursor.visible = true;
        //}
        //else
        //{
        //    if(sss % 2 == 0)
        //    {
        //        Cursor.visible = false;
        //    }
        //}
    }
}
