using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractiveObject
{
    public Vector3 openPosition;
    Vector3 originalPosition;
    public bool open;
    public float speed = 5;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }
    private void Update()
    {
        Vector3 dest = Vector3.zero;
        if(open && transform.localPosition != openPosition)
        {
            dest = openPosition;
        }
        else if (!open && transform.localPosition != originalPosition)
        {
            dest = originalPosition;
        }
        if(dest != Vector3.zero)
            transform.localPosition = Vector3.Lerp(transform.localPosition, dest, speed*Time.deltaTime);
    }
    public void Open()
    {
        open = true;
    }
    public void Close()
    {
        open = false;
    }
}
