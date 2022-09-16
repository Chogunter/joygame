using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScreenMover : MonoBehaviour
{
    GameObject the_cam;
    public List<GameObject> chimdealist;
    public List<GameObject> chimdeacursorlist;
    Vector3 movepos;
    [SerializeField] float wheelspeed;
    [SerializeField] float h_Max;
    [SerializeField] float h_Min;
    [SerializeField] float v_Max;
    [SerializeField] float v_Min;
    int amountofcimdeains;
    [SerializeField] float cursor_h_Max;
    [SerializeField] float cursor_h_Min;
    [SerializeField] float cursor_v_Max;
    [SerializeField] float cursor_v_Min;
    [SerializeField] GameObject chimdeacursorsss;
    [SerializeField] GameObject gwanri;
    [SerializeField] float posy;
    float speedddddd = 30;
    float camposy = 50;
    void Start()
    {
        the_cam = GameObject.Find("Minimapcam");
        camposy = the_cam.transform.position.y;
    }

    void Update()
    {
        chimdealist = gwanri.GetComponent<respawnchimdealists>().chimdea;
        posy = 12 / (the_cam.transform.position.y / 50);
        wheelspeed = the_cam.transform.position.y / 10;

        float sss = Input.GetAxis("Mouse ScrollWheel") * speedddddd;
        camposy -= sss;
        speedddddd = camposy;
        the_cam.transform.position = new Vector3(the_cam.transform.position.x,
            Mathf.Clamp(camposy, 2, 6900), the_cam.transform.position.z);
        if (chimdealist.Count == 0)
        {
            gwanri.GetComponent<Respawnscript>().Nochimdea();
        }
        if (Input.GetMouseButton(2))
        {
            float h = wheelspeed * -Input.GetAxis("Mouse X");
            float v = wheelspeed * -Input.GetAxis("Mouse Y");
            //movepos += new Vector3(h, 0, v);

            movepos = new Vector3(Mathf.Clamp(h + movepos.x, h_Min, h_Max), the_cam.transform.position.y, Mathf.Clamp(v + movepos.z, v_Min, v_Max));
            the_cam.transform.position = movepos;
        }
        if (amountofcimdeains < chimdealist.Count)
        {
            chimdeacursorlist.Add(Instantiate(chimdeacursorsss));
            chimdeacursorlist[chimdeacursorlist.Count - 1].transform.parent = gameObject.transform;
            amountofcimdeains += 1;
        }
        else if(chimdealist.Count > 0)
        {
            for(int i = 0; i < chimdealist.Count; i++)
            {
                if(chimdealist[i] != null)
                    chimdeacursorlist[i].GetComponent<chimdeacursorbitton>().chimdea = chimdealist[i];
            }
            for (int i = 0; i < chimdealist.Count; i++)
            {
                if (chimdealist[i] != null)
                {
                    chimdeacursorlist[i].SetActive(true);
                    Vector3 pos = (chimdealist[i].transform.position - the_cam.transform.position) * posy;
                    pos = new Vector2(Mathf.Clamp(pos.x, cursor_h_Min, cursor_h_Max),
                        Mathf.Clamp(pos.z, cursor_v_Min, cursor_v_Max));
                    float rot = GetAngle(the_cam.transform.position, chimdealist[i].transform.position);
                    chimdeacursorlist[i].transform.localPosition = pos;
                    chimdeacursorlist[i].transform.rotation = Quaternion.Euler(0f, 0f, rot);
                }
                else
                    chimdeacursorlist[i].SetActive(false);
            }
            for(int i = amountofcimdeains; i > chimdealist.Count; i--)
            {
                chimdeacursorlist[i - 1].SetActive(false);
            }
        }
        
    }
    public float GetAngle(Vector3 from, Vector3 to)
    {
        Vector3 v = to - from;
        return Mathf.Atan2(v.z, v.x) * Mathf.Rad2Deg;
    }

}
