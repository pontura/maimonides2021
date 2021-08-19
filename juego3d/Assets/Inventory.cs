using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InteractiveObject> all;
    public int totalItems = 1;

    public void Add(InteractiveObject io)
    {
        if(IsFull()) return;
        all.Add(io);
    }
    public void Remove(InteractiveObject io)
    {
        all.Remove(io);
    }
    public bool IsFull()
    {
        if (all.Count >= totalItems)
            return true;
        return false;
    }
    public Pickup GetPickupObject()
    {
        foreach(InteractiveObject io in all)
        {
            if (io.GetComponent<Pickup>())
                return io.GetComponent<Pickup>();
        }
        return null;
    }
}
