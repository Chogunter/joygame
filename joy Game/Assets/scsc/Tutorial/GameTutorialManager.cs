using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTutorialManager : MonoBehaviour
{
    public static bool TutorialOn;

    /*
     * 
     이동 WASD 
     카메라회전 마우스 
     나무캐기 우클릭
     동물 팁
     동물죽이기 좌클릭
     작업대 열기 E
     제작하기 화살표클릭
     돌 캐기 곡괭이로 우클릭
     채팅창 T
     청사진제작 작업대열고 청사진만들기
     건물짓기 청사진열고 B키
     건물제작 M키
     파밍하기 구조물찾고 상자열기
     적들 팁 x
     마을 팁
     좌표찾기지정 P
     좌표찾기삭제 좌표지점보고 Delete
     제작대만들기 
     괴물팁 x
     mk2청사진만들기 제작대열고 청사진
     mk2청사진으로 건물제작 팁 x
     차량 팁 x
     바다 건너는 방법들 팁 x
     바다 넘어의 사원 팁 
     코어 사용법
     코어조각 만들기 빨간코어 좌클릭으로 두들기기
     */
    //농사 - mk2청사진열고 퇴비통 건설 -> 퇴비통에서 경작지 제작 -> 청사진으로 경작지 건설
    //철괴 생산 - mk2청사진열고 용광로 건설 -> 철원석,나무로 철괴 생산
    //코어 합성 - 사원가기 -> 빨간코어구해오기 -> mk2청사진열고 코어합성기 건설 -> 코어합성

    [System.Serializable]
    public class Tutorial
    {
        [System.Serializable]
        public class TutorialSet
        {
            [System.Serializable]
            public class Texturestamp
            {
                public int ordernum;
                public Texture images;
            }
            public string str;
            public List<Texturestamp> stamps = new List<Texturestamp>();
        }
        public string name;

        public int priority;

        public List<TutorialSet> tutorial = new List<TutorialSet>();
        public float tutorialSetpasstime;

        public float tutorialpasstime;

        public string showingSetting;

        public bool again = false;

        [Header("------")]
        public bool isshowing;

        public float tutorialpasstimelate;
        public float tutorialSetpasstimelate;

        public int playing_index = 0;
        public bool Setisplayed = false;

        public void Exit()
        {
            playing_index = 0;
            Setisplayed = false;
            tutorialpasstimelate = 0;
            tutorialSetpasstimelate = 0;
        }
    }

    public int texturewidth;

    public float textfontwidth;
    [SerializeField] Text text;
    [SerializeField] RawImage image;
    [SerializeField] Transform imageparent;
    [SerializeField] float texturenyang;
    [SerializeField] float showupdatetime;
    public List<Tutorial> Turorials = new List<Tutorial>();
    List<RawImage> texturepool = new List<RawImage>();
    Tutorial thatguy;
    public List<Tutorial> showedTutorial = new List<Tutorial>();

    Transform player;
    private void Start()
    {
        player = GameObject.Find("Player").transform;
        textpos = text.transform.localPosition;
        StartCoroutine(showsCo());
    }
    
    IEnumerator showsCo()
    {
        yield return new WaitForSeconds(showupdatetime);
        if (PlayerSettings.Tutorial.TutorialOn)
        {
            if (Loading_Manager.isLoaded)
            {
                CheckTutorialSwitch();
                showtutorials(showupdatetime);
            }
        }
        else
        {
            imageparent.gameObject.SetActive(false);
        }
        //Debug.Log(TutorialFlowNum);

        StartCoroutine(showsCo());
    }

    void showtutorials(float timelate)
    {
        showingtutorials = new List<Tutorial>();
        for (int i = 0; i < Turorials.Count; i++)
        {
            ShowTutorialListAdd(Turorials[i]);
        }
        Tutorial aaaaaa = GetShowTutorialList();
        if (aaaaaa == null)
        {
            imageparent.gameObject.SetActive(false);
            return;
        }
        else
        {
            imageparent.gameObject.SetActive(true);
        }
        if(aaaaaa != thatguy)
        {
            if(thatguy != null)
            {
                thatguy.Exit();
            }
        }
        thatguy = aaaaaa;

        aaaaaa.tutorialpasstimelate += timelate;
        aaaaaa.tutorialSetpasstimelate += timelate;

        if(aaaaaa.tutorialpasstimelate > aaaaaa.tutorialpasstime)
        {
            aaaaaa.isshowing = false;
            aaaaaa.Exit();
            if (!aaaaaa.again)
            {
                showedTutorial.Add(aaaaaa);
            }
            string[] g = aaaaaa.showingSetting.Split(' ');
            if(g[0] == "Flow")
            {
                TutorialFlowNum = int.Parse(g[1]) + 1;
            }
        }

        if(aaaaaa.tutorialSetpasstimelate > aaaaaa.tutorialSetpasstime)
        {
            aaaaaa.Setisplayed = false;
            aaaaaa.playing_index++;
        }
        if (!aaaaaa.Setisplayed)
        {
            ShowTutorialSet(aaaaaa.tutorial[aaaaaa.playing_index % aaaaaa.tutorial.Count], text);
            aaaaaa.Setisplayed = true;
        }
    }

    List<Tutorial> showingtutorials = new List<Tutorial>();
    void ShowTutorialListAdd(Tutorial tutoriala)
    {
        if (tutoriala.isshowing)
        {
            if (showedTutorial.Contains(tutoriala))
            {
                return;
            }
            showingtutorials.Add(tutoriala);
        }
    }
    Tutorial GetShowTutorialList()
    {
        float maxpriority = -1;
        Tutorial max = null;
        for (int i = 0; i < showingtutorials.Count; i++)
        {
            if(maxpriority < showingtutorials[i].priority)
            {
                maxpriority = showingtutorials[i].priority;
                max = showingtutorials[i];
            }
        }
        return max;
    }
    Vector3 textpos;

    void ResetStamp()
    {
        for (int i = 0; i < texturepool.Count; i++)
        {
            texturepool[i].gameObject.SetActive(false);
        }
    }
    void ShowTutorialSet(Tutorial.TutorialSet that, Text textui)
    {
        ResetStamp();

        List<char> strs = new List<char>();
        List<int> stampindex = new List<int>();
        List<int> stampindexcheck = new List<int>();
        int y = 0;

        for (int i = 0; i < that.str.Length + that.stamps.Count * 3; i++) 
        {
            //for (int j = 0; j < that.stamps.Count; j++)
            //{
            //    if (i >= that.stamps[j].ordernum - 1)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            strs.Add(' ');
            //        }
            //    }
            //}
            for (int j = 0; j < that.stamps.Count; j++)
            {
                if(that.stamps[j].ordernum-1 == i)
                {
                    stampindex.Add(y);
                    stampindexcheck.Add(that.stamps[j].ordernum);
                    for (int k = 0; k < 3; k++)
                    {
                        strs.Add(' ');
                    }
                    y += 2;
                }
            }
            if(i >= that.str.Length)
            {
                continue;
            }
            strs.Add(that.str[i]);
            y += 1;
        }

        string str = new string(strs.ToArray());

        //textui.transform.localScale = new Vector3(textfontwidth * strs.Count + 2, textui.transform.localScale.y, 1);
        textui.rectTransform.sizeDelta = new Vector2(40 * (strs.Count + 2 / 2), 50);

        //textui.transform.localPosition = textpos - Vector3.right * (strs.Count * textfontwidth - 1);

        textui.text = str;
        //35 25 15 25 20 10 

        float ypos = textui.transform.localPosition.y;
        float xpos = textui.transform.localPosition.x;

        // a b c () d e f g 
        for (int i = 0; i < that.stamps.Count; i++)
        {
            //institateTexture(that.stamps[i].images, new Vector3(xpos - ((float)(strs.Count - 1) * 0.5f * textfontwidth) + 
            //    (that.stamps[i].ordernum * textfontwidth) + texturenyang, ypos));
            //institateTexture(that.stamps[i].images, new Vector3(xpos + 25 + 23 * (that.stamps[i].ordernum-1), ypos + 25));
            for(int j = 0; j < stampindexcheck.Count; j++)
            {
                if (stampindexcheck[j] == that.stamps[i].ordernum)
                {
                    //Debug.Log(stampindex[j]);
                    institateTexture(that.stamps[i].images, new Vector3(xpos + 35 + 21 * (stampindex[j]), ypos + 25));
                }
            }
        }
    }

    RawImage institateTexture(Texture texturea, Vector3 pos)
    {
        //texturepool
        for(int i = 0; i < texturepool.Count; i++)
        {
            if (!texturepool[i].gameObject.activeSelf)
            {
                texturepool[i].gameObject.SetActive(true);
                texturepool[i].transform.localPosition = pos;
                texturepool[i].texture = texturea;
                return texturepool[i];
            }
        }

        var thata = Instantiate(image, Vector3.zero, Quaternion.identity);
        texturepool.Add(thata);
        thata.transform.SetParent(imageparent);
        thata.transform.localPosition = pos;
        thata.texture = texturea;
        return thata;
    }

    //순서대로 이어지기
    //나무 얻을때
    //돌 얻을때
    //조합할때
    //작물 얻을때
    //건물 건설할때
    //철 얻을때
    //코어주울떄
    //괴물 발견
    //적 발견
    public int TutorialFlowNum = 0;
    void CheckTutorialSwitch()
    {
        int minnum = 10000;
        foreach (Tutorial aa in Turorials)
        {
            string[] aaaaa = aa.showingSetting.Split(' ');
            if (aaaaa[0] == "Flow")
            {
                if (int.Parse(aaaaa[1]) >= TutorialFlowNum)
                {
                    if (int.Parse(aaaaa[1]) < minnum)
                    {
                        minnum = int.Parse(aaaaa[1]);
                    }
                }
            }
        }
        TutorialFlowNum = minnum;

        foreach (Tutorial a in Turorials)
        {
            string[] str = a.showingSetting.Split(' ');
            if(str[0] == "GetItem")
            {
                if(str[1] == "any")
                {
                    if (play_record_info.GetItemRecord.records.Count == 0)
                    {
                        continue;
                    }
                    a.isshowing = true;
                    continue;
                }
                if (WhenGetItem(str[1]))
                {
                    a.isshowing = true;
                    continue;
                }
            }
            else if(str[0] == "Make")
            {
                if (str[1] == "any")
                {
                    if(play_record_info.Item_Make_Record.records.Count == 0)
                    {
                        continue;
                    }
                    a.isshowing = true;
                    continue;
                }
                if (WhenMakeItem(str[1]))
                {
                    a.isshowing = true;
                    continue;
                }
            }
            else if (str[0] == "Until")
            {
                if (str[1] == "any")
                {
                    if (play_record_info.GetItemRecord.records.Count == 0)
                    {
                        a.tutorialpasstimelate = a.tutorialpasstime - 1;
                        a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                        a.isshowing = true;
                        continue;
                    }
                    a.isshowing = false;
                    continue;
                }

                if (WhenGetItem(str[1]))
                {
                    a.isshowing = false;
                    continue;
                }
                else
                {
                    a.tutorialpasstimelate = a.tutorialpasstime - 1;
                    a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                    a.isshowing = true;
                    continue;
                }
            }
            else if (str[0] == "UntilADD")
            {
                foreach(Tutorial k in showedTutorial)
                {
                    if(k.name == str[2])
                    {
                        if (str[1] == "any")
                        {
                            if (play_record_info.GetItemRecord.records.Count == 0)
                            {
                                a.tutorialpasstimelate = a.tutorialpasstime - 1;
                                a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                                a.isshowing = true;
                                break;
                            }
                            else
                            {
                                a.isshowing = false;
                                break;
                            }
                        }
                        else 
                        {
                            if (WhenGetItem(str[1]))
                            {
                                a.isshowing = false;
                                break;
                            }
                            else
                            {
                                a.tutorialpasstimelate = a.tutorialpasstime - 1;
                                a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                                a.isshowing = true;
                                break;
                            }
                        }
                    }
                }
                continue;


            }
            else if (str[0] == "UntilMakeADD")
            {
                foreach (Tutorial k in showedTutorial)
                {
                    if (k.name == str[2])
                    {
                        if (str[1] == "any")
                        {
                            if (play_record_info.Item_Make_Record.records.Count == 0)
                            {
                                a.tutorialpasstimelate = a.tutorialpasstime - 1;
                                a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                                a.isshowing = true;
                                break;
                            }
                            else
                            {
                                a.isshowing = false;
                                break;
                            }
                        }
                        else
                        {
                            if (WhenMakeItem(str[1]))
                            {
                                a.isshowing = false;
                                break;
                            }
                            else
                            {
                                a.tutorialpasstimelate = a.tutorialpasstime - 1;
                                a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                                a.isshowing = true;
                                break;
                            }
                        }
                    }
                }
                continue;


            }
            else if (str[0] == "GetADD")
            {
                foreach (Tutorial k in showedTutorial)
                {
                    if (k.name == str[2])
                    {
                        if (str[1] == "any")
                        {
                            if (play_record_info.GetItemRecord.records.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                a.isshowing = true;
                                break;
                            }
                        }
                        else
                        {
                            if (WhenGetItem(str[1]))
                            {
                                a.isshowing = true;
                                break;
                            }
                        }
                    }
                }
                continue;


            }
            else if (str[0] == "FlowADD")
            {
                foreach (Tutorial k in showedTutorial)
                {
                    if (k.name == str[1])
                    {
                        a.isshowing = true;
                        break;
                    }
                }
                continue;


            }
            else if (str[0] == "MakeADD")
            {
                foreach (Tutorial k in showedTutorial)
                {
                    if (k.name == str[2])
                    {
                        if (str[1] == "any")
                        {
                            if (play_record_info.Item_Make_Record.records.Count == 0)
                            {
                                break;
                            }
                            else
                            {
                                a.isshowing = true;
                                break;
                            }
                        }
                        else
                        {
                            if (WhenMakeItem(str[1]))
                            {
                                a.isshowing = true;
                                break;
                            }
                        }
                    }
                }
                continue;


            }
            else if (str[0] == "UntilMake")
            {
                if (str[1] == "any")
                {
                    if (play_record_info.Item_Make_Record.records.Count == 0)
                    {
                        a.tutorialpasstimelate = a.tutorialpasstime - 1;
                        a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                        a.isshowing = true;
                        continue;
                    }
                    a.isshowing = false;
                    continue;
                }

                if (WhenMakeItem(str[1]))
                {
                    a.isshowing = false;
                    continue;
                }
                else
                {
                    a.tutorialpasstimelate = a.tutorialpasstime - 1;
                    a.tutorialSetpasstimelate = a.tutorialSetpasstime - 1;
                    a.isshowing = true;
                    continue;
                }
            }
            else if (str[0] == "Time")
            {
                if (play_record_info.PlayedTimeRecord.GetPlayTime() > int.Parse(str[1]))
                {
                    a.isshowing = true;
                    continue;
                }
                else
                {
                    continue;
                }
            }
            else if (str[0] == "Flow")
            {
                if(int.Parse(str[1]) == TutorialFlowNum)
                {
                    a.isshowing = true;
                    continue;
                }
            }
            else if (str[0] == "Scan")
            {
                Collider[] klpklp = Physics.OverlapSphere(player.position, 10);
                for(int i = 0; i < klpklp.Length; i++)
                {
                    if(klpklp[i].tag == str[1])
                    {
                        a.isshowing = true;
                        break;
                    }
                }
                continue;
            }
            else if (str[0] == "ScanName")
            {
                Collider[] klpklp = Physics.OverlapSphere(player.position, 5);
                for (int i = 0; i < klpklp.Length; i++)
                {
                    if (klpklp[i].name == str[1])
                    {
                        a.isshowing = true;
                        break;
                    }
                }
                continue;
            }
        }

    }

    bool WhenGetItem(string item)
    {
        if (play_record_info.GetItemRecord.GetRecord(item) != 0)
        {
            return true;
        }
        return false;
    }
    bool WhenMakeItem(string item)
    {
        if (play_record_info.Item_Make_Record.GetRecord(item) != 0)
        {
            return true;
        }
        return false;
    }
}
