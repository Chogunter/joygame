using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class enemypartys
{
    public static class enemy
    {
        public static string name = "enemy";
        public static List<string> enemyParty = new List<string>() { "friend", "boss" };
        public static List<string> teamParty = new List<string>() { "enemy" };
        public static List<string> neuterParty = new List<string>() { "neuter" };
    }
    public static class friend
    {
        public static string name = "friend";
        public static List<string> enemyParty = new List<string>() { "enemy", "boss" };
        public static List<string> teamParty = new List<string>() { "friend" };
        public static List<string> neuterParty = new List<string>() { "neuter" };
    }
    public static class neuter
    {
        public static string name = "neuter";
        public static List<string> enemyParty = new List<string>() { "boss" };
        public static List<string> teamParty = new List<string>() { "neuter" };
        public static List<string> neuterParty = new List<string>() { "friend", "enemy" };
    }
    public static class boss
    {
        public static string name = "boss";
        public static List<string> enemyParty = new List<string>() { "boss" , "friend", "enemy", "neuter" };
        public static List<string> teamParty = new List<string>() { };
        public static List<string> neuterParty = new List<string>() { };
    }

    public static string CheckTeam(string your_team, string target_team)
    {
        if(your_team == "enemy")
        {
            if (enemy.enemyParty.Contains(target_team))
            {
                return "enemy";
            }
            if (enemy.teamParty.Contains(target_team))
            {
                return "team";
            }
            if (enemy.neuterParty.Contains(target_team))
            {
                return "neuter";
            }
        }
        if (your_team == "friend")
        {
            if (friend.enemyParty.Contains(target_team))
            {
                return "enemy";
            }
            if (friend.teamParty.Contains(target_team))
            {
                return "team";
            }
            if (friend.neuterParty.Contains(target_team))
            {
                return "neuter";
            }
        }
        if (your_team == "neuter")
        {
            if (neuter.enemyParty.Contains(target_team))
            {
                return "enemy";
            }
            if (neuter.teamParty.Contains(target_team))
            {
                return "team";
            }
            if (neuter.neuterParty.Contains(target_team))
            {
                return "neuter";
            }
        }
        if (your_team == "boss")
        {
            if (boss.enemyParty.Contains(target_team))
            {
                return "enemy";
            }
            if (boss.teamParty.Contains(target_team))
            {
                return "team";
            }
            if (boss.neuterParty.Contains(target_team))
            {
                return "neuter";
            }
        }
        return null;
    }
}