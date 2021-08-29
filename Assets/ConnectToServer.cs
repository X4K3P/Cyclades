using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ConnectToServer : MonoBehaviourPunCallbacks
{
    private GameObject Img;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Img = GameObject.Find("Image");
    }
    public override void OnConnectedToMaster()
    {
        Img.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
