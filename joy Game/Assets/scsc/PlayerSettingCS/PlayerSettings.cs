using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerSettings
{
    public static class Player
    {
        public static int PlayerMaxHp;
        public static int PlayerAttackDmg;
        public static int PlayerHitDmg;
        public static float PlayerPushDegree;
        public static float PlayerSpeed;
        public static float PLayerJumpPower;
        public static float PlayerEnergyMax;
    }
    public static class AudioSetting
    {
        public static float Volume;//0~100 소리
    }
    public static class VideoSetting
    {
        public static float ViewingAngle;//20~80 카메라
    }
    public static class PlaySetting
    {
        public static float MouseDegree;//1~10 무빙,카메라
    }

    public static class Tutorial
    {
        public static bool TutorialOn = true;
    }
}
