using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tateti : MonoBehaviour
{
    public TatetiSlot[] allSlots;
    public int turnID = 1;
    public ResultData[] posibleResults;

    [Serializable]
    public class ResultData
    {
        public Vector2 value1;
        public Vector2 value2;
        public Vector2 value3;
    }

    void Start()
    {
        turnID = 1;
        allSlots = GetComponentsInChildren<TatetiSlot>();
        foreach (TatetiSlot slot in allSlots)
            slot.Init(this);
    }
    public void OnSlotClicked()
    {
        turnID++;
        if (turnID > 2) turnID = 1;
        foreach(ResultData resultData in posibleResults)
        {
            int resultID = GetResult(resultData.value1, resultData.value2, resultData.value3);
            if(resultID != 0)
            {
                print("GANO : " + resultID);
                return;
            }
        }
    }





    int GetResult(Vector2 value1, Vector2 value2, Vector2 value3)
    {
        int teamID_value1 = GetTeamSlot(value1);
        int teamID_value2 = GetTeamSlot(value2);
        int teamID_value3 = GetTeamSlot(value3);

        if(teamID_value1 == teamID_value2 && teamID_value1 == teamID_value3 && teamID_value1 != 0)
            return teamID_value1;

        return 0;
    }
    int GetTeamSlot(Vector2 value)
    {
        foreach(TatetiSlot slot in allSlots)
        {
            if (slot.axis == value)
                return slot.GetTeamID();
        }
        return 0;
    }
}
