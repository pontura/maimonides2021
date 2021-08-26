using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float maxSpeed = 5;
    public float rotationSpeed;
    public InteractiveObject ioActive = null;
    public Transform hand;
    public Inventory inventory;
    public float speed;
    public float accelerator;
    public ActionsManager actions;

    public void Move(float rotationValue, float _vertical)
    {
        if(rotationValue != 0)
            transform.Rotate(Vector3.up * rotationValue * rotationSpeed * Time.deltaTime);

        Vector3 moveVector = (Vector3.forward * _vertical);
        if(moveVector != Vector3.zero)
            transform.Translate(moveVector * maxSpeed * Time.deltaTime);

        speed = moveVector.z + accelerator;
        actions.SetSpeed(speed);
    }
    public void Run(bool isRunning)
    {
        if (isRunning)
            accelerator = 1;
        else
            accelerator = 0;
    }
    public void OnInteract()
    {
        Pickup pickUpObject = inventory.GetPickupObject();

        if (ioActive != null)
            ioActive.OnInteract(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null)  { ioActive = io;  }
    }
    private void OnTriggerExit(Collider other)
    {
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null) { ioActive = null; }
    }
}