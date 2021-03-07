using UnityEngine;
using Photon.Pun;

public class PlayerNameInputManager : MonoBehaviour
{
    public void SetPlayerName(string playername)
    {

        if (string.IsNullOrEmpty(playername))
        {
            Debug.Log("player name is empty");
            return;
        }

        PhotonNetwork.NickName = playername;

        



    }
}
