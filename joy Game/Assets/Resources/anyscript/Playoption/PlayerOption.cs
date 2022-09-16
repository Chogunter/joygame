using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOption : MonoBehaviour
{
    public float Moussegamdo = 3;
    public float PlayerSpeed = 6;
    public float view = 60;
    Camera mainCamera;
    GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        mainCamera = cam.GetComponent<Camera>();
        mainCamera.fieldOfView = PlayerSettings.VideoSetting.ViewingAngle;
    }


    void Update()
    {
        PlayerSpeed = PlayerSettings.Player.PlayerSpeed;
        Moussegamdo = PlayerSettings.PlaySetting.MouseDegree;
        view = PlayerSettings.VideoSetting.ViewingAngle;
    }
}
