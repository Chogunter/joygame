using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheat : MonoBehaviour
{
    public InputField cheattext;
    //public Text viewtext;
    [SerializeField] Text text_Prefab;
    [SerializeField] Transform Contents;
    [SerializeField] InputField chatting;

    public GameObject pig0;
    public GameObject pig1;

    private bool slot1s;
    private bool slot2s;
    private bool slot3s;
    private bool slot4s;
    private bool slot5s;
    private bool slot6s;
    private bool slot7s;

    private string itemget;

    public GameObject Habsungmake;

    GameObjectPool game_object_pool;

    public string output = "";
    public string stack = "";

    bool isLog;

    GameObject ajuci;

    GameObject Player;

    [SerializeField] Text LoadingUIs;
    private void Awake()
    {
        ajuci = gameObject;
        game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        Player = GameObject.Find("Player");

        Application.logMessageReceivedThreaded += HandleLog;
        PlayerPrefs.SetString("chattingLog", "on");
        isLog = true;

    }
    string imti = "";
    void HandleLog(string logString, string stackTrace, LogType type)
    {
        if(ajuci.activeSelf == false)
        {
            return;
        }

        output = logString;
        stack = stackTrace;

        if (output != "")
        {
            var sss = Instantiate(text_Prefab);
            sss.rectTransform.SetParent(Contents);
            sss.rectTransform.localPosition = new Vector3(465, -30, 0);
            sss.rectTransform.localScale = new Vector3(1, 1, 1); 
            if (type.ToString() == "Error")
            {
                imti = "❗";
            }

            sss.text = imti + "Unity Log System Log : " + output + "( Log Type : " + type.ToString() + " )";
            output = "";

            var aaasss = Instantiate(text_Prefab);
            aaasss.rectTransform.SetParent(Contents);
            aaasss.rectTransform.localPosition = new Vector3(465, -30, 0);
            aaasss.rectTransform.localScale = new Vector3(1, 1, 1);
            aaasss.text = "Unity Log System Stack : " + stack;
            LoadingUIs.text = $"log : \n{output} \n stack : {stack}";
            stack = "";

            if (type.ToString() == "Error")
            {
                sss.color = new Color(241 / 255f, 95 / 255f, 95 / 255f);
                aaasss.color = new Color(241 / 255f, 95 / 255f, 95 / 255f);
            }
        }
    }

    private void OnDisable()
    {
        Application.logMessageReceivedThreaded -= HandleLog;
        PlayerPrefs.SetString("chattingLog", "off");
    }

    float deltaTime;

    List<string> records = new List<string>();
    int upanddown = 0;
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        isLog = PlayerPrefs.GetString("chattingLog") == "on" ? true : false;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //if(upanddown != 0)
            //{
            //    cheattexta(records[records.Count - upanddown]);
            //    ++upanddown;
            //    return;
            //}
            cheattexta(cheattext.text);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (upanddown < records.Count)
            {
                ++upanddown;
                cheattext.text = records[records.Count - upanddown];
            }

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (upanddown > 0)
            {
                cheattext.text = records[records.Count - upanddown];
                --upanddown;
            }

        }
        if (!cheattext.gameObject.activeSelf)
        {
            upanddown = 0;
        }
    }

    void cheattexta(string str)
    {
        if (true)
        {
            string[] a = str.Split(' ');
            if (str == "")
            {
                return;
            }
            if (str == "/FPS")
            {
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : " + (1.0f / deltaTime).ToString();
            }
            else if (str == "/Unity Log show")
            {
                if (isLog)
                {
                    var ass = Instantiate(text_Prefab);
                    ass.rectTransform.SetParent(Contents);
                    ass.rectTransform.localPosition = new Vector3(465, -30, 0);
                    ass.rectTransform.localScale = new Vector3(1, 1, 1);
                    ass.text = "system : Unity Log is already on.";
                    return;
                }
                Application.logMessageReceivedThreaded += HandleLog;
                PlayerPrefs.SetString("chattingLog", "on");
                isLog = true;
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : Unity Log on ";
            }
            else if (str == "/Unity Log hide")
            {
                if (!isLog)
                {
                    var ass = Instantiate(text_Prefab);
                    ass.rectTransform.SetParent(Contents);
                    ass.rectTransform.localPosition = new Vector3(465, -30, 0);
                    ass.rectTransform.localScale = new Vector3(1, 1, 1);
                    ass.text = "system : Unity Log is already off.";
                    return;
                }
                Application.logMessageReceivedThreaded -= HandleLog;
                PlayerPrefs.SetString("chattingLog", "off");
                isLog = false;
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : Unity Log off ";
            }
            else if (str == "/kill me")
            {
                this.GetComponent<Player_Hp>().Hugi = 0;
                //viewtext.text = " ";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : killed ";
            }
            else if (str == "/immortal")
            {
                GetComponent<Player_Hp>().undie = true;
                //viewtext.text = " immortal ";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : Immortal ";
            }
            else if (str == "/un immortal")
            {
                GetComponent<Player_Hp>().undie = false;
                //viewtext.text = " not immortal ";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : Un Immortal ";
            }
            else if (str == "/Unlock Cores")
            {
                Habsungmake.GetComponent<habsungchoose>().Unlockedthing.Add("orangecore");
                Habsungmake.GetComponent<habsungchoose>().Unlockedthing.Add("puplecore");
                Habsungmake.GetComponent<habsungchoose>().Unlockedthing.Add("redcore");
                //viewtext.text = "Unlocked all cores";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : Cores are unlocked ";
            }

            else if (str == "/summon pig 0")
            {
                game_object_pool.Instantiates("sangmul", transform.position, transform.rotation);
                //viewtext.text = "pig summon";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : pig is summoned ";
            }
            else if (str == "/summon pig 1")
            {
                game_object_pool.Instantiates("sangmul_domesticated", transform.position, transform.rotation);
                //viewtext.text = "pig summon";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : your pig is summoned";
            }

            else if (str == "/time add")
            {
                //viewtext.text = "Time add 1";
                this.GetComponent<TimeManager>().Time1();
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : time add ";
            }
            else if (str == "/time minus")
            {
                //viewtext.text = "Time minus 1";
                this.GetComponent<TimeManager>().Timeno1();
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : time minus ";
            }
            else if (str == "/show savefolder path")
            {
                cheattext.text = Application.persistentDataPath;
            }
            else if (str == "/show app path")
            {
                cheattext.text = Application.streamingAssetsPath;
            }
            else if(str == "/FREEITEMS!!")
            {
                Item_make_info.FreeItems();

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : FREEITEMSSSSSS!!!!!!!!!!!";
            }
            else if (str == "/help" || str == "/?")
            {
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = " /FPS : show fps \n /Unity Log show : show the unity engine log \n /Unity Log hide : hide the unity engine log \n" +
                    " /kill me : kill yourself \n /immortal : be immortal \n /un immortal : be not immortal \n /Unlock Cores : unlock cores. then, you can make" +
                    " any cores in core synthesizer \n /summon pig (0, 1) : summon pig \n /time add : add to time \n /time minus : time off \n" +
                    " /show savefolder path : show save folder path \n /show app path : show app path \n /setslot (slot number) (item code name) (amount) : " +
                    " set (slot number) to (item code name) \n /build (object code name) : spawn any object \n /SetHp (value) : set your Hp \n" +
                    " /SetHunger (value) : set your hunger \n /SetMaxHp (value) : set your Max_Hp \n /SetMaxEnergy (value) : set your Max_Energy \n" +
                    " /SetSpeed (value) : set your speed \n /SetJumpPower (value) : set your jump_power \n /set audio sound (value) : set audio sound \n" +
                    " /FREEITEMS!! : make items for free \n ";
            }
            else if (a[0] == "/set audio sound")
            {
                GameObject.Find("Player_sound").GetComponent<Player_sound_effect>().audiosound = int.Parse(a[2]);

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : set audio sound {int.Parse(a[2])}";
            }
            else if (a[0] == "/setslot")
            {
                string item = a[2];
                int num = int.Parse(a[3]);

                if (a[1] == "1")
                {
                    GetComponent<PlayerHand>().PickUp1 = item;
                    GetComponent<PlayerHand>().Amount1 = num;
                }
                else if (a[1] == "2")
                {
                    GetComponent<PlayerHand>().PickUp2 = item;
                    GetComponent<PlayerHand>().Amount2 = num;
                }
                else if (a[1] == "3")
                {
                    GetComponent<PlayerHand>().PickUp3 = item;
                    GetComponent<PlayerHand>().Amount3 = num;
                }
                else if (a[1] == "4")
                {
                    GetComponent<PlayerHand>().PickUp4 = item;
                    GetComponent<PlayerHand>().Amount4 = num;
                }
                else if (a[1] == "5")
                {
                    GetComponent<PlayerHand>().PickUp5 = item;
                    GetComponent<PlayerHand>().Amount5 = num;
                }
                else if (a[1] == "6")
                {
                    GetComponent<PlayerHand>().PickUp6 = item;
                    GetComponent<PlayerHand>().Amount6 = num;
                }
                else if (a[1] == "7")
                {
                    GetComponent<PlayerHand>().PickUp7 = item;
                    GetComponent<PlayerHand>().Amount7 = num;
                }

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : set slot" + a[1] + " item: " + item + " amount: " + num;
                //viewtext.text = "set slot" + a[1] + " item: " + item + " amount: " + num;

            }
            else if (a[0] == "/build")
            {
                string namesdad = a[1];
                game_object_pool.Instantiates(namesdad, transform.position + transform.forward * 5, transform.rotation);
                //viewtext.text = "pig summon";
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = "system : " + namesdad + " is built";
            }
            else if (a[0] == "/SetHp")
            {
                int namesdad = int.Parse(a[1]);

                Player.GetComponent<Player_Hp>().PlayerHp = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_Hp is {namesdad}! (cannot exceed the maximum)";
            }
            else if (a[0] == "/SetHunger")
            {
                int namesdad = int.Parse(a[1]);

                Player.GetComponent<Player_Hp>().Hugi = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_Hunger is {namesdad}! (cannot exceed the maximum)";
            }
            else if (a[0] == "/SetMaxHp")
            {
                int namesdad = int.Parse(a[1]);

                PlayerSettings.Player.PlayerMaxHp = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_Max_Hp is {namesdad}!";
            }
            else if (a[0] == "/SetMaxEnergy")
            {
                int namesdad = int.Parse(a[1]);

                PlayerSettings.Player.PlayerEnergyMax = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_Max_Energy is {namesdad}!";
            }
            else if (a[0] == "/SetSpeed")
            {
                float or_speed = PlayerSettings.Player.PlayerSpeed;
                float namesdad = float.Parse(a[1]);

                PlayerSettings.Player.PlayerSpeed = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_Speed is {namesdad}! (it was {or_speed})";
            }
            else if (a[0] == "/SetJumpPower")
            {
                float or_speed = PlayerSettings.Player.PLayerJumpPower;
                float namesdad = float.Parse(a[1]);

                PlayerSettings.Player.PLayerJumpPower = namesdad;

                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = $"system : Player_JumpPower is {namesdad}! (it was {or_speed})";
            }
            else if (cheattext.text.Contains("/"))
            {
                var ass = Instantiate(text_Prefab);
                ass.rectTransform.SetParent(Contents);
                ass.rectTransform.localPosition = new Vector3(465, -30, 0);
                ass.rectTransform.localScale = new Vector3(1, 1, 1);
                ass.text = "System Error : it's not on the list " + cheattext.text;
                ass.color = new Color(241 / 255f, 95 / 255f, 95 / 255f);
            }

            else
            {
                var sss = Instantiate(text_Prefab);
                sss.rectTransform.SetParent(Contents);
                sss.rectTransform.localPosition = new Vector3(465, -30, 0);
                sss.rectTransform.localScale = new Vector3(1, 1, 1);
                sss.text = cheattext.text;
                //viewtext.text = "The command cannot be used.There is no '" + cheattext.text + "' command.";
            }
        }
        records.Add(cheattext.text);
    }
}
