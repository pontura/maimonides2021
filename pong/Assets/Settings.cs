using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public int scoreMultiplier;
    public int playerActiveID;

    public void SwapPlayers()
    {
        if (playerActiveID == 1)
            playerActiveID = 2;
        else
            playerActiveID = 1;

        UserData userdata;
        if(playerActiveID == 1)
            userdata = Data.Instance.users.user1;
        else
            userdata = Data.Instance.users.user2;

        Events.ChangePlayer(userdata);
    }
}
