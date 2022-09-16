using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jwapyo : MonoBehaviour
{
    //public Camera PlayerCamera;
    public List<GameObject> jwapyodul;
    public List<Vector3> jwapyodulpos;
    public List<string> jwapyonames;
    public List<GameObject> jwapyopyosics;
    [SerializeField] float MaxDistance;
    RaycastHit hit;
    [SerializeField] GameObject jwapyotachiwww;
    [SerializeField] GameObject Nameenter;
    [SerializeField] GameObject JwapyoParent;
    [SerializeField] GameObject JwapyopyosicParent;
    [SerializeField] GameObject Jwapyopyosic;
    GameObject Player;
    [SerializeField] float gackdo;
    [SerializeField] float banhyan;
    [SerializeField] float xMin;
    [SerializeField] float xMax;

    public bool isusing = false;

    Camera cam;
    //[SerializeField] Text InputNameenter;
    void Start()
    {
        Player = transform.parent.gameObject;
        cam = Camera.main;
    }

    void Update()
    {
        if (isusing)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                isusing = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.P) && !Player.GetComponent<ESC>().dontP)
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
            {
                //isusing = true;
                //var that = Instantiate(jwapyotachiwww);
                //that.transform.SetParent(JwapyoParent.transform);
                ////that.transform.parent = JwapyoParent.transform;
                //jwapyodul.Add(that);
                //jwapyodulpos.Add(hit.point);
                //Nameenter.SetActive(true);
                //jwapyonames.Add("");
                //Nameenter.GetComponent<JwapyoName>().index = jwapyonames.Count - 1;
                //var thatpyosic = Instantiate(Jwapyopyosic, hit.point, Quaternion.identity);
                //thatpyosic.transform.parent = JwapyopyosicParent.transform;
                //jwapyopyosics.Add(thatpyosic);
                Addjwapyo(hit.point);
            }
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
            {
                Player.GetComponent<ESC>().JwapyoName = 0;
                for(int i = 0;i < jwapyodul.Count; i++)
                {
                    if(Vector3.Distance(new Vector3(jwapyodulpos[i].x, 0, jwapyodulpos[i].z),
                        new Vector3(hit.point.x, 0, hit.point.z)) < 1)
                    {
                        Removefromlist(i);
                    }
                }
            }
        }
        for (int i = 0; i< jwapyodul.Count; i++)
        {
            jwapyodul[i].GetComponent<jwapyotachi>().Naaame = jwapyonames[i];
            jwapyodul[i].GetComponent<jwapyotachi>().dis = (int)Vector3.Distance(jwapyodulpos[i],
                Player.transform.position);
        }
        for(int i = 0; i < jwapyodul.Count; i++)
        {
            float sass = Player.transform.rotation.eulerAngles.y;
            if (sass > 180)
            {
                sass = (360 - sass) * -1;
            }
            float ssssss = GetAngle(Player.transform.position, jwapyodulpos[i]) + sass;
            float bbbbbb = GetAngle(Player.transform.position, jwapyodulpos[i]);
            if (ssssss * bbbbbb < 0)
            {
                if (ssssss > 0 && ssssss > -180)
                {
                    ssssss = ssssss * -1 - 360;
                }
                //if (bbbbbb > 0 && bbbbbb > -90)
                //{
                //    bbbbbb = bbbbbb * -1 - 180;
                //}
            }
            Vector2 move =
                Vector2.up * 470 + Vector2.right * bbbbbb * gackdo
                + Vector2.right * ssssss * banhyan;
            //Debug.Log(ssssss.ToString() + " " + bbbbbb.ToString());
            Vector2 movepos = new Vector2(Mathf.Clamp(move.x, xMin, xMax), move.y);
            jwapyodul[i].transform.localPosition = movepos;
        }
    }

    void Addjwapyo(Vector3 point)
    {
        isusing = true;
        var that = Instantiate(jwapyotachiwww);
        that.transform.SetParent(JwapyoParent.transform);
        //that.transform.parent = JwapyoParent.transform;
        jwapyodul.Add(that);
        jwapyodulpos.Add(point);
        Nameenter.SetActive(true);
        jwapyonames.Add("");
        Nameenter.GetComponent<JwapyoName>().index = jwapyonames.Count - 1;
        var thatpyosic = Instantiate(Jwapyopyosic, point, Quaternion.identity);
        thatpyosic.transform.parent = JwapyopyosicParent.transform;
        jwapyopyosics.Add(thatpyosic);
    }

    public void Removefromlist(int index)
    {
        Destroy(jwapyodul[index]);
        Destroy(jwapyopyosics[index]);
        jwapyopyosics.RemoveAt(index);
        jwapyodul.RemoveAt(index);
        jwapyonames.RemoveAt(index);
        jwapyodulpos.RemoveAt(index);
    }
    public void NameSet(string name, int index)
    {
        jwapyonames[index] = name;
    }
    public static float GetAngle(Vector3 vStart, Vector3 vEnd)
    {
        Vector3 v = vEnd - vStart;

        return Mathf.Atan2(v.x, v.z) * Mathf.Rad2Deg;
    }
    public static float CalculateAngle(Vector3 from, Vector3 to)
    {
        return Quaternion.FromToRotation(Vector3.up, to - from).eulerAngles.z;
    }

    public void LoadJwapyo(Vector3 point, string name)
    {
        //isusing = true;
        var that = Instantiate(jwapyotachiwww);
        that.transform.SetParent(JwapyoParent.transform);
        //that.transform.parent = JwapyoParent.transform;
        jwapyodul.Add(that);
        jwapyodulpos.Add(point);
        //Nameenter.SetActive(true);
        //jwapyonames.Add("");
        //Nameenter.GetComponent<JwapyoName>().index = jwapyonames.Count - 1;
        var thatpyosic = Instantiate(Jwapyopyosic, point, Quaternion.identity);
        thatpyosic.transform.parent = JwapyopyosicParent.transform;
        jwapyopyosics.Add(thatpyosic);

        jwapyonames.Add(name);
    }
}
