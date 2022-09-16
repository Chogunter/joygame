using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    RaycastHit hit;

    [Header("기본설정")]
    public int Max_Hp;
    public int Hp;
    public string type;
    [SerializeField] string team_grade;
    [SerializeField] float speed;
    public List<GameObject> teams;
    [Header("무기")]
    public string dogu;
    [SerializeField] GameObject doguObject;
    [SerializeField] GameObject chong;
    Vector3 or_chong_pos;
    Vector3 jojo_chong_pos;
    [SerializeField] string attackstyle;
    [SerializeField] string current_situation;
    [SerializeField] string Hp_situation;

    [Header("범위체크")]
    [SerializeField] GameObject bumwii;
    [SerializeField] float Maxdis;
    [SerializeField] List<GameObject> Bumwii_gameObjects;

    [Header("공격")]
    public GameObject Look;
    [SerializeField] float attacktime;

    public string Party = "enemy";

    public bool ThereIsTarget;
    public Vector3 target_pos;
    Vector3 attackPos;
    Vector3 domangPos;
    float distance;
    [SerializeField] Vector3 peaceMove;

    GameObject Player;
    GameObject Cursor;
    Rigidbody rb;

    Vector3 thatpos;
    float[] time = new float[3];
    public float timesdwds = 0.5f;

    Vector3 randpos;
    public Vector3 or_pos;
    [SerializeField] int index_of_teams;

    [SerializeField] AudioClip[] clips; //0아 1혼란 2아하 3오키 4적발견
    [SerializeField] float[] audiotimes;
    AudioSource audiosource;
    float audiotime;
    bool targetlookedonce;
    bool counfuseonce;

    [SerializeField] isbada groundcheck;
    [SerializeField] personanimationparamitormanager animationperson;
    [SerializeField] float dietime = 0.7f;

    [SerializeField] AudioSource walkingSound;
    float walklatetime;
    Vector3 latepos;
    bool ismoving;
    bool xmoving = false;
    bool ymoving = false;

    [System.Serializable]
    public class RandomDealItem
    {
        public string name;
        public Item_make_info.MakerItem DealItem;
        public int Random;
    }


    [SerializeField] List<RandomDealItem> DealItems = new List<RandomDealItem>();
    public List<Item_make_info.MakerItem> DealItemList = new List<Item_make_info.MakerItem>();
    [SerializeField] int DealAmount;

    int RandomNum = 0;
    List<string> chossenItem = new List<string>();

    public bool isPlayerTeam;
    int rand;
    void ResetDeal()
    {
        DealItemList = new List<Item_make_info.MakerItem>();

        RandomNum = 0;
        foreach(RandomDealItem a in DealItems)
        {
            RandomNum += a.Random;
        }

        for (int i = 0; i < DealAmount; i++)
        {
            rand = Random.Range(0, RandomNum);
            foreach (RandomDealItem a in DealItems)
            {
                if (a.Random > rand)
                {
                    if (chossenItem.Contains(a.name))
                    {
                        break;
                    }
                    DealItemList.Add(a.DealItem);
                    chossenItem.Add(a.name);
                    break;
                }
                rand -= a.Random;
            }
        }
    }

    bool isdead;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        Cursor = GameObject.Find("Cursor Item");
        audiosource = GetComponent<AudioSource>();
        or_chong_pos = chong.transform.localPosition;
        jojo_chong_pos = new Vector3(chong.transform.localPosition.x +0.5f, chong.transform.localPosition.y - 0.5f, chong.transform.localPosition.z);
    }

    private void OnEnable()
    {
        for (int i = 0; i < Loading_Manager.NeedToBeCalled.Count; i++)
        {
            if (Loading_Manager.NeedToBeCalled[i] == gameObject)
            {
                Loading_Manager.NeedToBeCalled[i] = null;
                return;
            }
        }
        isdead = false;
        ResetDeal();
        Hp = Max_Hp;
        or_pos = transform.position;
        walklatetime = 12;
        for (int i = 0; i < audiotimes.Length; i++)
        {
            audiotimes[i] = 0;
        }
        for (int i = 0; i < time.Length; i++)
        {
            time[i] = 0;
        }
        speed += Random.Range(-10, 20) / 20;

        isPlayerTeam = false;
    }

    void Update()
    {
        //audiotime += Time.deltaTime;
        walklatetime += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
        or_pos = new Vector3(or_pos.x, transform.position.y, or_pos.z);
        for(int p = 0; p < teams.Count - 1; p++)
        {
            if(teams[p] == null)
            {
                teams.RemoveAt(p);
            }
        }
        for (int o = 0; o < teams.Count; o++)
        {
            if(teams[o] == gameObject)
            {
                index_of_teams = o;
                break;
            }
        }
        if (isdead)
        {
            return;
        }
        Bumwii_gameObjects = bumwii.GetComponent<Enemybumwii>().gamob;
        for (int i = 0; i < time.Length; i++)
        {
            time[i] += Time.deltaTime;
        }
        distance = Vector3.Distance(transform.position, target_pos);
        if (true)
        {
            if(Hp <= 0)
            {
                die();
            }
            else if (Hp > Max_Hp / 4)
            {
                Hp_situation = "Hight";
            }
            else
            {
                Hp_situation = "Low";
            }
            if (Hp > 0)
            {
                if(time[1] > 2)
                {
                    Hp += 2;
                    time[1] = 0;
                }
                if(Hp > Max_Hp)
                {
                    Hp = Max_Hp;
                }
            }

        }
        for(int j = 0; j < Bumwii_gameObjects.Count; j++)
        {
            if(Bumwii_gameObjects[j] == null)
            {
                Bumwii_gameObjects.RemoveAt(j);
            }
        }
        teamcheck();
        Mugicheck();
        Bumwiicheck();
        MovePos();
        Move();
        //if (audiotime > Random.Range(5, 39))
        //{
        //    int rand = Random.Range(0, 2); // 0, 2
        //    if(rand >= 1)
        //    {
        //        rand = 2;
        //    }
        //    //audioplay(clips[rand], false);
        //    audiotime = 0;
        //}

        //x
        if (true)
        {
            if(latepos.x == transform.position.x)
            {
                xmoving = false;
            }
            else if (latepos.x < transform.position.x)
            {
                xmoving = latepos.x - 1 < transform.position.x;
            }
            else if (latepos.x > transform.position.x)
            {
                xmoving = latepos.x > transform.position.x - 1;
            }
        }
        //y
        if (true)
        {
            if (latepos.z == transform.position.z)
            {
                ymoving = false;
            }
            else if (latepos.z < transform.position.z)
            {
                ymoving = latepos.z - 1 < transform.position.z;
            }
            else if (latepos.z > transform.position.z)
            {
                ymoving = latepos.z > transform.position.z - 1;
            }
        }
        ismoving = xmoving || ymoving;
        //Debug.Log(latepos.z == transform.position.z);

        if (ismoving)
        {
            if(walklatetime > 12)
            {
                walkingSound.Stop();
                walkingSound.Play();
                walklatetime = 0;
            }
        }
        else
        {
            walklatetime = 12;
            walkingSound.Stop();
        }

        if (current_situation == "peace")
        {
            targetlookedonce = true;
        }
        else
        {
            if (targetlookedonce)
            {
                if (team_grade == "Leader")
                {
                    //audioplay(clips[4], true);
                }
                else
                {
                    int a = Random.Range(0, 2);
                    if(a == 0)
                    {
                        //audioplay(clips[2], true);
                    }
                    else
                    {
                        //audioplay(clips[4], true);
                    }
                }
            }
            targetlookedonce = false;
        }
        if(current_situation == "escape")
        {
            if (counfuseonce)
            {
                //audioplay(clips[1], true);
            }
            counfuseonce = false;
        }
        else
        {
            counfuseonce = true;
        }

        latepos = transform.position;
    }
    public void Ahit()
    {
        if (time[0] > timesdwds)
        {
            if (Cursor.GetComponent<ItemCursor>().Using_Item == "gum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 7;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulgum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 12;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "namuGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 4;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dollGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 3;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulnamuGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 5;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chulGock")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 4;
                timesdwds = 0.5f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "dril")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 7;
                timesdwds = 0.05f;
            }
            else if (Cursor.GetComponent<ItemCursor>().Using_Item == "chuldangum")
            {
                Hp -= PlayerSettings.Player.PlayerAttackDmg * 6;
                timesdwds = 0.2f;
            }
            else
            {
                timesdwds = 0.5f;
                Hp -= PlayerSettings.Player.PlayerAttackDmg;
            }
            rb.AddForce((transform.position - Player.transform.position).normalized * PlayerSettings.Player.PlayerPushDegree + Vector3.up, ForceMode.VelocityChange);

            time[0] = 0f;
        }
    }
    void Mugicheck()
    {
        doguObject.GetComponent<doguslotscript>().a = dogu;
        if(dogu == "chong")
        {
            if (ThereIsTarget)
            {
                chong.transform.localPosition = jojo_chong_pos;
            }
            else
            {
                chong.transform.localPosition = or_chong_pos;
            }
        }
        if(dogu == "chong" || dogu == "hwal")
        {
            attackstyle = "far_away";
        }
        else
        {
            attackstyle = "close_range";
        }
    }
    void Bumwiicheck2()
    {
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "Monsters")
            {
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "boss")
            {
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "tuchuck")
            {
                if(Vector3.Distance(transform.position, Bumwii_gameObjects[i].transform.position) > 14)
                {
                    continue;
                }
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "Player" && enemypartys.friend.name != Party)
            {
                if (Bumwii_gameObjects[i].GetComponent<Player_Hp>().IsDie)
                {
                    continue;
                }
                current_situation = "attack";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "Enemy" && enemypartys.CheckTeam(Party, Bumwii_gameObjects[i].GetComponent<Enemymove>().Party) == "enemy")
            {
                current_situation = "attack";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;
            if (Bumwii_gameObjects[i].tag == "SangMul")
            {
                current_situation = "hunt";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
        }
        current_situation = "peace";
        ThereIsTarget = false;
    }

    float dis = 300;
    int thatdistargetss;
    void Bumwiicheck()
    {
        thatdistargetss = -1;
        dis = 300;
        for (int i = 0; i < Bumwii_gameObjects.Count; i++)
        {
            if (Bumwii_gameObjects[i] == null)
                continue;
            if (!Bumwii_gameObjects[i].activeSelf)
                continue;

            if (Bumwii_gameObjects[i].tag == "tuchuck")
            {
                if (Vector3.Distance(transform.position, Bumwii_gameObjects[i].transform.position) > 14)
                {
                    continue;
                }
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
            else if (Bumwii_gameObjects[i].tag == "Monsters")
            {
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
            else if (Bumwii_gameObjects[i].tag == "boss")
            {
                current_situation = "escape";
                target_pos = Bumwii_gameObjects[i].transform.position;
                ThereIsTarget = true;
                return;
            }
            else if (Bumwii_gameObjects[i].tag == "Player") 
            { 
                if (Bumwii_gameObjects[i].GetComponent<Player_Hp>().IsDie)
                {
                    continue;
                }
                if(enemypartys.friend.name == Party)
                {
                    continue;
                }
            }
            else if (Bumwii_gameObjects[i].tag == "Enemy" && enemypartys.CheckTeam(Party, Bumwii_gameObjects[i].GetComponent<Enemymove>().Party) != "enemy")
            {
                continue;
            }

            string a = Bumwii_gameObjects[i].tag;

            if (a == "Enemy" || a == "Player" || a == "SangMul")
            {
                float disssssss = Vector3.Distance(transform.position, Bumwii_gameObjects[i].transform.position);
                if (disssssss < dis)
                {
                    dis = disssssss;
                    thatdistargetss = i;
                }
            }
        }
        if(thatdistargetss == -1)
        {
            current_situation = "peace";
            ThereIsTarget = false;
            return;
        }

        GameObject ssss = Bumwii_gameObjects[thatdistargetss];
        if (ssss.tag == "Enemy" && enemypartys.CheckTeam(Party, ssss.GetComponent<Enemymove>().Party) == "enemy")
        {
            current_situation = "attack";
            target_pos = ssss.transform.position;
            ThereIsTarget = true;
        }
        else if (ssss.tag == "SangMul")
        {
            current_situation = "hunt";
            target_pos = ssss.transform.position;
            ThereIsTarget = true;
            return;
        }
        else if (ssss.tag == "Player" && enemypartys.friend.name != Party)
        {
            current_situation = "attack";
            target_pos = ssss.transform.position;
            ThereIsTarget = true;
            return;
        }

        target_pos = Bumwii_gameObjects[thatdistargetss].transform.position;
        ThereIsTarget = true;
    }

    [SerializeField] float checkdis = 30;
    void MovePos()
    {
        if (type == "defender")
        {
            peaceMove = or_pos;
            if(Vector3.Distance(or_pos, thatpos) > checkdis)
            {
                if (Hp_situation == "Hight" && current_situation != "escape")
                {
                    current_situation = "peace";
                    ThereIsTarget = false;
                }
                else if(distance > 10)
                {
                    current_situation = "peace";
                    ThereIsTarget = false;
                }
            }
        }
        else
        {
            if (team_grade == "Leader")
            {
                if (time[2] > 10 || !groundcheck.isground)
                {
                    float randx = Random.Range(-5, 5);
                    float randy = Random.Range(-5, 5);
                    randpos = new Vector3(randx, 0, randy);
                    time[2] = 0;
                }
                peaceMove = randpos + transform.position;
            }
            else
            {
                if (index_of_teams % 2 == 1)
                {
                    Vector3 padwdasd = (teams[0].transform.forward * -3 + teams[0].transform.right * 3);// - teams[0].transform.position;
                    peaceMove = padwdasd * ((index_of_teams + 1) / 2) + teams[0].transform.position;
                    //Debug.Log(padwdasd);
                }
                else
                {
                    Vector3 padwdasd = (teams[0].transform.forward * -3 + teams[0].transform.right * -3);// - teams[0].transform.position;
                    peaceMove = padwdasd * ((index_of_teams + 1) / 2) + teams[0].transform.position;
                    //Debug.Log(padwdasd);
                }
                peaceMove = new Vector3(peaceMove.x, transform.position.y, peaceMove.z);
            }
        }
        thatpos = new Vector3(target_pos.x, transform.position.y, target_pos.z);
        domangPos = transform.position * 2 - thatpos;
        attackPos = thatpos;
        if (Physics.Raycast(transform.position, Look.transform.forward, out hit, Maxdis))
        {
            Debug.DrawRay(transform.position, transform.forward * Maxdis, Color.blue, 0.3f);

            if (current_situation == "attack")
            {
                if (hit.collider.tag == "Player")
                {
                    if (attackstyle == "far_away")
                    {
                        animationperson.Aimed();
                    }
                    attackPos = transform.position;
                    if(distance < 10)
                    {
                        attackPos = domangPos;
                    }
                }
                else
                {
                    animationperson.DisAimed();
                }
            }
            else if (current_situation == "hunt")
            {
                if (hit.collider.tag == "SangMul")
                {
                    if (attackstyle == "far_away")
                    {
                        animationperson.Aimed();
                    }
                    attackPos = transform.position;
                    if (distance < 10)
                    {
                        attackPos = domangPos;
                    }
                }
                else
                {
                    animationperson.DisAimed();
                }
            }
        }
        else
        {
            animationperson.DisAimed();
        }
    }

    Vector3 getoutvector;
    Vector3 apapap;
    float dadadada = 3;

    Vector3 getouts()
    {
        apapap = Vector3.zero;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.4f * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap -= transform.forward * 1.4f;
            }
        }
        if (Physics.Raycast(transform.position, transform.right, out hit, 1.4f * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap -= transform.right * 1.4f;
            }
        }
        if (Physics.Raycast(transform.position, -transform.forward, out hit, 1.4f * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                //apapap += transform.forward * 1.4f;
            }
        }
        if (Physics.Raycast(transform.position, -transform.right, out hit, 1.4f * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap += transform.right * 1.4f;
            }
        }

        if (Physics.Raycast(transform.position, transform.forward - transform.right, out hit, 1 * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap -= transform.forward - transform.right;
            }
        }
        if (Physics.Raycast(transform.position, transform.right + transform.forward, out hit, 1 * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap -= transform.right + transform.forward;
            }
        }
        if (Physics.Raycast(transform.position, -transform.forward + transform.right, out hit, 1 * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                //apapap -= -transform.forward + transform.right;
            }
        }
        if (Physics.Raycast(transform.position, -transform.right + transform.forward, out hit, 1 * dadadada))
        {
            if (hit.collider.tag == "Enemy")
            {
                apapap -= -transform.right + transform.forward;
            }
        }
        return apapap;
    }
    void Move()
    {
        getoutvector = getouts();
        getoutvector /= 1.4f;
        getoutvector *= 3f;
        if (ThereIsTarget)
        {
            if (current_situation == "escape")
            {
                transform.position = Vector3.MoveTowards(transform.position, domangPos, speed * 1.2f * Time.deltaTime);
                transform.LookAt(domangPos);
                if (dogu == "chong")
                {
                    chong.transform.localPosition = or_chong_pos;
                }
            }
            else if (current_situation == "attack")
            {
                if(Hp_situation == "Low")
                {
                    transform.position = Vector3.MoveTowards(transform.position, domangPos, speed * 2 * Time.deltaTime);
                    transform.LookAt(domangPos);
                    if (dogu == "chong")
                    {
                        chong.transform.localPosition = or_chong_pos;
                    }
                }
                else if (attackstyle == "far_away")
                {
                    transform.position = Vector3.MoveTowards(transform.position, attackPos, speed * Time.deltaTime);
                    transform.LookAt(thatpos);
                    Attack();
                }
                else if(attackstyle == "close_range")
                {
                    if(distance > 2)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, thatpos + getoutvector, speed * Time.deltaTime);
                        transform.LookAt(thatpos);
                    }
                    Attack();
                }
            }
            else if(current_situation == "hunt")
            {
                if (attackstyle == "far_away")
                {
                    transform.position = Vector3.MoveTowards(transform.position, attackPos, speed * Time.deltaTime);
                    transform.LookAt(thatpos);
                    Attack();
                }
                else if(attackstyle == "close_range")
                {
                    if (distance > 2)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, thatpos + getoutvector, speed * Time.deltaTime);
                        transform.LookAt(thatpos);
                    }
                    Attack();
                }
            }
        }
        else if (current_situation == "peace")
        {
            transform.position = Vector3.MoveTowards(transform.position, peaceMove, speed * Time.deltaTime);
            transform.LookAt(peaceMove);
        }
    }
    void Attack()
    {
        if(dogu == "chong")
        {
            chong.transform.localPosition = jojo_chong_pos;
        }
        Look.GetComponent<EnemyLook>().tryattack();
    }
    void teamcheck()
    {
        if (teams != null && !isPlayerTeam)
        {
            if (teams[0] == gameObject)
            {
                team_grade = "Leader";
            }
            else
            {
                team_grade = "crew";
            }
        }
    }
    void die()
    {
        //for(int k = 0; k < Manager.GetComponent<Enemyinstate>().enemy.Count; k++)
        //{
        //    if(Manager.GetComponent<Enemyinstate>().enemy[k] == gameObject)
        //    {
        //        Manager.GetComponent<Enemyinstate>().enemy[k].SetActive(false);
        //    }
        //}
        //Destroy(gameObject);
        isdead = true;
        animationperson.Die();
        StartCoroutine(dying());
    }
    IEnumerator dying()
    {
        yield return new WaitForSeconds(dietime);
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        if (teams != null)
        {
            for (int i = 0; i < teams.Count - 1; i++)
            {
                if (teams[i] != null && teams[i] != gameObject)
                {
                    teams[i].GetComponent<Enemymove>().teams.Remove(gameObject);
                }
            }
        }
    }

    void audioplay(AudioClip audio, bool yeah)
    {
        if (yeah)
        {
            audiosource.Stop();
        }
        if (!audiosource.isPlaying)
        {
            audiosource.clip = audio;
            audiosource.Play();
        }
    }
}
