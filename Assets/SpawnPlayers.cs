using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameObject Player;
    public GameObject MasterPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 ran = new Vector3(0,0,0);
        PhotonNetwork.Instantiate(Player.name,ran,Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
