using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Region.RegionType CurrentRegion;
    
    public CinemachineVirtualCamera vcam;

    void Awake()
    {
        instance = this;
    }

    public void StartGame()
    {
        vcam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void GetPlayerShoot(bool check)
    {
        PlayerShooting.instance.ShootEvent(check);
    }
}
