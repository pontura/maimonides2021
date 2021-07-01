using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Users : MonoBehaviour
{
    public UserData user1;
    public UserData user2;

    public void UserWin(int id, int value)
    {
        if (id == 1)
            user1.score += value;
        else
            user2.score += value;
    }
}
