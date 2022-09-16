using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class play_record_info
{
    [System.Serializable]
    public class Record
    {
        public string type;
        public int num;
    }

    public static List<Record> GetAllOfRecords()
    {
        List<Record> a = new List<Record>();
        foreach(Record b in Kill_Record.records)
        {
            a.Add(b);
        }
        foreach (Record b in Item_Make_Record.records)
        {
            a.Add(b);
        }
        foreach (Record b in Farm_Record.records)
        {
            a.Add(b);
        }
        foreach (Record b in Player_Record.records)
        {
            a.Add(b);
        }
        foreach (Record b in Build_Record.records)
        {
            a.Add(b);
        }
        foreach (Record b in GetItemRecord.records)
        {
            a.Add(b);
        }
        return a;
    }

    public static class Kill_Record
    {
        public static List<Record> records = new List<Record>();

        public static int GetRecord(string type)
        {
            foreach(Record a in records)
            {
                if(a.type == type)
                {
                    return a.num;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    public static class Item_Make_Record // 완료
    {
        public static List<Record> records = new List<Record>();

        public static int GetRecord(string type)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    return a.num;
                }
            }

            //Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            //Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    public static class Farm_Record
    {
        public static List<Record> records = new List<Record>();

        public static int GetRecord(string type)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    return a.num;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    public static class Player_Record
    {
        public static List<Record> records = new List<Record>();

        public static int GetRecord(string type)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    return a.num;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    public static class Build_Record
    {
        public static List<Record> records = new List<Record>();

        public static int GetRecord(string type)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    return a.num;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    public static class GetItemRecord
    {
        public static List<Record> records = new List<Record>();
        public static int GetRecord(string type)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    return a.num;
                }
            }

            //Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");
            return 0;
        }
        public static void SetRecorder(string type, int setnum=1)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num = setnum;
                }
            }

            //Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = setnum;

            records.Add(b);
        }
        public static void AddRecorder(string type, int addnum=1)
        {
            foreach (Record a in records)
            {
                if (a.type == type)
                {
                    a.num += addnum;
                }
            }

            Debug.Log($"{type} 이라는 항목에 대한 기록이 없습니다.");

            Record b = new Record();
            b.type = type;
            b.num = addnum;

            records.Add(b);
        }
    }
    
    public static class PlayedTimeRecord
    {
        public static float time;
        public static int day;

        public static void Settime(float timea)
        {
            time = timea;
        }
        public static void Addday()
        {
            day += 1;
        }
        public static int GetPlayTime()
        {
            return (int)time + day * 14400;
        }
    }
}
