using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance;
    public Users users;
    public Settings settings;

    private void Awake()
    {
        Instance = this;
    }
}
