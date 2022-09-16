using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Threading.Tasks;

public class saveandload_script : MonoBehaviour
{
    [SerializeField] GameObjectPool objectpool;

    [System.Serializable]
    public class SaveClass
    {
        public string datanamepp;
        public string date;

        public float time;
        public int day;

        [System.Serializable]
        public class Playerclass
        {
            public string name = "Player";

            [System.Serializable]
            public class PlayerItem
            {
                public string name;
                public int ammount;
            }
            public List<PlayerItem> Items;
            public int Hp;
            public int hugi;
            public float energy;
            public Vector3 pos;
            public Quaternion rot;
        }

        //[System.Serializable]
        //public class Objects
        //{
        //    public string listdatas; // json data string 리스트 모아서 저장
        //}

        //public string objects; // 여기에 모두 저장

        [System.Serializable]
        public class jwapyosdata
        {
            public Vector3 pos;
            public string name;
        }

        public geteachotherclassbuddle objects = new geteachotherclassbuddle();
        public Playerclass Playerdatas = new Playerclass(); // 여기에 플레이어 저장

        public List<jwapyosdata> jwapyosdataList = new List<jwapyosdata>();

        public List<string> ShowedTutorials = new List<string>();
        public int TutorialFlowNum;
    }
    SaveClass saveclass = new SaveClass();

    ////////////////////////////////////////////////

    [SerializeField] TimeManager timemanager;

    [System.Serializable]
    public class Items
    {
        public string name;
        public int Hp;
        public Vector3 pos;
        public Quaternion rot;
    }
    [System.Serializable]
    public class Enemys
    {
        public string name;

        public Vector3 or_pos;
        public Quaternion or_rot;
        public List<Vector3> or_poses = new List<Vector3>();

        public List<int> Hps = new List<int>();
        public List<bool> actives = new List<bool>();
        public List<Vector3> poss = new List<Vector3>();
        public List<Quaternion> rots = new List<Quaternion>();
    }

    [System.Serializable]
    public class NotEnemyEntity
    {
        public string name;
        public int Hp;
        public Vector3 pos;
        public Quaternion rot;
        public Vector3 or_pos;
    }

    [System.Serializable]
    public class Building
    {
        public string name;
        public int Hp;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class finalboss
    {
        public string name;
        public float killtime;
        public int Hp;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class feature
    {
        public string name;
        //public string summondata; //json data string 넣어서 나중에 load 할때 맞춰서 로드해야함
        public geteachotherclassbuddle summondata = new geteachotherclassbuddle();
        public List<float> times = new List<float>();
        public Vector3 pos;
        public Quaternion rot;
        public List<int> amounts = new List<int>();
        public List<string> Items = new List<string>();
        public List<Items> namuanddolls = new List<Items>();
    }

    [System.Serializable]
    public class Sangja
    {
        public string name;
        public string item1;
        public string item2;
        public int num1;
        public int num2;

        public int Hp;

        public bool iscanbreak;

        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class yongwanglo
    {
        public string name;
        public int Hp;
        public int amount;
        public float time;

        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class Vehicle
    {
        public string name;
        public List<Sangja> sangjas = new List<Sangja>(); // 상자데이터 넣어버리기
        public Vector3 pos;
        public Quaternion rot;
        public bool isgetin;
    }

    [System.Serializable]
    public class tuchuck
    {
        public string name;
        public Vector3 velocity;
        public float killtime;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class house
    {
        public string name;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class jackmuls
    {
        public string name;
        public float timelate;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class justposandrot
    {
        public string name;
        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class paintbrush
    {
        public string name;
        public string material;
        public int Hp;
        public Vector3 pos;
        public Quaternion rot;
    }


    [System.Serializable]
    public class bundles
    {
        public string name;

        [System.Serializable]
        public class PlayerItem
        {
            public string name;
            public int ammount;
        }
        public List<PlayerItem> Items = new List<PlayerItem>();

        public Vector3 pos;
        public Quaternion rot;
    }

    [System.Serializable]
    public class EnemySolo
    {
        public string name;

        public int Hp;
        public bool isTeam;
        public Vector3 or_pos;

        public Vector3 pos;
        public Quaternion rot;

        public List<Item_make_info.MakerItem> DealItems = new List<Item_make_info.MakerItem>();
    }
    ////////////////////////////////////////////////

    [System.Serializable]
    public class geteachotherclassbuddle
    {
        public List<Items> Itemsclass = new List<Items>();
        public List<Enemys> enemyclass = new List<Enemys>();
        public List<NotEnemyEntity> NotEnemyEntityclass = new List<NotEnemyEntity>();
        public List<Building> Buildingclass = new List<Building>();
        public List<finalboss> finalbossclass = new List<finalboss>();
        public List<feature> featureclass = new List<feature>();
        public List<Sangja> sangjaclass = new List<Sangja>();
        public List<yongwanglo> yongwangloclass = new List<yongwanglo>();
        public List<Vehicle> vehicleclass = new List<Vehicle>();
        public List<tuchuck> tuchuckclass = new List<tuchuck>();
        public List<house> houseclass = new List<house>();
        public List<jackmuls> jackmulsclass = new List<jackmuls>();
        public List<justposandrot> justposandrotclass = new List<justposandrot>();
        public List<paintbrush> paintbrushclass = new List<paintbrush>();
        public List<bundles> bundlesss = new List<bundles>();
        public List<EnemySolo> enemysoloss = new List<EnemySolo>();
    }

    //뭔가 더 작업 편하게 하고싶은걸 어캄 ㅋ
    [System.Serializable]
    public class Itemtypes
    {
        public string type;
        public List<string> Items;
    }
    [SerializeField] List<Itemtypes> ItemtypeList = new List<Itemtypes>();

    string AppPATH;
    void Awake()
    {
        //AppPATH = Application.dataPath;
        AppPATH = Application.persistentDataPath;

        PlayerSettings.Player.PlayerAttackDmg = 5;
        PlayerSettings.Player.PlayerHitDmg = 1;
        PlayerSettings.Player.PlayerMaxHp = 200;
        PlayerSettings.Player.PlayerPushDegree = 5;
        PlayerSettings.Player.PlayerSpeed = 6;
        PlayerSettings.Player.PLayerJumpPower = 70;
        PlayerSettings.Player.PlayerEnergyMax = 10;

        Loading_Manager.isLoaded = false;

        LoadSets();

        tryload();
    }

    void LoadSets()
    {
        string pathsf = Path.Combine(AppPATH, PlayerPrefs.GetString("OptionPath"), "Option.json");

        if (!Directory.Exists(Path.Combine(AppPATH, PlayerPrefs.GetString("OptionPath"))))
        {
            //Debug.Log("폴더 없음!");
            return;
        }

        string datastring = File.ReadAllText(pathsf);
        //Debug.Log(pathsf);
        //Debug.Log(datastring);
        PlaySettingSets.OptionSaves thatoptions = JsonUtility.FromJson<PlaySettingSets.OptionSaves>(datastring);

        PlayerSettings.AudioSetting.Volume = thatoptions.Volume;
        PlayerSettings.PlaySetting.MouseDegree = thatoptions.mousedegree;
        PlayerSettings.Tutorial.TutorialOn = thatoptions.TutorialOn;
        PlayerSettings.VideoSetting.ViewingAngle = thatoptions.ViewingAngle;
    }
    List<GameObject> Objectsinpool = new List<GameObject>();

    List<Items> Item = new List<Items>();
    List<Enemys> Enemy = new List<Enemys>();
    List<NotEnemyEntity> NotEnemyEntitys = new List<NotEnemyEntity>();
    List<Building> Buildings = new List<Building>();
    List<finalboss> finalbosses = new List<finalboss>();
    List<feature> features = new List<feature>();
    List<Sangja> Sangjas = new List<Sangja>();
    List<yongwanglo> yongwanglos = new List<yongwanglo>();
    List<Vehicle> Vehicles = new List<Vehicle>();
    List<tuchuck> tuchucks = new List<tuchuck>();
    List<house> houses = new List<house>();
    List<jackmuls> jackmul = new List<jackmuls>();
    List<justposandrot> justposandrots = new List<justposandrot>();
    List<paintbrush> paintbrushs = new List<paintbrush>();
    List<bundles> bundless = new List<bundles>();
    List<EnemySolo> enemysolos = new List<EnemySolo>();

    string that_item_type;

    GameObject Player;
    GameObject Inven;

    void ResetLists()
    {
        Item = new List<Items>() { };
        Enemy = new List<Enemys>() { };
        NotEnemyEntitys = new List<NotEnemyEntity>() { };
        Buildings = new List<Building>() { };
        finalbosses = new List<finalboss>() { };
        features = new List<feature>() { };
        Sangjas = new List<Sangja>() { };
        yongwanglos = new List<yongwanglo>() { };
        Vehicles = new List<Vehicle>() { };
        tuchucks = new List<tuchuck>() { };
        houses = new List<house>() { };
        jackmul = new List<jackmuls>() { };
        justposandrots = new List<justposandrot>() { };
        paintbrushs = new List<paintbrush>() { };
        Objectsinpool = new List<GameObject>() { };
        saveclass.Playerdatas.Items = new List<SaveClass.Playerclass.PlayerItem>() { };
        bundless = new List<bundles>() { };
    }

    public bool saveswitch = false;
    public string filepatha = "jsonfilesavesfolderss";
    public string namea;
    public bool cancan;

    public string spwanObjectname;
    public bool spawns = false;
    //public bool startboolgogo;

    [SerializeField] jwapyo jwapyomanager;

    float loadtime = 0;
    bool loadbool = false;

    int loading_progress;
    [SerializeField] Text loading_progresstx;
    [SerializeField] Slider loading_progresssl;

    string loadingtype;
    int loadingmaxpercentage = 0;

    [SerializeField] Player_sound_effect soundeffect;
    float soundvolume;
    private void Start()
    {
        soundvolume = soundeffect.audiosound;
        soundeffect.audiosound = 0;
        Loading_Manager.isExit = false;
    }

    private void OnApplicationQuit()
    {
        Loading_Manager.isExit = true;
    }

    private void Update()
    {
        loadtime += Time.deltaTime;

        if (loadingtype == "start")
        {
            loading_progress = (int)((percentage / 5761f) * 100f);
        }
        else if(loadingtype == "load")
        {
            loading_progress = (int)((float)((float)percentage / (float)loadingmaxpercentage) * 100f);
        }
        loading_progresstx.text = loading_progress.ToString() + " %";
        loading_progresssl.value = loading_progress / 100f;

        if (saveswitch)
        {
            if(filepatha != "" && namea != "")
            {
                saveswitch = false;
                Save(filepatha, namea, cancan);
            }
        }
        //if (startboolgogo)
        //{
        //    if(PlayerPrefs.GetString("SaveAndLoadCommand") == "Start")
        //    {
        //        PlayerPrefs.SetString("SaveAndLoadCommand", "none");
        //        PlayerPrefs.SetString("filepath", "none");
        //        startboolgogo = false;
        //        return;
        //    }
        //    PlayerPrefs.SetString("SaveAndLoadCommand", "Start");
        //    PlayerPrefs.SetString("filepath", "none");
        //    startboolgogo = false;
        //}

        //Debug.Log(gettype(thatguy));

        if (spawns)
        {
            Spone(spwanObjectname);
            spawns = false;
        }

        if (loadtime > 1 && loadbool)
        {
            loadbool = false;
            Debug.Log("로드 시도!");
            if (PlayerPrefs.GetString("SaveAndLoadCommand") == "load")
            {
                loadingtype = "load";
                Debug.Log("로드 접근!");
                Debug.Log("로드 " + PlayerPrefs.GetString("filepath"));
                //if (Load(PlayerPrefs.GetString("filepath")) == 0)
                //{
                //    Debug.Log("로드 끝!");
                //}
                //else
                //{
                //    Debug.Log("로드 실패!");
                //}
                //LoadCo(PlayerPrefs.GetString("filepath"));
                StartCoroutine(LoadCo(PlayerPrefs.GetString("filepath")));

                PlayerPrefs.SetString("SaveAndLoadCommand", "none");
                PlayerPrefs.SetString("filepath", "none");
            }
            else if (PlayerPrefs.GetString("SaveAndLoadCommand") == "Start")
            {
                loadingtype = "start";
                PlayerPrefs.SetString("SaveAndLoadCommand", "none");
                Debug.Log("시작 접근!");
                //randommapstart();
                StartCoroutine(randommapstartCo());
            }
            else
            {
                isdddd = 50;
            }
        }

        if (isdddd >= 3)
        {
            //Debug.Log(percentage); // 5761
            LoadSceneInMain.is_loaded = true;
            Loading_Manager.isLoaded = true;
            soundeffect.audiosound = soundvolume;
        }
    }
    public string thatguy;

    void Spone(string thathahhah)
    {
        GameObjectPool game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        game_object_pool.Instantiates(thathahhah, transform.position, transform.rotation);
    }

    void tryload()
    {
        Debug.Log("게임이 로드됨!");
        loadbool = true;
    }

    List<GameObject> featureMob = new List<GameObject>();

    public int Save(string filepath, string name, bool height_map_available) // 0 : 잘됨 1 : 이미 있음 2 : 오류발생
    {
        ResetLists();
        Player = GameObject.Find("Player");
        Inven = GameObject.Find("Inventory");
        if (true)
        {
            string nname = name + ".json";
            Objectsinpool = new List<GameObject>() { };
            featureMob = new List<GameObject>() { };
            //가져온 파일 path에 파일이 있는지 확인(있으면 리턴한 후 있다고 알려주기, bool이 투르면 무시)
            string path = Path.Combine(AppPATH, filepath, nname);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(Path.Combine(AppPATH, filepath));
            }
            if (!height_map_available)//존재 유무 체크
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    return 1;
                }
            }
            //오브젝트 풀에서 사용중인 오브젝트들 불러오기
            for(int i = 0; i < objectpool.Object.Count; i++)
            {
                for(int j = 0; j < objectpool.Object[i].ObjectItem.Count; j++)
                {
                    if (objectpool.Object[i].ObjectItem[j].activeSelf)
                    {
                        Objectsinpool.Add(objectpool.Object[i].ObjectItem[j]); 
                    }
                }
            }
            //오브젝트 불러온걸 데이터로 만들기
            for(int i = 0; i < Objectsinpool.Count; i++)
            {
                GameObject that = Objectsinpool[i];
                that_item_type = "";
                foreach (Itemtypes Itemtypesaaa in ItemtypeList)
                {
                    if (Itemtypesaaa.Items.Contains(that.name))
                    {
                        that_item_type = Itemtypesaaa.type;
                        //continue;
                        break;
                    }
                    //Debug.Log("항목에는 '" + that.name + "' 이 존재하지 않습니다.");
                    //return 2;
                }
                if(that_item_type == "")
                {
                    Debug.Log($"{that.name} 이라는 아이템은 타입이 정의되어있지않습니다.");
                    //return 2;
                }
                if (that_item_type == "Item")
                {
                    Items Itemsa = new Items() { }; // 이름, Hp, 위치, 방향
                    Itemsa.pos = that.transform.position;
                    Itemsa.rot = that.transform.rotation;
                    Itemsa.name = that.name;

                    if (that.GetComponent<NamuScript>())
                    {
                        Itemsa.Hp = that.GetComponent<NamuScript>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<DollScript>())
                    {
                        Itemsa.Hp = that.GetComponent<DollScript>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<ChulScript>())
                    {
                        Itemsa.Hp = that.GetComponent<ChulScript>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<GogiScript>())
                    {
                        Itemsa.Hp = that.GetComponent<GogiScript>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<DoguThrow>())
                    {
                        Itemsa.Hp = that.GetComponent<DoguThrow>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<ItemItemItemsss>())
                    {
                        Itemsa.Hp = that.GetComponent<ItemItemItemsss>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<HwalThrow>())
                    {
                        Itemsa.Hp = that.GetComponent<HwalThrow>().Hp;
                        Item.Add(Itemsa);
                    }
                    else if (that.GetComponent<chonglitem>())
                    {
                        Itemsa.Hp = that.GetComponent<chonglitem>().ItemAmount;
                        Item.Add(Itemsa);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "feature")
                {
                    feature featurea = new feature();
                    if (that.GetComponent<base_house>())
                    {
                        featurea.name = that.name;
                        featurea.pos = that.transform.position;
                        featurea.rot = that.transform.rotation;
                        featurea.times.Add(that.GetComponent<base_house>().time[0]);
                        featurea.times.Add(that.GetComponent<base_house>().time[1]);
                        featurea.times.Add(that.GetComponent<base_house>().time[2]);
                        List<GameObject> aaaaaa = that.GetComponent<base_house>().enemyspone;
                        List<Enemys> enemysfff = new List<Enemys>();
                        List<EnemySolo> enemysolosfff = new List<EnemySolo>();
                        List<Items> Itemsfff = new List<Items>();
                        List<NotEnemyEntity> NotEnemyEntityfff = new List<NotEnemyEntity>();
                        List<Vehicle> vehiclefff = new List<Vehicle>();

                        for (int k = 0; k < aaaaaa.Count; k++)
                        {
                            if (aaaaaa[k] == null)
                            {
                                continue;
                            }
                            GameObject thats = aaaaaa[k];
                            if (!thats.activeSelf)
                            {
                                continue;
                            }
                            if (gettype(aaaaaa[k].name) == "none")
                            {
                                Debug.Log("타입을 불러오는데에 실패했습니다." + thats.name);
                                return 2;
                            }
                            if (gettype(aaaaaa[k].name) == "Enemy")
                            {
                                Enemys Enemysa = new Enemys();
                                Enemysa.or_pos = thats.transform.position;
                                Enemysa.or_rot = thats.transform.rotation;
                                Enemysa.name = thats.name;
                                if (thats.GetComponent<Enemyteammaneger>())
                                {
                                    List<GameObject> enemysinthat = thats.GetComponent<Enemyteammaneger>().enemys;
                                    foreach (GameObject bbbbb in enemysinthat)
                                    {
                                        Enemysa.Hps.Add(bbbbb.GetComponent<Enemymove>().Hp);
                                        Enemysa.actives.Add(bbbbb.activeSelf);
                                        Enemysa.poss.Add(bbbbb.transform.position);
                                        Enemysa.rots.Add(bbbbb.transform.rotation);
                                        Enemysa.or_poses.Add(bbbbb.GetComponent<Enemymove>().or_pos);
                                    }
                                    enemysfff.Add(Enemysa);
                                }
                                else
                                {
                                    Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + thats.name);
                                    return 2;
                                }
                            }
                            if (gettype(aaaaaa[k].name) == "enemysolo")
                            {
                                EnemySolo enemysoloa = new EnemySolo();

                                enemysoloa.name = thats.name;
                                enemysoloa.pos = thats.transform.position;
                                enemysoloa.rot = thats.transform.rotation;

                                enemysoloa.or_pos = thats.GetComponent<Enemymove>().or_pos;
                                enemysoloa.Hp = thats.GetComponent<Enemymove>().Hp;
                                enemysoloa.isTeam = thats.GetComponent<Enemymove>().isPlayerTeam;
                                enemysoloa.DealItems = thats.GetComponent<Enemymove>().DealItemList;

                                enemysolosfff.Add(enemysoloa);
                            }
                            if (gettype(aaaaaa[k].name) == "NotEnemyEntity")
                            {

                                NotEnemyEntity NotEnemyEntitya = new NotEnemyEntity();
                                NotEnemyEntitya.name = thats.name;
                                NotEnemyEntitya.pos = thats.transform.position;
                                NotEnemyEntitya.rot = thats.transform.rotation;
                                if (thats.GetComponent<SangMul>())
                                {
                                    NotEnemyEntitya.Hp = thats.GetComponent<SangMul>().SangMul_Hp;
                                    NotEnemyEntitya.or_pos = thats.transform.position;
                                    NotEnemyEntityfff.Add(NotEnemyEntitya);
                                }
                                else if (thats.GetComponent<close_boss>())
                                {
                                    NotEnemyEntitya.Hp = thats.GetComponent<close_boss>().Hp;
                                    NotEnemyEntitya.or_pos = thats.GetComponent<close_boss>().or_pos;
                                    NotEnemyEntityfff.Add(NotEnemyEntitya);
                                }
                                else if (thats.GetComponent<long_boss>())
                                {
                                    NotEnemyEntitya.Hp = thats.GetComponent<long_boss>().Hp;
                                    NotEnemyEntitya.or_pos = thats.transform.position;
                                    NotEnemyEntityfff.Add(NotEnemyEntitya);
                                }
                                else if (thats.GetComponent<monsterscript>())
                                {
                                    NotEnemyEntitya.Hp = thats.GetComponent<monsterscript>().Hp;
                                    NotEnemyEntitya.or_pos = thats.transform.position;
                                    NotEnemyEntityfff.Add(NotEnemyEntitya);
                                }
                                else
                                {
                                    Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + thats.name);
                                    return 2;
                                }
                            }
                            if (gettype(aaaaaa[k].name) == "Item")
                            {
                                Items Itemsa = new Items() { }; // 이름, Hp, 위치, 방향
                                Itemsa.pos = thats.transform.position;
                                Itemsa.rot = thats.transform.rotation;
                                Itemsa.name = thats.name;

                                if (thats.GetComponent<NamuScript>())
                                {
                                    Itemsa.Hp = thats.GetComponent<NamuScript>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<DollScript>())
                                {
                                    Itemsa.Hp = thats.GetComponent<DollScript>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<ChulScript>())
                                {
                                    Itemsa.Hp = thats.GetComponent<ChulScript>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<GogiScript>())
                                {
                                    Itemsa.Hp = thats.GetComponent<GogiScript>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<DoguThrow>())
                                {
                                    Itemsa.Hp = thats.GetComponent<DoguThrow>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<ItemItemItemsss>())
                                {
                                    Itemsa.Hp = thats.GetComponent<ItemItemItemsss>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<HwalThrow>())
                                {
                                    Itemsa.Hp = thats.GetComponent<HwalThrow>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else if (thats.GetComponent<chonglitem>())
                                {
                                    Itemsa.Hp = thats.GetComponent<chonglitem>().Hp;
                                    Itemsfff.Add(Itemsa);
                                }
                                else
                                {
                                    Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + thats.name);
                                    return 2;
                                }
                            }

                            if (gettype(aaaaaa[k].name) == "Vehicle")
                            {
                                Vehicle Vehicleaa = new Vehicle();
                                Vehicleaa.name = thats.name;
                                Vehicleaa.pos = thats.transform.position;
                                Vehicleaa.rot = thats.transform.rotation;
                                if (thats.GetComponent<carmover>())
                                {
                                    SangJJasaveandload avdf = thats.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>();
                                    SangJJasaveandload avdfb = thats.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>();

                                    Sangja aaaaaaaaaaaaaaa = new Sangja();
                                    Sangja aaaaaaaaaaaaaab = new Sangja();

                                    aaaaaaaaaaaaaaa.item1 = avdf.Item1;
                                    aaaaaaaaaaaaaaa.item2 = avdf.Item2;
                                    aaaaaaaaaaaaaaa.num1 = avdf.num1;
                                    aaaaaaaaaaaaaaa.num2 = avdf.num2;

                                    aaaaaaaaaaaaaab.item1 = avdfb.Item1;
                                    aaaaaaaaaaaaaab.item2 = avdfb.Item2;
                                    aaaaaaaaaaaaaab.num1 = avdfb.num1;
                                    aaaaaaaaaaaaaab.num2 = avdfb.num2;

                                    Vehicleaa.sangjas.Add(aaaaaaaaaaaaaaa);
                                    Vehicleaa.sangjas.Add(aaaaaaaaaaaaaab);

                                    vehiclefff.Add(Vehicleaa);
                                }
                                else if (thats.GetComponent<BoatMover>())
                                {
                                    SangJJasaveandload avdf = thats.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>();

                                    Sangja aaaaaaaaaaaaaaa = new Sangja();

                                    aaaaaaaaaaaaaaa.item1 = avdf.Item1;
                                    aaaaaaaaaaaaaaa.item2 = avdf.Item2;
                                    aaaaaaaaaaaaaaa.num1 = avdf.num1;
                                    aaaaaaaaaaaaaaa.num2 = avdf.num2;

                                    Vehicleaa.sangjas.Add(aaaaaaaaaaaaaaa);

                                    vehiclefff.Add(Vehicleaa);
                                }
                                else if (thats.GetComponent<Helicopterscript>())
                                {
                                    SangJJasaveandload avdf = thats.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>();

                                    Sangja aaaaaaaaaaaaaaa = new Sangja();

                                    aaaaaaaaaaaaaaa.item1 = avdf.Item1;
                                    aaaaaaaaaaaaaaa.item2 = avdf.Item2;
                                    aaaaaaaaaaaaaaa.num1 = avdf.num1;
                                    aaaaaaaaaaaaaaa.num2 = avdf.num2;

                                    Vehicleaa.sangjas.Add(aaaaaaaaaaaaaaa);

                                    vehiclefff.Add(Vehicleaa);
                                }
                                else
                                {
                                    Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + thats.name);
                                    return 2;
                                }
                            }
                            featureMob.Add(aaaaaa[k]);
                        }

                        geteachotherclassbuddle aaaaaaaaclass = new geteachotherclassbuddle();
                        for (int k = 0; k < enemysfff.Count; k++)
                        {
                            aaaaaaaaclass.enemyclass.Add(enemysfff[k]);
                        }
                        //for (int k = 0; k < Itemsfff.Count; k++)
                        //{
                        //    aaaaaaaaclass.Itemsclass.Add(Itemsfff[k]);
                        //}

                        //for(int k = 0; k < that.GetComponent<base_house>().aaaaa.Count; k++)
                        //{
                        //    Items itemsad = new Items();
                        //    GameObject abcgdf = that.GetComponent<base_house>().aaaaa[k].aaa;
                        //    if (abcgdf.GetComponent<NamuScript>())
                        //    {
                        //        itemsad.Hp = abcgdf.GetComponent<NamuScript>().Hp;
                        //        featurea.namuanddolls.Add(itemsad);
                        //    }
                        //    if (abcgdf.GetComponent<DollScript>())
                        //    {
                        //        itemsad.Hp = abcgdf.GetComponent<DollScript>().Hp;
                        //        featurea.namuanddolls.Add(itemsad);
                        //    }
                        //    if (abcgdf.GetComponent<ChulScript>())
                        //    {
                        //        itemsad.Hp = abcgdf.GetComponent<ChulScript>().Hp;
                        //        featurea.namuanddolls.Add(itemsad);
                        //    }
                        //}

                        for (int k = 0; k < NotEnemyEntityfff.Count; k++)
                        {
                            aaaaaaaaclass.NotEnemyEntityclass.Add(NotEnemyEntityfff[k]);
                        }
                        for (int k = 0; k < vehiclefff.Count; k++)
                        {
                            aaaaaaaaclass.vehicleclass.Add(vehiclefff[k]);
                        }
                        for (int k = 0; k < enemysolosfff.Count; k++)
                        {
                            aaaaaaaaclass.enemysoloss.Add(enemysolosfff[k]);
                        }

                        //string abcde = JsonUtility.ToJson(aaaaaaaaclass);
                        //featurea.summondata = abcde;
                        featurea.summondata = aaaaaaaaclass;

                        List<GameObject> sangjassss = that.GetComponent<base_house>().sangjas;
                        for (int ki = 0; ki < sangjassss.Count; ki++)
                        {
                            featurea.amounts.Add(sangjassss[ki].GetComponent<SangJJasaveandload>().num1);
                            featurea.amounts.Add(sangjassss[ki].GetComponent<SangJJasaveandload>().num2);
                            featurea.Items.Add(sangjassss[ki].GetComponent<SangJJasaveandload>().Item1);
                            featurea.Items.Add(sangjassss[ki].GetComponent<SangJJasaveandload>().Item2);
                        }

                        for (int k = 0; k < that.GetComponent<base_house>().aaaaa.Count; k++)
                        {
                            Items adadadada = new Items()
                            {
                                name = that.GetComponent<base_house>().aaaaa[k].name,
                                Hp = that.GetComponent<base_house>().aaaaa[k].Hp,
                                pos = that.GetComponent<base_house>().aaaaa[k].aaa.transform.position,
                                rot = that.GetComponent<base_house>().aaaaa[k].aaa.transform.rotation
                            };
                            featurea.namuanddolls.Add(adadadada);
                        }

                        features.Add(featurea);
                    }
                }
                else if (that_item_type == "Enemy" && !featureMob.Contains(that))
                {
                    Enemys Enemysa = new Enemys();
                    Enemysa.name = that.name;
                    Enemysa.or_pos = that.transform.position;
                    Enemysa.or_rot = that.transform.rotation;
                    if (that.GetComponent<Enemyteammaneger>())
                    {
                        List<GameObject> enemysinthat = that.GetComponent<Enemyteammaneger>().enemys;
                        foreach (GameObject bbbbb in enemysinthat)
                        {
                            Enemysa.Hps.Add(bbbbb.GetComponent<Enemymove>().Hp);
                            Enemysa.actives.Add(bbbbb.activeSelf);
                            Enemysa.poss.Add(bbbbb.transform.position);
                            Enemysa.rots.Add(bbbbb.transform.rotation);
                            Enemysa.or_poses.Add(bbbbb.GetComponent<Enemymove>().or_pos);
                        }
                        Enemy.Add(Enemysa);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "NotEnemyEntity" && !featureMob.Contains(that))
                {
                    NotEnemyEntity NotEnemyEntitya = new NotEnemyEntity();
                    NotEnemyEntitya.name = that.name;
                    NotEnemyEntitya.pos = that.transform.position;
                    NotEnemyEntitya.rot = that.transform.rotation;
                    if (that.GetComponent<SangMul>())
                    {
                        NotEnemyEntitya.Hp = that.GetComponent<SangMul>().SangMul_Hp;
                        NotEnemyEntitya.or_pos = that.transform.position;
                        NotEnemyEntitys.Add(NotEnemyEntitya);
                    }
                    else if (that.GetComponent<close_boss>())
                    {
                        NotEnemyEntitya.Hp = that.GetComponent<close_boss>().Hp;
                        NotEnemyEntitya.or_pos = that.GetComponent<close_boss>().or_pos;
                        NotEnemyEntitys.Add(NotEnemyEntitya);
                    }
                    else if (that.GetComponent<long_boss>())
                    {
                        NotEnemyEntitya.Hp = that.GetComponent<long_boss>().Hp;
                        NotEnemyEntitya.or_pos = that.transform.position;
                        NotEnemyEntitys.Add(NotEnemyEntitya);
                    }
                    else if (that.GetComponent<monsterscript>())
                    {
                        NotEnemyEntitya.Hp = that.GetComponent<monsterscript>().Hp;
                        NotEnemyEntitya.or_pos = that.transform.position;
                        NotEnemyEntitys.Add(NotEnemyEntitya);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "Building")
                {
                    Building buildinga = new Building();
                    buildinga.name = that.name;
                    buildinga.pos = that.transform.position;
                    buildinga.rot = that.transform.rotation;
                    if (that.GetComponent<Buildingbreak>())
                    {
                        buildinga.Hp = that.GetComponent<Buildingbreak>().HP;
                        Buildings.Add(buildinga);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "finalboss")
                {
                    finalboss finalbossa = new finalboss();
                    if (that.GetComponent<final_boss>() && that.GetComponent<Buildingbreak>())
                    {
                        finalbossa.name = that.name;
                        finalbossa.killtime = that.GetComponent<final_boss>().killtime;
                        finalbossa.Hp = that.GetComponent<Buildingbreak>().HP;
                        finalbossa.pos = that.transform.position;
                        finalbossa.rot = that.transform.rotation;
                        finalbosses.Add(finalbossa);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "Sangja")
                {
                    Sangja sangjaa = new Sangja();
                    if(!that.GetComponent<SangJJasaveandload>() || !that.GetComponent<Buildingbreak>())
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                    sangjaa.name = "sangja";
                    sangjaa.pos = that.transform.position;
                    sangjaa.rot = that.transform.rotation;
                    sangjaa.item1 = that.GetComponent<SangJJasaveandload>().Item1;
                    sangjaa.item2 = that.GetComponent<SangJJasaveandload>().Item2;
                    sangjaa.num1 = that.GetComponent<SangJJasaveandload>().num1;
                    sangjaa.num2 = that.GetComponent<SangJJasaveandload>().num2;
                    sangjaa.Hp = that.GetComponent<Buildingbreak>().HP;
                    sangjaa.iscanbreak = that.GetComponent<SangJJasaveandload>().Isdontbreak;

                    Sangjas.Add(sangjaa);
                }
                else if (that_item_type == "yongwanglo")
                {
                    yongwanglo yongwangloa = new yongwanglo();
                    if (that.GetComponent<Yongwangd>() && that.GetComponent<Buildingbreak>())
                    {
                        yongwangloa.Hp = that.GetComponent<Buildingbreak>().HP;
                        yongwangloa.pos = that.transform.position;
                        yongwangloa.rot = that.transform.rotation;
                        yongwangloa.amount = that.GetComponent<Yongwangd>().yoyoyoyooyoyo;
                        yongwangloa.time = that.GetComponent<Yongwangd>().timelate;
                        yongwangloa.name = that.name;
                        yongwanglos.Add(yongwangloa);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "Vehicle" && !featureMob.Contains(that))
                {
                    Vehicle vehiclea = new Vehicle();
                    if (that.GetComponent<carmover>())
                    {
                        vehiclea.name = that.name;

                        GameObject sangja = that.GetComponent<carmover>().SangJa;
                        Sangja sangjaa = new Sangja();
                        if (!sangja.GetComponent<SangJJasaveandload>() || !sangja.GetComponent<Buildingbreak>())
                        {
                            Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + sangja.name);
                            return 2;
                        }
                        sangjaa.name = "sangja";
                        sangjaa.pos = sangja.transform.position;
                        sangjaa.rot = sangja.transform.rotation;
                        sangjaa.item1 = sangja.GetComponent<SangJJasaveandload>().Item1;
                        sangjaa.item2 = sangja.GetComponent<SangJJasaveandload>().Item2;
                        sangjaa.num1 = sangja.GetComponent<SangJJasaveandload>().num1;
                        sangjaa.num2 = sangja.GetComponent<SangJJasaveandload>().num2;
                        sangjaa.Hp = sangja.GetComponent<Buildingbreak>().HP;
                        sangjaa.iscanbreak = sangja.GetComponent<SangJJasaveandload>().Isdontbreak;
                        vehiclea.sangjas.Add(sangjaa);
                        GameObject sangja2 = that.GetComponent<carmover>().SangJacarrier;
                        if (!sangja2.GetComponent<SangJJasaveandload>() || !sangja2.GetComponent<Buildingbreak>())
                        {
                            Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + sangja2.name);
                            return 2;
                        }
                        sangjaa.name = "sangja";
                        sangjaa.pos = sangja2.transform.position;
                        sangjaa.rot = sangja2.transform.rotation;
                        sangjaa.item1 = sangja2.GetComponent<SangJJasaveandload>().Item1;
                        sangjaa.item2 = sangja2.GetComponent<SangJJasaveandload>().Item2;
                        sangjaa.num1 = sangja2.GetComponent<SangJJasaveandload>().num1;
                        sangjaa.num2 = sangja2.GetComponent<SangJJasaveandload>().num2;
                        sangjaa.Hp = sangja2.GetComponent<Buildingbreak>().HP;
                        sangjaa.iscanbreak = sangja2.GetComponent<SangJJasaveandload>().Isdontbreak;
                        vehiclea.sangjas.Add(sangjaa);

                        vehiclea.isgetin = that.GetComponent<getonVehicle>().Bool;
                        vehiclea.pos = that.transform.position;
                        vehiclea.rot = that.transform.rotation;
                        Vehicles.Add(vehiclea);
                    }
                    else if (that.GetComponent<BoatMover>())
                    {
                        vehiclea.name = that.name;

                        GameObject sangja = that.GetComponent<BoatMover>().SangJa;
                        Sangja sangjaa = new Sangja();
                        if (!sangja.GetComponent<SangJJasaveandload>() || !sangja.GetComponent<Buildingbreak>())
                        {
                            Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + sangja.name);
                            return 2;
                        }
                        sangjaa.name = "sangja";
                        sangjaa.pos = sangja.transform.position;
                        sangjaa.rot = sangja.transform.rotation;
                        sangjaa.item1 = sangja.GetComponent<SangJJasaveandload>().Item1;
                        sangjaa.item2 = sangja.GetComponent<SangJJasaveandload>().Item2;
                        sangjaa.num1 = sangja.GetComponent<SangJJasaveandload>().num1;
                        sangjaa.num2 = sangja.GetComponent<SangJJasaveandload>().num2;
                        sangjaa.Hp = sangja.GetComponent<Buildingbreak>().HP;
                        sangjaa.iscanbreak = sangja.GetComponent<SangJJasaveandload>().Isdontbreak;
                        vehiclea.sangjas.Add(sangjaa);

                        vehiclea.isgetin = that.GetComponent<getonVehicle>().Bool;
                        vehiclea.pos = that.transform.position;
                        vehiclea.rot = that.transform.rotation;
                        Vehicles.Add(vehiclea);
                    }
                    else if (that.GetComponent<Helicopterscript>())
                    {
                        vehiclea.name = that.name;

                        GameObject sangja = that.GetComponent<Helicopterscript>().SangJa;
                        Sangja sangjaa = new Sangja();
                        if (!sangja.GetComponent<SangJJasaveandload>() || !sangja.GetComponent<Buildingbreak>())
                        {
                            Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + sangja.name);
                            return 2;
                        }
                        sangjaa.name = "sangja";
                        sangjaa.pos = sangja.transform.position;
                        sangjaa.rot = sangja.transform.rotation;
                        sangjaa.item1 = sangja.GetComponent<SangJJasaveandload>().Item1;
                        sangjaa.item2 = sangja.GetComponent<SangJJasaveandload>().Item2;
                        sangjaa.num1 = sangja.GetComponent<SangJJasaveandload>().num1;
                        sangjaa.num2 = sangja.GetComponent<SangJJasaveandload>().num2;
                        sangjaa.Hp = sangja.GetComponent<Buildingbreak>().HP;
                        sangjaa.iscanbreak = sangja.GetComponent<SangJJasaveandload>().Isdontbreak;
                        vehiclea.sangjas.Add(sangjaa);

                        vehiclea.isgetin = that.GetComponent<getonVehicle>().Bool;
                        vehiclea.pos = that.transform.position;
                        vehiclea.rot = that.transform.rotation;
                        Vehicles.Add(vehiclea);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "tuchuck")
                {
                    tuchuck tuchucka = new tuchuck();
                    if (!that.GetComponent<Rigidbody>())
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                    tuchucka.name = that.name;
                    tuchucka.pos = that.transform.position;
                    tuchucka.rot = that.transform.rotation;
                    tuchucka.velocity = that.GetComponent<Rigidbody>().velocity;
                    if (that.GetComponent<HwaSalScript>())
                    {
                        tuchucka.killtime = that.GetComponent<HwaSalScript>().time;
                        tuchucks.Add(tuchucka);
                    }
                    else if (that.GetComponent<shongal_shouted>())
                    {
                        tuchucka.killtime = that.GetComponent<shongal_shouted>().time;
                        tuchucks.Add(tuchucka);
                    }
                    else if (that.GetComponent<C4tuchuck>())
                    {
                        tuchucks.Add(tuchucka);
                    }
                    else if (that.GetComponent<suryutangtuchuck>())
                    {
                        tuchucka.killtime = that.GetComponent<suryutangtuchuck>().time;
                        tuchucks.Add(tuchucka);
                    }
                    else
                    {
                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "house")
                {
                    house housea = new house();
                    housea.name = that.name;
                    housea.pos = that.transform.position;
                    housea.rot = that.transform.rotation;
                    houses.Add(housea);
                }
                else if (that_item_type == "jackmuls")
                {
                    jackmuls jackmulsa = new jackmuls();
                    jackmulsa.name = that.name;
                    jackmulsa.pos = that.transform.position;
                    jackmulsa.rot = that.transform.rotation;
                    if (that.GetComponent<JackMulscript>())
                    {
                        jackmulsa.timelate = that.GetComponent<JackMulscript>().time;
                        jackmul.Add(jackmulsa);
                    }
                    else if (that.GetComponent<Myomockscript>())
                    {
                        jackmulsa.timelate = that.GetComponent<Myomockscript>().time;
                        jackmul.Add(jackmulsa);
                    }
                    else
                    {

                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "justposandrot")
                {
                    justposandrot justposandrota = new justposandrot();
                    justposandrota.name = that.name;
                    justposandrota.pos = that.transform.position;
                    justposandrota.rot = that.transform.rotation;
                    justposandrots.Add(justposandrota);
                }
                else if (that_item_type == "paintbrush")
                {
                    paintbrush paintbrusha = new paintbrush();
                    paintbrusha.name = that.name;
                    paintbrusha.pos = that.transform.position;
                    paintbrusha.rot = that.transform.rotation;
                    if (that.GetComponent<Buildingbreak>() && that.GetComponent<paintbrushBuilding>())
                    {
                        paintbrusha.Hp = that.GetComponent<Buildingbreak>().HP;
                        paintbrusha.material = that.GetComponent<paintbrushBuilding>().thatcolor;
                        paintbrushs.Add(paintbrusha);
                    }
                    else
                    {

                        Debug.Log("있어야할 스크립트가 탐색되지 않습니다." + that.name);
                        return 2;
                    }
                }
                else if (that_item_type == "bundle")
                {
                    bundles bundlesa = new bundles();
                    bundlesa.name = that.name;
                    bundlesa.pos = that.transform.position;
                    bundlesa.rot = that.transform.rotation;

                    for(int j = 0; j < that.GetComponent<PlayerDiedMuckUm>().Items.Length; j++)
                    {
                        bundles.PlayerItem uaiau = new bundles.PlayerItem();
                        uaiau.name = that.GetComponent<PlayerDiedMuckUm>().Items[j];
                        uaiau.ammount = that.GetComponent<PlayerDiedMuckUm>().ItemAmount[j];

                        bundlesa.Items.Add(uaiau);
                    }

                    bundless.Add(bundlesa);
                }
                else if (that_item_type == "enemysolo" && !featureMob.Contains(that))
                {
                    EnemySolo enemysoloa = new EnemySolo();

                    enemysoloa.name = that.name;
                    enemysoloa.pos = that.transform.position;
                    enemysoloa.rot = that.transform.rotation;

                    enemysoloa.or_pos = that.GetComponent<Enemymove>().or_pos;
                    enemysoloa.Hp = that.GetComponent<Enemymove>().Hp;
                    enemysoloa.isTeam = that.GetComponent<Enemymove>().isPlayerTeam;

                    enemysoloa.DealItems = that.GetComponent<Enemymove>().DealItemList;

                    enemysolos.Add(enemysoloa);
                }
            }
            //데이터 클래스로 만들걸 Json string 으로 바꾸기
            geteachotherclassbuddle geteachotherclassbuddleaaab = new geteachotherclassbuddle();
            for(int i = 0; i < Item.Count; i++)
            {
                geteachotherclassbuddleaaab.Itemsclass.Add(Item[i]);
            }
            for (int i = 0; i < Enemy.Count; i++)
            {
                geteachotherclassbuddleaaab.enemyclass.Add(Enemy[i]);
            }
            for (int i = 0; i < NotEnemyEntitys.Count; i++)
            {
                geteachotherclassbuddleaaab.NotEnemyEntityclass.Add(NotEnemyEntitys[i]);
            }
            for (int i = 0; i < Buildings.Count; i++)
            {
                geteachotherclassbuddleaaab.Buildingclass.Add(Buildings[i]);
            }
            for (int i = 0; i < finalbosses.Count; i++)
            {
                geteachotherclassbuddleaaab.finalbossclass.Add(finalbosses[i]);
            }
            for (int i = 0; i < features.Count; i++)
            {
                geteachotherclassbuddleaaab.featureclass.Add(features[i]);
            }
            for (int i = 0; i < Sangjas.Count; i++)
            {
                geteachotherclassbuddleaaab.sangjaclass.Add(Sangjas[i]);
            }
            for (int i = 0; i < yongwanglos.Count; i++)
            {
                geteachotherclassbuddleaaab.yongwangloclass.Add(yongwanglos[i]);
            }
            for (int i = 0; i < Vehicles.Count; i++)
            {
                geteachotherclassbuddleaaab.vehicleclass.Add(Vehicles[i]);
            }
            for (int i = 0; i < tuchucks.Count; i++)
            {
                geteachotherclassbuddleaaab.tuchuckclass.Add(tuchucks[i]);
            }
            for (int i = 0; i < houses.Count; i++)
            {
                geteachotherclassbuddleaaab.houseclass.Add(houses[i]);
            }
            for (int i = 0; i < jackmul.Count; i++)
            {
                geteachotherclassbuddleaaab.jackmulsclass.Add(jackmul[i]);
            }
            for (int i = 0; i < justposandrots.Count; i++)
            {
                geteachotherclassbuddleaaab.justposandrotclass.Add(justposandrots[i]);
            }
            for (int i = 0; i < paintbrushs.Count; i++)
            {
                geteachotherclassbuddleaaab.paintbrushclass.Add(paintbrushs[i]);
            }
            for (int i = 0; i < bundless.Count; i++)
            {
                geteachotherclassbuddleaaab.bundlesss.Add(bundless[i]);
            }
            for (int i = 0; i < enemysolos.Count; i++)
            {
                geteachotherclassbuddleaaab.enemysoloss.Add(enemysolos[i]);
            }
            //string allitems = JsonUtility.ToJson(geteachotherclassbuddleaaab);
            //데이터 저장 그곳에 저장
            //saveclass.objects = allitems;
            saveclass.objects = geteachotherclassbuddleaaab;
            //플레이어 데이터도 저장
            saveclass.Playerdatas.Hp = Player.GetComponent<Player_Hp>().PlayerHp;
            saveclass.Playerdatas.hugi = Player.GetComponent<Player_Hp>().Hugi;
            saveclass.Playerdatas.pos = Player.transform.position;
            saveclass.Playerdatas.rot = Player.transform.rotation;
            saveclass.Playerdatas.name = "Player";
            saveclass.Playerdatas.energy = Player.GetComponent<PlayerMover>().energyTimelate;

            string[] Itemss = new string[14];
            int[] ItemAmount = new int[14];
            string[] InvenItems = new string[6];
            int[] InvenItemAmount = new int[6];

            Itemss[0] = Player.GetComponent<PlayerHand>().PickUp1;
            ItemAmount[0] = Player.GetComponent<PlayerHand>().Amount1;
            Itemss[1] = Player.GetComponent<PlayerHand>().PickUp2;
            ItemAmount[1] = Player.GetComponent<PlayerHand>().Amount2;
            Itemss[2] = Player.GetComponent<PlayerHand>().PickUp3;
            ItemAmount[2] = Player.GetComponent<PlayerHand>().Amount3;
            Itemss[3] = Player.GetComponent<PlayerHand>().PickUp4;
            ItemAmount[3] = Player.GetComponent<PlayerHand>().Amount4;
            Itemss[4] = Player.GetComponent<PlayerHand>().PickUp5;
            ItemAmount[4] = Player.GetComponent<PlayerHand>().Amount5;
            Itemss[5] = Player.GetComponent<PlayerHand>().PickUp6;
            ItemAmount[5] = Player.GetComponent<PlayerHand>().Amount6;
            Itemss[6] = Player.GetComponent<PlayerHand>().PickUp7;
            ItemAmount[6] = Player.GetComponent<PlayerHand>().Amount7;
            Itemss[7] = Player.GetComponent<PlayerHand>().PickUpF;
            ItemAmount[7] = Player.GetComponent<PlayerHand>().AmountF;

            InvenItems[0] = Inven.GetComponent<Invenmaniger>().items[0];
            InvenItemAmount[0] = Inven.GetComponent<Invenmaniger>().nums[0];
            InvenItems[1] = Inven.GetComponent<Invenmaniger>().items[1];
            InvenItemAmount[1] = Inven.GetComponent<Invenmaniger>().nums[1];
            InvenItems[2] = Inven.GetComponent<Invenmaniger>().items[2];
            InvenItemAmount[2] = Inven.GetComponent<Invenmaniger>().nums[2];
            InvenItems[3] = Inven.GetComponent<Invenmaniger>().items[3];
            InvenItemAmount[3] = Inven.GetComponent<Invenmaniger>().nums[3];
            InvenItems[4] = Inven.GetComponent<Invenmaniger>().items[4];
            InvenItemAmount[4] = Inven.GetComponent<Invenmaniger>().nums[4];
            InvenItems[5] = Inven.GetComponent<Invenmaniger>().items[5];
            InvenItemAmount[5] = Inven.GetComponent<Invenmaniger>().nums[5];

            for (int i = 8; i < Itemss.Length; i++)
            {
                Itemss[i] = InvenItems[i - 8];
                ItemAmount[i] = InvenItemAmount[i - 8];
            }

            for(int i = 0; i < Itemss.Length; i++)
            {
                saveclass.Playerdatas.Items.Add(new SaveClass.Playerclass.PlayerItem { ammount = ItemAmount[i], name = Itemss[i] });
            }

            saveclass.time = timemanager.times;
            saveclass.day = timemanager.days;

            saveclass.date = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            saveclass.datanamepp = name;

            for(int i = 0; i < jwapyomanager.jwapyonames.Count; i++)
            {
                Debug.Log(jwapyomanager.jwapyonames[i]);
                SaveClass.jwapyosdata ayatsyd = new SaveClass.jwapyosdata();
                ayatsyd.name = jwapyomanager.jwapyonames[i];
                ayatsyd.pos = jwapyomanager.jwapyodulpos[i];
                saveclass.jwapyosdataList.Add(ayatsyd);
            }

            GameTutorialManager Tutorialmanager =  GameObject.Find("GameTutorialManager").GetComponent<GameTutorialManager>();
            foreach (GameTutorialManager.Tutorial a in Tutorialmanager.showedTutorial)
            {
                saveclass.ShowedTutorials.Add(a.name);
            }
            saveclass.TutorialFlowNum = Tutorialmanager.TutorialFlowNum;

            //마지막으로 위 데이터 저장한 클래스를 Json string 으로 변환한후 변수에 할당

            string finalsaves = JsonUtility.ToJson(saveclass, true);

            //그 변수를 파일경로에 파일 생성 후 쓰고 닫기

            File.WriteAllText(path, finalsaves);
            PlayerPrefs.SetString("countinuePath", path);
            Debug.Log("저장 성공!");
            return 0;
        }
    }
    List<GameObject> instated_objects = new List<GameObject>();
    public int Load(string savedfile)
    {
        instated_objects = new List<GameObject>() { };
        Player = GameObject.Find("Player");
        Inven = GameObject.Find("Inventory");
        GameObjectPool game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        string datastring = File.ReadAllText(savedfile);

        //geteachotherclassbuddle thatdata = JsonUtility.FromJson<geteachotherclassbuddle>(datastring);
        SaveClass thatsaveclass = JsonUtility.FromJson<SaveClass>(datastring);
        geteachotherclassbuddle thatdata = thatsaveclass.objects;

        foreach (Items a in thatdata.Itemsclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<NamuScript>())
            {
                that.GetComponent<NamuScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<DollScript>())
            {
                that.GetComponent<DollScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<ChulScript>())
            {
                that.GetComponent<ChulScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<GogiScript>())
            {
                that.GetComponent<GogiScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<DoguThrow>())
            {
                that.GetComponent<DoguThrow>().Hp = a.Hp;
            }
            else if (that.GetComponent<ItemItemItemsss>())
            {
                that.GetComponent<ItemItemItemsss>().Hp = a.Hp;
            }
            else if (that.GetComponent<HwalThrow>())
            {
                that.GetComponent<HwalThrow>().Hp = a.Hp;
            }
            else if (that.GetComponent<chonglitem>())
            {
                that.GetComponent<tangsave>().tang = a.Hp - 1;
            }
        }
        foreach(Enemys a in thatdata.enemyclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.or_pos, a.or_rot);
            instated_objects.Add(that);
            List<GameObject> enemysinthat = that.GetComponent<Enemyteammaneger>().enemys;
            for (int i = 0; i < a.or_poses.Count; i++)
            {
                enemysinthat[i].GetComponent<Enemymove>().Hp = a.Hps[i];
                enemysinthat[i].GetComponent<Enemymove>().or_pos = a.or_poses[i];
                enemysinthat[i].transform.position = a.poss[i];
                enemysinthat[i].transform.rotation = a.rots[i];
                enemysinthat[i].SetActive(a.actives[i]);
            }
        }
        foreach(NotEnemyEntity a in thatdata.NotEnemyEntityclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<SangMul>())
            {
                that.GetComponent<SangMul>().SangMul_Hp = a.Hp;
            }
            else if (that.GetComponent<close_boss>())
            {
                that.GetComponent<close_boss>().Hp = a.Hp;
            }
            else if (that.GetComponent<long_boss>())
            {
                that.GetComponent<long_boss>().Hp = a.Hp;
            }
            else if (that.GetComponent<monsterscript>())
            {
                that.GetComponent<monsterscript>().Hp = a.Hp;
            }
        }
        foreach(Building a in thatdata.Buildingclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
        }
        foreach (finalboss a in thatdata.finalbossclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<final_boss>().killtime = a.killtime;
        }
        foreach (Vehicle a in thatdata.vehicleclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<carmover>())
            {
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[1].item1;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[1].item2;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num1 = a.sangjas[1].num1;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num2 = a.sangjas[1].num2;
            }
            else if (that.GetComponent<BoatMover>())
            {
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
            }
            else if (that.GetComponent<Helicopterscript>())
            {
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
            }
        }
        foreach (feature a in thatdata.featureclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            geteachotherclassbuddle aaaaaaaaa = a.summondata;
            foreach(Enemys baba in aaaaaaaaa.enemyclass)
            {
                for(int l = 0; l < instated_objects.Count; l++)
                {
                    if (!instated_objects[l].GetComponent<Enemyteammaneger>())
                    {
                        continue;
                    }
                    if (instated_objects[l].GetComponent<Enemyteammaneger>().transform.position == baba.or_pos)
                    {
                        for (int j = 0; j < baba.or_poses.Count; j++)
                        {
                            GameObject aabcfgdhj = instated_objects[l].GetComponent<Enemyteammaneger>().enemys[j];
                            //aabcfgdhj.GetComponent<Enemymove>().Hp = baba.Hps[j];
                            //aabcfgdhj.GetComponent<Enemymove>().or_pos = baba.or_poses[j];
                            //aabcfgdhj.transform.position = baba.poss[j];
                            //aabcfgdhj.transform.rotation = baba.rots[j];
                            //aabcfgdhj.SetActive(baba.actives[j]);
                        }
                        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                        goto breaks;
                    }
                }
                var thata = game_object_pool.MustInstitateObject(baba.name, baba.or_pos, baba.or_rot);
                instated_objects.Add(thata);
                List<GameObject> enemysinthat = that.GetComponent<Enemyteammaneger>().enemys;
                for (int i = 0; i < baba.or_poses.Count; i++)
                {
                    enemysinthat[i].GetComponent<Enemymove>().Hp = baba.Hps[i];
                    enemysinthat[i].GetComponent<Enemymove>().or_pos = baba.or_poses[i];
                    enemysinthat[i].transform.position = baba.poss[i];
                    enemysinthat[i].transform.rotation = baba.rots[i];
                    enemysinthat[i].SetActive(baba.actives[i]);
                }
                that.GetComponent<base_house>().enemyspone.Add(thata);

                breaks:
                    continue;
            }
            foreach(NotEnemyEntity baba in aaaaaaaaa.NotEnemyEntityclass)
            {
                if (baba.name == "close_boss")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<close_boss>())
                        {
                            continue;
                        }
                        if (instated_objects[l].GetComponent<close_boss>().or_pos == baba.or_pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<close_boss>())
                    {
                        that.GetComponent<close_boss>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "long_boss")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<base_house>())
                        {
                            continue;
                        }
                        if (instated_objects[l].transform.position == baba.or_pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<long_boss>())
                    {
                        that.GetComponent<long_boss>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "big_monster")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<monsterscript>())
                        {
                            continue;
                        }
                        if (instated_objects[l].transform.position == baba.or_pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<monsterscript>())
                    {
                        that.GetComponent<monsterscript>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "sangmul" || baba.name == "sangmul_domesticated")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<SangMul>())
                        {
                            continue;
                        }
                        if (instated_objects[l].transform.position == baba.or_pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<SangMul>())
                    {
                        that.GetComponent<SangMul>().SangMul_Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }

                breaks:
                    continue;

            }
            for(int k = 0; k < a.namuanddolls.Count; k++)
            {
                that.GetComponent<base_house>().aaaaa[k].Hp = a.namuanddolls[k].Hp;
            }
            List<GameObject> snagjass = that.GetComponent<base_house>().sangjas;
            for(int k = 0; k < snagjass.Count; k++)
            {
                snagjass[k].GetComponent<SangJJasaveandload>().Item1 = a.Items[k];
                snagjass[k].GetComponent<SangJJasaveandload>().Item2 = a.Items[k + 1];
                snagjass[k].GetComponent<SangJJasaveandload>().num1 = a.amounts[k];
                snagjass[k].GetComponent<SangJJasaveandload>().num2 = a.amounts[k + 1];
            }
            that.GetComponent<base_house>().time[0] = a.times[0];
            that.GetComponent<base_house>().time[1] = a.times[1];
            that.GetComponent<base_house>().time[2] = a.times[2];
            foreach(Vehicle baba in aaaaaaaaa.vehicleclass)
            {
                if (baba.name == "Car")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<carmover>())
                        {
                            continue;
                        }
                        if (instated_objects[l].GetComponent<carmover>().transform.position == baba.pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<carmover>())
                    {
                        that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                        that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[1].item1;
                        that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[1].item2;
                        that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[1].num1;
                        that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[1].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "Boat")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<BoatMover>())
                        {
                            continue;
                        }
                        if (instated_objects[l].GetComponent<BoatMover>().transform.position == baba.pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<BoatMover>())
                    {
                        that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "Helicopter")
                {
                    for (int l = 0; l < instated_objects.Count; l++)
                    {
                        if (!instated_objects[l].GetComponent<Helicopterscript>())
                        {
                            continue;
                        }
                        if (instated_objects[l].GetComponent<Helicopterscript>().transform.position == baba.pos)
                        {
                            that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                            goto breaks;
                        }
                    }
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(that);
                    if (that.GetComponent<Helicopterscript>())
                    {
                        that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }

                breaks:
                    continue;
            }
        }
        foreach(Sangja a in thatdata.sangjaclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<SangJJasaveandload>().Item1 = a.item1;
            that.GetComponent<SangJJasaveandload>().Item2 = a.item2;
            that.GetComponent<SangJJasaveandload>().num1 = a.num1;
            that.GetComponent<SangJJasaveandload>().num2 = a.num2;
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<SangJJasaveandload>().Isdontbreak = a.iscanbreak;

        }
        foreach(yongwanglo a in thatdata.yongwangloclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<Yongwangd>().timelate = a.time;
            that.GetComponent<Yongwangd>().yoyoyoyooyoyo = a.amount;
        }
        foreach(tuchuck a in thatdata.tuchuckclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            if (that.GetComponent<C4tuchuck>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
            }
            else if (that.GetComponent<suryutangtuchuck>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<suryutangtuchuck>().time = a.killtime;
            }
            else if (that.GetComponent<HwaSalScript>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<HwaSalScript>().time = a.killtime;
            }
            else if (that.GetComponent<shongal_shouted>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<shongal_shouted>().time = a.killtime;
            }
        }
        foreach(house a in thatdata.houseclass)
        {
            game_object_pool.Instantiates(a.name, a.pos, a.rot);
        }
        foreach(jackmuls a in thatdata.jackmulsclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<JackMulscript>().time = a.timelate;
        }
        foreach(paintbrush a in thatdata.paintbrushclass)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<paintbrushBuilding>().ChangeColor(a.material);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
        }
        foreach (justposandrot a in thatdata.justposandrotclass)
        {
            game_object_pool.Instantiates(a.name, a.pos, a.rot);
        }
        foreach (bundles a in thatdata.bundlesss)
        {
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);

            PlayerDiedMuckUm abdbabd = that.GetComponent<PlayerDiedMuckUm>();

            for(int j = 0; j < a.Items.Count; j++)
            {
                abdbabd.Items[j] = a.Items[j].name;
                abdbabd.ItemAmount[j] = a.Items[j].ammount;
            }
        }

        SaveClass.Playerclass playerdata = thatsaveclass.Playerdatas;

        Player.GetComponent<PlayerHand>().PickUp1 = playerdata.Items[0].name;
        Player.GetComponent<PlayerHand>().Amount1 = playerdata.Items[0].ammount;
        Player.GetComponent<PlayerHand>().PickUp2 = playerdata.Items[1].name;
        Player.GetComponent<PlayerHand>().Amount2 = playerdata.Items[1].ammount;
        Player.GetComponent<PlayerHand>().PickUp3 = playerdata.Items[2].name;
        Player.GetComponent<PlayerHand>().Amount3 = playerdata.Items[2].ammount;
        Player.GetComponent<PlayerHand>().PickUp4 = playerdata.Items[3].name;
        Player.GetComponent<PlayerHand>().Amount4 = playerdata.Items[3].ammount;
        Player.GetComponent<PlayerHand>().PickUp5 = playerdata.Items[4].name;
        Player.GetComponent<PlayerHand>().Amount5 = playerdata.Items[4].ammount;
        Player.GetComponent<PlayerHand>().PickUp6 = playerdata.Items[5].name;
        Player.GetComponent<PlayerHand>().Amount6 = playerdata.Items[5].ammount;
        Player.GetComponent<PlayerHand>().PickUp7 = playerdata.Items[6].name;
        Player.GetComponent<PlayerHand>().Amount7 = playerdata.Items[6].ammount;
        Player.GetComponent<PlayerHand>().PickUpF = playerdata.Items[7].name;
        Player.GetComponent<PlayerHand>().AmountF = playerdata.Items[7].ammount;
        for(int o = 0; o < Inven.GetComponent<Invenmaniger>().items.Length; o++)
        {
            Inven.GetComponent<Invenmaniger>().items[o] = playerdata.Items[8 + o].name;
            Inven.GetComponent<Invenmaniger>().nums[o] = playerdata.Items[8 + o].ammount;
        }
        Player.transform.position = playerdata.pos;
        Player.transform.rotation = playerdata.rot;
        Player.GetComponent<Player_Hp>().PlayerHp = playerdata.Hp;
        Player.GetComponent<Player_Hp>().Hugi = playerdata.hugi;
        Player.GetComponent<PlayerMover>().energyTimelate = playerdata.energy;

        List<SaveClass.jwapyosdata> jwapyosdatasss = thatsaveclass.jwapyosdataList;
        for(int o = 0; o < jwapyosdatasss.Count; o++)
        {
            jwapyomanager.LoadJwapyo(jwapyosdatasss[o].pos, jwapyosdatasss[o].name);
        }

        timemanager.time = thatsaveclass.time;
        timemanager.days = thatsaveclass.day;

        Debug.Log("로드 성공!");
        return 0;
    }

    public IEnumerator LoadCo(string savedfile)
    {
        instated_objects = new List<GameObject>() { };
        Player = GameObject.Find("Player");
        Inven = GameObject.Find("Inventory");
        GameObjectPool game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        string datastring = File.ReadAllText(savedfile);
        //geteachotherclassbuddle thatdata = JsonUtility.FromJson<geteachotherclassbuddle>(datastring);
        SaveClass thatsaveclass = JsonUtility.FromJson<SaveClass>(datastring);
        geteachotherclassbuddle thatdata = thatsaveclass.objects;

        loadingmaxpercentage += thatdata.Itemsclass.Count;
        loadingmaxpercentage += thatdata.enemyclass.Count;
        loadingmaxpercentage += thatdata.enemysoloss.Count;
        loadingmaxpercentage += thatdata.NotEnemyEntityclass.Count;
        loadingmaxpercentage += thatdata.Buildingclass.Count;
        loadingmaxpercentage += thatdata.finalbossclass.Count;
        loadingmaxpercentage += thatdata.vehicleclass.Count;
        loadingmaxpercentage += thatdata.featureclass.Count;
        loadingmaxpercentage += thatdata.sangjaclass.Count;
        loadingmaxpercentage += thatdata.yongwangloclass.Count;
        loadingmaxpercentage += thatdata.tuchuckclass.Count;
        loadingmaxpercentage += thatdata.houseclass.Count;
        loadingmaxpercentage += thatdata.jackmulsclass.Count;
        loadingmaxpercentage += thatdata.paintbrushclass.Count;
        loadingmaxpercentage += thatdata.justposandrotclass.Count;
        loadingmaxpercentage += thatdata.bundlesss.Count;
        loadingmaxpercentage += 1;

        int aaaaaadadadadad = 0;
        foreach (Items a in thatdata.Itemsclass)
        {
            percentage++;
            aaaaaadadadadad += 1;
            if (aaaaaadadadadad > 100)
            {
                yield return null;
                aaaaaadadadadad = 0;
            }
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<NamuScript>())
            {
                that.GetComponent<NamuScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<DollScript>())
            {
                that.GetComponent<DollScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<ChulScript>())
            {
                that.GetComponent<ChulScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<GogiScript>())
            {
                that.GetComponent<GogiScript>().Hp = a.Hp;
            }
            else if (that.GetComponent<DoguThrow>())
            {
                that.GetComponent<DoguThrow>().Hp = a.Hp;
            }
            else if (that.GetComponent<ItemItemItemsss>())
            {
                that.GetComponent<ItemItemItemsss>().Hp = a.Hp;
            }
            else if (that.GetComponent<HwalThrow>())
            {
                that.GetComponent<HwalThrow>().Hp = a.Hp;
            }
            else if (that.GetComponent<chonglitem>())
            {
                that.GetComponent<tangsave>().tang = a.Hp - 1;
            }
        }
        Debug.Log("Items Clear!");
        foreach (Enemys a in thatdata.enemyclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.or_pos, a.or_rot);
            instated_objects.Add(that);
            List<GameObject> enemysinthat = that.GetComponent<Enemyteammaneger>().enemys;
            for (int i = 0; i < a.or_poses.Count; i++)
            {
                enemysinthat[i].GetComponent<Enemymove>().Hp = a.Hps[i];
                enemysinthat[i].GetComponent<Enemymove>().or_pos = a.or_poses[i];
                enemysinthat[i].transform.position = a.poss[i];
                enemysinthat[i].transform.rotation = a.rots[i];
                enemysinthat[i].SetActive(a.actives[i]);
            }
            yield return null;
        }
        Debug.Log("Enemys Clear!");

        foreach (EnemySolo a in thatdata.enemysoloss)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            that.GetComponent<Enemymove>().Hp = a.Hp;
            that.GetComponent<Enemymove>().or_pos = a.or_pos;
            that.GetComponent<Enemymove>().isPlayerTeam = a.isTeam;
            that.GetComponent<Enemymove>().DealItemList = a.DealItems;

            yield return null;
        }
        Debug.Log("EnemySolos Clear!");
        foreach (NotEnemyEntity a in thatdata.NotEnemyEntityclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<SangMul>())
            {
                that.GetComponent<SangMul>().SangMul_Hp = a.Hp;
            }
            else if (that.GetComponent<close_boss>())
            {
                that.GetComponent<close_boss>().Hp = a.Hp;
            }
            else if (that.GetComponent<long_boss>())
            {
                that.GetComponent<long_boss>().Hp = a.Hp;
            }
            else if (that.GetComponent<monsterscript>())
            {
                that.GetComponent<monsterscript>().Hp = a.Hp;
            }
            yield return null;
        }
        Debug.Log("NotEnemyEntity Clear!");
        foreach (Building a in thatdata.Buildingclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            yield return null;
        }
        Debug.Log("Building Clear!");
        foreach (finalboss a in thatdata.finalbossclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<final_boss>().killtime = a.killtime;
            yield return null;
        }
        Debug.Log("finalboss Clear!");
        foreach (Vehicle a in thatdata.vehicleclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            if (that.GetComponent<carmover>())
            {
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[1].item1;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[1].item2;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num1 = a.sangjas[1].num1;
                that.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num2 = a.sangjas[1].num2;
                that.GetComponent<getonVehicle>().Bool = a.isgetin;
            }
            else if (that.GetComponent<BoatMover>())
            {
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
                that.GetComponent<getonVehicle>().Bool = a.isgetin;
            }
            else if (that.GetComponent<Helicopterscript>())
            {
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item1 = a.sangjas[0].item1;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item2 = a.sangjas[0].item2;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num1 = a.sangjas[0].num1;
                that.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num2 = a.sangjas[0].num2;
                that.GetComponent<getonVehicle>().Bool = a.isgetin;
            }
            yield return null;
        }
        Debug.Log("Vehicle Clear!");
        foreach (feature a in thatdata.featureclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            instated_objects.Add(that);
            geteachotherclassbuddle aaaaaaaaa = a.summondata;
            foreach (Enemys baba in aaaaaaaaa.enemyclass)
            {
                //for (int l = 0; l < instated_objects.Count; l++)
                //{
                //    if (!instated_objects[l].GetComponent<Enemyteammaneger>())
                //    {
                //        continue;
                //    }
                //    if (instated_objects[l].GetComponent<Enemyteammaneger>().transform.position == baba.or_pos)
                //    {
                //        for (int j = 0; j < baba.or_poses.Count; j++)
                //        {
                //            GameObject aabcfgdhj = instated_objects[l].GetComponent<Enemyteammaneger>().enemys[j];
                //            //aabcfgdhj.GetComponent<Enemymove>().Hp = baba.Hps[j];
                //            //aabcfgdhj.GetComponent<Enemymove>().or_pos = baba.or_poses[j];
                //            //aabcfgdhj.transform.position = baba.poss[j];
                //            //aabcfgdhj.transform.rotation = baba.rots[j];
                //            //aabcfgdhj.SetActive(baba.actives[j]);
                //        }
                //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                //        goto breaks;
                //    }
                //}
                var thata = game_object_pool.MustInstitateObject(baba.name, baba.or_pos, baba.or_rot);
                instated_objects.Add(thata);
                List<GameObject> enemysinthat = thata.GetComponent<Enemyteammaneger>().enemys;
                for (int i = 0; i < baba.or_poses.Count; i++)
                {
                    enemysinthat[i].GetComponent<Enemymove>().Hp = baba.Hps[i];
                    enemysinthat[i].GetComponent<Enemymove>().or_pos = baba.or_poses[i];
                    enemysinthat[i].transform.position = baba.poss[i];
                    enemysinthat[i].transform.rotation = baba.rots[i];
                    enemysinthat[i].SetActive(baba.actives[i]);
                }
                that.GetComponent<base_house>().enemyspone.Add(thata);

            //breaks:
            //    continue;
            }
            foreach (NotEnemyEntity baba in aaaaaaaaa.NotEnemyEntityclass)
            {
                if (baba.name == "close_boss")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<close_boss>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].GetComponent<close_boss>().or_pos == baba.or_pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<close_boss>())
                    {
                        thats.GetComponent<close_boss>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "long_boss")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<base_house>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].transform.position == baba.or_pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<long_boss>())
                    {
                        thats.GetComponent<long_boss>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "big_monster")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<monsterscript>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].transform.position == baba.or_pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<monsterscript>())
                    {
                        thats.GetComponent<monsterscript>().Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "sangmul" || baba.name == "sangmul_domesticated")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<SangMul>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].transform.position == baba.or_pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<SangMul>())
                    {
                        thats.GetComponent<SangMul>().SangMul_Hp = baba.Hp;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }

            //breaks:
            //    continue;

            }
            for (int k = 0; k < a.namuanddolls.Count; k++)
            {
                that.GetComponent<base_house>().aaaaa[k].Hp = a.namuanddolls[k].Hp;
            }
            List<GameObject> snagjass = that.GetComponent<base_house>().sangjas;
            for (int k = 0; k < snagjass.Count; k++)
            {
                snagjass[k].GetComponent<SangJJasaveandload>().Item1 = a.Items[k];
                snagjass[k].GetComponent<SangJJasaveandload>().Item2 = a.Items[k + 1];
                snagjass[k].GetComponent<SangJJasaveandload>().num1 = a.amounts[k];
                snagjass[k].GetComponent<SangJJasaveandload>().num2 = a.amounts[k + 1];
            }
            that.GetComponent<base_house>().time[0] = a.times[0];
            that.GetComponent<base_house>().time[1] = a.times[1];
            that.GetComponent<base_house>().time[2] = a.times[2];
            foreach (Vehicle baba in aaaaaaaaa.vehicleclass)
            {
                if (baba.name == "Car")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<carmover>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].GetComponent<carmover>().transform.position == baba.pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<carmover>())
                    {
                        thats.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        thats.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        thats.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        thats.GetComponent<carmover>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                        thats.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[1].item1;
                        thats.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[1].item2;
                        thats.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[1].num1;
                        thats.GetComponent<carmover>().SangJacarrier.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[1].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "Boat")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<BoatMover>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].GetComponent<BoatMover>().transform.position == baba.pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<BoatMover>())
                    {
                        thats.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        thats.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        thats.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        thats.GetComponent<BoatMover>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }
                else if (baba.name == "Helicopter")
                {
                    //for (int l = 0; l < instated_objects.Count; l++)
                    //{
                    //    if (!instated_objects[l].GetComponent<Helicopterscript>())
                    //    {
                    //        continue;
                    //    }
                    //    if (instated_objects[l].GetComponent<Helicopterscript>().transform.position == baba.pos)
                    //    {
                    //        that.GetComponent<base_house>().enemyspone.Add(instated_objects[l]);
                    //        goto breaks;
                    //    }
                    //}
                    var thats = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                    instated_objects.Add(thats);
                    if (thats.GetComponent<Helicopterscript>())
                    {
                        thats.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item1 = baba.sangjas[0].item1;
                        thats.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().Item2 = baba.sangjas[0].item2;
                        thats.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num1 = baba.sangjas[0].num1;
                        thats.GetComponent<Helicopterscript>().SangJa.GetComponent<SangJJasaveandload>().num2 = baba.sangjas[0].num2;
                    }
                    that.GetComponent<base_house>().enemyspone.Add(thats);
                }

            //breaks:
            //    continue;
            }
            foreach(EnemySolo baba in aaaaaaaaa.enemysoloss)
            {
                var thata = game_object_pool.MustInstitateObject(baba.name, baba.pos, baba.rot);
                instated_objects.Add(thata);
                thata.GetComponent<Enemymove>().Hp = baba.Hp;
                thata.GetComponent<Enemymove>().or_pos = baba.or_pos;
                thata.GetComponent<Enemymove>().isPlayerTeam = baba.isTeam;
                thata.GetComponent<Enemymove>().DealItemList = baba.DealItems;

                that.GetComponent<base_house>().enemyspone.Add(thata);
            }
            yield return null;
        }
        Debug.Log("feature Clear!");
        foreach (Sangja a in thatdata.sangjaclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<SangJJasaveandload>().Item1 = a.item1;
            that.GetComponent<SangJJasaveandload>().Item2 = a.item2;
            that.GetComponent<SangJJasaveandload>().num1 = a.num1;
            that.GetComponent<SangJJasaveandload>().num2 = a.num2;
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<SangJJasaveandload>().Isdontbreak = a.iscanbreak;
            yield return null;

        }
        Debug.Log("Sangja Clear!");
        foreach (yongwanglo a in thatdata.yongwangloclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            that.GetComponent<Yongwangd>().timelate = a.time;
            that.GetComponent<Yongwangd>().yoyoyoyooyoyo = a.amount;
            yield return null;
        }
        Debug.Log("yongwanglo Clear!");
        foreach (tuchuck a in thatdata.tuchuckclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            if (that.GetComponent<C4tuchuck>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
            }
            else if (that.GetComponent<suryutangtuchuck>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<suryutangtuchuck>().time = a.killtime;
            }
            else if (that.GetComponent<HwaSalScript>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<HwaSalScript>().time = a.killtime;
            }
            else if (that.GetComponent<shongal_shouted>())
            {
                that.GetComponent<Rigidbody>().velocity = a.velocity;
                that.GetComponent<shongal_shouted>().time = a.killtime;
            }
            yield return null;
        }
        Debug.Log("tuchuck Clear!");
        foreach (house a in thatdata.houseclass)
        {
            percentage++;
            game_object_pool.Instantiates(a.name, a.pos, a.rot);
            yield return null;
        }
        Debug.Log("house Clear!");
        foreach (jackmuls a in thatdata.jackmulsclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<JackMulscript>().time = a.timelate;
            yield return null;
        }
        Debug.Log("jackmuls Clear!");
        foreach (paintbrush a in thatdata.paintbrushclass)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);
            that.GetComponent<paintbrushBuilding>().ChangeColor(a.material);
            that.GetComponent<Buildingbreak>().HP = a.Hp;
            yield return null;
        }
        Debug.Log("paintbrush Clear!");
        foreach (justposandrot a in thatdata.justposandrotclass)
        {
            percentage++;
            game_object_pool.Instantiates(a.name, a.pos, a.rot);
            yield return null;
        }
        Debug.Log("justposandrot Clear!");
        foreach (bundles a in thatdata.bundlesss)
        {
            percentage++;
            var that = game_object_pool.MustInstitateObject(a.name, a.pos, a.rot);

            PlayerDiedMuckUm abdbabd = that.GetComponent<PlayerDiedMuckUm>();

            for (int j = 0; j < a.Items.Count; j++)
            {
                abdbabd.Items[j] = a.Items[j].name;
                abdbabd.ItemAmount[j] = a.Items[j].ammount;
            }
            yield return null;
        }
        Debug.Log("bundles Clear!");

        SaveClass.Playerclass playerdata = thatsaveclass.Playerdatas;
        Player.GetComponent<PlayerHand>().PickUp1 = playerdata.Items[0].name;
        Player.GetComponent<PlayerHand>().Amount1 = playerdata.Items[0].ammount;
        Player.GetComponent<PlayerHand>().PickUp2 = playerdata.Items[1].name;
        Player.GetComponent<PlayerHand>().Amount2 = playerdata.Items[1].ammount;
        Player.GetComponent<PlayerHand>().PickUp3 = playerdata.Items[2].name;
        Player.GetComponent<PlayerHand>().Amount3 = playerdata.Items[2].ammount;
        Player.GetComponent<PlayerHand>().PickUp4 = playerdata.Items[3].name;
        Player.GetComponent<PlayerHand>().Amount4 = playerdata.Items[3].ammount;
        Player.GetComponent<PlayerHand>().PickUp5 = playerdata.Items[4].name;
        Player.GetComponent<PlayerHand>().Amount5 = playerdata.Items[4].ammount;
        Player.GetComponent<PlayerHand>().PickUp6 = playerdata.Items[5].name;
        Player.GetComponent<PlayerHand>().Amount6 = playerdata.Items[5].ammount;
        Player.GetComponent<PlayerHand>().PickUp7 = playerdata.Items[6].name;
        Player.GetComponent<PlayerHand>().Amount7 = playerdata.Items[6].ammount;
        Player.GetComponent<PlayerHand>().PickUpF = playerdata.Items[7].name;
        Player.GetComponent<PlayerHand>().AmountF = playerdata.Items[7].ammount;
        percentage++;
        for (int o = 0; o < Inven.GetComponent<Invenmaniger>().items.Length; o++)
        {
            Inven.GetComponent<Invenmaniger>().items[o] = playerdata.Items[8 + o].name;
            Inven.GetComponent<Invenmaniger>().nums[o] = playerdata.Items[8 + o].ammount;
        }
        Player.transform.position = playerdata.pos;
        Player.transform.rotation = playerdata.rot;
        Player.GetComponent<Player_Hp>().PlayerHp = playerdata.Hp;
        Player.GetComponent<Player_Hp>().Hugi = playerdata.hugi;
        Player.GetComponent<PlayerMover>().energyTimelate = playerdata.energy;
        List<SaveClass.jwapyosdata> jwapyosdatasss = thatsaveclass.jwapyosdataList;
        for (int o = 0; o < jwapyosdatasss.Count; o++)
        {
            jwapyomanager.LoadJwapyo(jwapyosdatasss[o].pos, jwapyosdatasss[o].name);
        }
        timemanager.times = thatsaveclass.time;
        timemanager.days = thatsaveclass.day;

        GameTutorialManager Tutorialmanager = GameObject.Find("GameTutorialManager").GetComponent<GameTutorialManager>();
        foreach (GameTutorialManager.Tutorial a in Tutorialmanager.Turorials)
        {
            foreach(string b in thatsaveclass.ShowedTutorials)
            {
                if(a.name == b)
                {
                    Tutorialmanager.showedTutorial.Add(a);
                }
            }
        }
        Tutorialmanager.TutorialFlowNum = thatsaveclass.TutorialFlowNum;

        //게임시작을 위한 스크립트활성화
        //List<GameObject> institatiedObjects = new List<GameObject>();
        //foreach(GameObjectPool.Objects gogogogo in game_object_pool.Object)
        //{
        //    foreach (GameObject yyyyydayd in gogogogo.ObjectItem)
        //    {
        //        institatiedObjects.Add(yyyyydayd);
        //    }
        //}
        //foreach(GameObject saopdoinmf in institatiedObjects)
        //{
        //    if (saopdoinmf.GetComponent<object_Manager>())
        //    {
        //        saopdoinmf.GetComponent<object_Manager>().OpenComponent();
        //    }
        //}

        Debug.Log("로드 성공!");
        PlayerPrefs.SetString("countinuePath", savedfile);
        isdddd = 5;
    }

    public string gettype(string Item)
    {
        foreach (Itemtypes Itemtypesaaa in ItemtypeList)
        {
            if (Itemtypesaaa.Items.Contains(Item))
            {
                return Itemtypesaaa.type;
            }
        }
        Debug.Log("항목에는 '" + Item + "' 이 존재하지 않습니다.");
        return "none";
    }

    [SerializeField] float MaxXSize_in;
    [SerializeField] float MinXSize_in;
    [SerializeField] float MaxYSize_in;
    [SerializeField] float MinYSize_in;

    [SerializeField] float MaxXSize_out;
    [SerializeField] float MinXSize_out;
    [SerializeField] float MaxYSize_out;
    [SerializeField] float MinYSize_out;

    Vector3 playerspawnFieldpoint = new Vector3(0, 0, 0);

    [System.Serializable]
    public class InstatedFeature
    {
        public float size;
        public Vector3 pos;
    }
    List<InstatedFeature> InstatedFeatures = new List<InstatedFeature>();
    public void randommapstart()
    {
        GameObjectPool game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        //보트 정박장 생성
        InstatefeaturesOutline(game_object_pool, 50, "boat_berth");
        //동굴 생성
        Instatefeatures(game_object_pool, 100, "cave");
        //창고 생성
        Instatefeatures(game_object_pool, 100, "enemy_storage");
        //헬기 착륙장 생성
        Instatefeatures(game_object_pool, 100, "helipad");
        //재물대 생성
        Instatefeatures(game_object_pool, 100, "stage");
        //사원 생성
        InstatefeaturesOut(game_object_pool, 100, "temple");
        //세계수 생성
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        //집 생성
        for (int i = 0; i < 2; i++)
        {
            Instatefeatures(game_object_pool, 40, "01_house");
            Instatefeatures(game_object_pool, 40, "02_house");
            Instatefeatures(game_object_pool, 40, "03_house");
        }
        ////나무 생성
        //Instatefeaturesnamus(game_object_pool, "namu_feature", 0.6f, 1f, 3.6f);
        ////돌 생성
        //Instatefeaturesnamus(game_object_pool, "doll_feature", 0.465f, 0.47f, 1.3f);
        ////철 생성
        //Instatefeaturesnamus(game_object_pool, "chul_feature", 0.667f, 0.67f, 1.3f);

        //나무 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "namu_feature", 0.6f, 1f, 3.6f));
        //돌 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "doll_feature", 0.465f, 0.47f, 1.3f));
        //철 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "chul_feature", 0.667f, 0.67f, 1.3f));
    }

    int isdddd = 0;
    public IEnumerator randommapstartCo()
    {
        isdddd = 0;
        GameObjectPool game_object_pool = GameObject.Find("ObjectPool").GetComponent<GameObjectPool>();
        //보트 정박장 생성
        InstatefeaturesOutline(game_object_pool, 30, "boat_berth");
        yield return null;
        //동굴 생성
        Instatefeatures(game_object_pool, 50, "cave");
        yield return null;
        //마을 생성
        Instatefeatures(game_object_pool, 70, "village");
        yield return null;
        //창고 생성
        Instatefeatures(game_object_pool, 100, "enemy_storage");
        yield return null;
        //헬기 착륙장 생성
        Instatefeatures(game_object_pool, 50, "helipad");
        yield return null;
        //재물대 생성
        Instatefeatures(game_object_pool, 100, "stage");
        yield return null;
        //사원 생성
        InstatefeaturesOut(game_object_pool, 100, "temple");
        yield return null;
        //세계수 생성
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        yield return null;
        Instatefeatures(game_object_pool, 20, "world_tree");
        Instatefeatures(game_object_pool, 20, "world_tree");
        yield return null;
        Instatefeatures(game_object_pool, 20, "world_tree");
        //집 생성
        for (int i = 0; i < 2; i++)
        {
            Instatefeatures(game_object_pool, 40, "01_house");
            Instatefeatures(game_object_pool, 40, "02_house");
            Instatefeatures(game_object_pool, 40, "03_house");
            yield return null;
        }
        percentage++;
        ////나무 생성
        //Instatefeaturesnamus(game_object_pool, "namu_feature", 0.6f, 1f, 3.6f);
        ////돌 생성
        //Instatefeaturesnamus(game_object_pool, "doll_feature", 0.465f, 0.47f, 1.3f);
        ////철 생성
        //Instatefeaturesnamus(game_object_pool, "chul_feature", 0.667f, 0.67f, 1.3f);

        //나무 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "namu_feature", 0.6f, 1f, 3.6f));
        yield return null;
        //돌 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "doll_feature", 0.465f, 0.47f, 1.3f));
        yield return null;
        //철 생성
        StartCoroutine(InstatefeaturesnamusCo(game_object_pool, "chul_feature", 0.667f, 0.67f, 1.3f));
        yield return null;
    }

    void Instatefeatures(GameObjectPool game_object_pool, float size, string thatfeaturething)
    {
        int aint = 0;
        bool aaaaaa = true;
        while (aaaaaa)
        {
            float randx = Random.Range(MinXSize_in + size, MaxXSize_in - size);
            float randy = Random.Range(MinYSize_in + size, MaxYSize_in - size);
            Vector3 pos = new Vector3(randx, 0, randy);
            float randrot = Random.Range(0, 5);
            if(aint > 200)
            {
                Debug.Log("?????????????????????");
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;
            }
            if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
            {
                foreach(InstatedFeature yyyyy in InstatedFeatures)
                {
                    if(Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                    {
                        aint++;
                        goto breaks;
                    }
                }
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;

                breaks:
                    continue;
            }
            else
            {
                aint++;
            }
        }
    }
    void InstatefeaturesOut(GameObjectPool game_object_pool, float size, string thatfeaturething)
    {
        int aint = 0;
        bool aaaaaa = true;
        while (aaaaaa)
        {
            float randrot = Random.Range(0, 4);
            float[] xBumwiiiiii = new float[2];
            float[] yBumwiiiiii = new float[2];

            if (randrot == 0)
            {
                xBumwiiiiii[0] = MinXSize_out + size;
                xBumwiiiiii[1] = MaxXSize_out - size;

                yBumwiiiiii[0] = 2900f + size;
                yBumwiiiiii[1] = 2900f + size;
            }
            else if (randrot == 1)
            {
                yBumwiiiiii[0] = MinXSize_out + size;
                yBumwiiiiii[1] = MaxXSize_out - size;

                xBumwiiiiii[0] = 2900f + size;
                xBumwiiiiii[1] = 2900f + size;
            }
            else if (randrot == 2)
            {
                xBumwiiiiii[0] = MinXSize_out + size;
                xBumwiiiiii[1] = MaxXSize_out - size;

                yBumwiiiiii[0] = -2900f - size;
                yBumwiiiiii[1] = -2900f - size;
            }
            else if (randrot == 3)
            {
                yBumwiiiiii[0] = MinXSize_out + size;
                yBumwiiiiii[1] = MaxXSize_out - size;

                xBumwiiiiii[0] = -2900f - size;
                xBumwiiiiii[1] = -2900f - size;
            }
            else
            {
                continue;
            }

            float randx = Random.Range(xBumwiiiiii[0], xBumwiiiiii[1]);
            float randy = Random.Range(yBumwiiiiii[0], yBumwiiiiii[1]);

            Vector3 pos = new Vector3(randx, 0, randy);
            if (aint > 200)
            {
                Debug.Log("?????????????????????");
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;
            }
            if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
            {
                foreach (InstatedFeature yyyyy in InstatedFeatures)
                {
                    if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                    {
                        aint++;
                        goto breaks;
                    }
                }
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;

            breaks:
                continue;
            }
            else
            {
                aint++;
            }
        }
    }
    void InstatefeaturesOutline(GameObjectPool game_object_pool, float size, string thatfeaturething)
    {
        int aint = 0;
        bool aaaaaa = true;
        while (aaaaaa)
        {
            float randrot = Random.Range(0, 4);
            float[] xBumwiiiiii = new float[2];
            float[] yBumwiiiiii = new float[2];

            if(randrot == 0)
            {
                xBumwiiiiii[0] = MinXSize_in + size;
                xBumwiiiiii[1] = MaxXSize_in - size;

                yBumwiiiiii[0] = 1000f;
                yBumwiiiiii[1] = 1000f;
            }
            else if (randrot == 1)
            {
                yBumwiiiiii[0] = MinXSize_in + size;
                yBumwiiiiii[1] = MaxXSize_in - size;

                xBumwiiiiii[0] = 1000f;
                xBumwiiiiii[1] = 1000f;
            }
            else if (randrot == 2)
            {
                xBumwiiiiii[0] = MinXSize_in + size;
                xBumwiiiiii[1] = MaxXSize_in - size;

                yBumwiiiiii[0] = -1000f;
                yBumwiiiiii[1] = -1000f;
            }
            else if (randrot == 3)
            {
                yBumwiiiiii[0] = MinXSize_in + size;
                yBumwiiiiii[1] = MaxXSize_in - size;

                xBumwiiiiii[0] = -1000f;
                xBumwiiiiii[1] = -1000f;
            }
            else
            {
                continue;
            }

            //float randx = Random.Range(MinXSize_in + size, MaxXSize_in - size);
            //float randy = Random.Range(MinYSize_in + size, MaxYSize_in - size);

            float randx = Random.Range(xBumwiiiiii[0], xBumwiiiiii[1]);
            float randy = Random.Range(yBumwiiiiii[0], yBumwiiiiii[1]);

            Vector3 pos = new Vector3(randx, 0, randy);
            if (aint > 200)
            {
                Debug.Log("?????????????????????");
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;
            }
            if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
            {
                foreach (InstatedFeature yyyyy in InstatedFeatures)
                {
                    if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                    {
                        aint++;
                        goto breaks;
                    }
                }
                var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.Euler(0, randrot * 90, 0));
                InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                aaaaaaaaaaaaaaaaa.size = size;
                aaaaaaaaaaaaaaaaa.pos = pos;
                InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);
                aaaaaa = false;

            breaks:
                continue;
            }
            else
            {
                aint++;
            }
        }
    }
    void Instatefeaturesnamus(GameObjectPool game_object_pool, string thatfeaturething, float mins, float maxs, float height)
    {
        float offsetX = Random.Range(0f, 99999f);
        float offsetY = Random.Range(0f, 99999f);
        float scale = 40;
        float size = 0.5f;
        float outin = 1000;
        float min = mins;
        float max = maxs;
        for (int i = (int)MinXSize_in; i < (int)MaxXSize_in; i += 10)
        {
            for (int j = (int)MinYSize_in; j < (int)MaxYSize_in; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if ((playerspawnFieldpoint - pos).sqrMagnitude > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if ((yyyyy.pos - pos).sqrMagnitude <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                        //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                        //aaaaaaaaaaaaaaaaa.size = size;
                        //aaaaaaaaaaaaaaaaa.pos = pos;
                        //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                        breaks:
                            continue;
                    }
                }
            }
        }
        min = mins + ((maxs - mins) / 2);
        max = maxs;

        for (int i = (int)(MaxXSize_out - outin); i < (int)MaxXSize_out; i += 10)
        {
            for (int j = (int)MinYSize_out; j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if ((playerspawnFieldpoint - pos).sqrMagnitude > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if ((yyyyy.pos - pos).sqrMagnitude <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }
        for (int i = (int)MinXSize_out; i < (int)(MinXSize_out + outin); i += 10)
        {
            for (int j = (int)MinYSize_out; j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if ((playerspawnFieldpoint - pos).sqrMagnitude > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if ((yyyyy.pos - pos).sqrMagnitude <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }

        for (int i = (int)MinXSize_out; i < (int)MaxXSize_out; i += 10)
        {
            for (int j = (int)(MaxYSize_out - outin); j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if ((playerspawnFieldpoint - pos).sqrMagnitude > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if ((yyyyy.pos - pos).sqrMagnitude <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }
        for (int i = (int)MinXSize_out; i < (int)MaxXSize_out; i += 10)
        {
            for (int j = (int)MinYSize_out; j < (int)(MinYSize_out + outin); j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if ((playerspawnFieldpoint - pos).sqrMagnitude > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if ((yyyyy.pos - pos).sqrMagnitude <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }
    }

    int percentage = 0;

    IEnumerator InstatefeaturesnamusCo(GameObjectPool game_object_pool, string thatfeaturething, float mins, float maxs, float height)
    {
        float offsetX = Random.Range(0f, 99999f);
        float offsetY = Random.Range(0f, 99999f);
        float scale = 40;
        float size = 0.5f;
        float outin = 1000;
        float min = mins;
        float max = maxs;
        for (int i = (int)MinXSize_in; i < (int)MaxXSize_in; i += 10)
        {
            percentage++;
            yield return null;
            for (int j = (int)MinYSize_in; j < (int)MaxYSize_in; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-1f, 1f), height, Random.Range(-1f, 1f));

                    if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }

        min = mins + ((maxs - mins) / 2);
        max = maxs;

        for (int i = (int)(MaxXSize_out - outin); i < (int)MaxXSize_out; i += 10)
        {
            percentage++;
            yield return null;
            for (int j = (int)MinYSize_out; j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }
        for (int i = (int)MinXSize_out; i < (int)(MinXSize_out + outin); i += 10)
        {
            percentage++;
            yield return null;
            for (int j = (int)MinYSize_out; j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }

        for (int i = (int)MinXSize_out; i < (int)MaxXSize_out; i += 10)
        {
            percentage++;
            yield return null;
            for (int j = (int)(MaxYSize_out - outin); j < (int)MaxYSize_out; j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }
        for (int i = (int)MinXSize_out; i < (int)MaxXSize_out; i += 10)
        {
            percentage++;
            yield return null;
            for (int j = (int)MinYSize_out; j < (int)(MinYSize_out + outin); j += 10)
            {
                float perlinNoisefloat = Mathf.PerlinNoise(i / scale + offsetX, j / scale + offsetY);
                if (perlinNoisefloat > min && perlinNoisefloat < max)
                {
                    Vector3 pos = new Vector3(i, 0, j) + new Vector3(Random.Range(-4f, 4f), height, Random.Range(-4f, 4f));

                    if (Vector3.Distance(playerspawnFieldpoint, pos) > size)
                    {
                        foreach (InstatedFeature yyyyy in InstatedFeatures)
                        {
                            if (Vector3.Distance(yyyyy.pos, pos) <= yyyyy.size + size)
                            {
                                goto breaks;
                            }
                        }
                        var thaty = game_object_pool.MustInstitateObject(thatfeaturething, pos, Quaternion.identity);
                    //InstatedFeature aaaaaaaaaaaaaaaaa = new InstatedFeature();
                    //aaaaaaaaaaaaaaaaa.size = size;
                    //aaaaaaaaaaaaaaaaa.pos = pos;
                    //InstatedFeatures.Add(aaaaaaaaaaaaaaaaa);

                    breaks:
                        continue;
                    }
                }
            }
        }

        isdddd += 1;
    }
}
