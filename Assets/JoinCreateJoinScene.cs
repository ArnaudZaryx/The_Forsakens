using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinCreateJoinScene : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public void LoadSceneJoinCreate()
    {
        SceneManager.LoadScene("CreateJoin");
    }
}
