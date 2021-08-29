
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameControl : MonoBehaviour, IPunObservable
{
    public bool IsMaster;
    public int test;
    public GameObject IsMasterHere;
    // Start is called before the first frame update
    void Start()
    {
        IsMasterHere = GameObject.FindGameObjectWithTag("Player");
        if (IsMasterHere == gameObject)
        {
            IsMaster = true;
        }
        if (IsMaster == true)
        {
            test = UnityEngine.Random.Range(1, 100);
        }
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting && IsMaster == true)
        {



            stream.SendNext(test);
            UnityEngine.Debug.Log("Отправка");

        }
        else if (stream.IsReading && IsMaster == false)
        {

            UnityEngine.Debug.Log("прием");
            test = (int)stream.ReceiveNext();

        }
    }

}
