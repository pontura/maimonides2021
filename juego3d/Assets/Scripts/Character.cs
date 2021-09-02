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
    float _accelerator;
    public ActionsManager actions;
    public RotateWithMouse rotateWithMouse;

    public void Move(float _horizontal, float _vertical)
    {
        if (_horizontal == 0 && _vertical == 0)
        {
            actions.SetSpeed(0);
            return;
        }
        actions.SetSpeed(speed + _accelerator);

        Vector3 cam_rot = rotateWithMouse.transform.localEulerAngles;
        float rot_y = cam_rot.y;

        if (_vertical > 0)
            rot_y = cam_rot.y;
        else if (_vertical < 0)
            rot_y = cam_rot.y + 180;
        if (_horizontal > 0)
            rot_y = cam_rot.y + 90;
        else if (_horizontal < 0)
            rot_y = cam_rot.y - 90;

        Vector3 newRot = new Vector3(0, rot_y, 0);
        transform.localEulerAngles = newRot;

        transform.Translate(Vector3.forward * (speed + _accelerator) * Time.deltaTime);
    }
    public void Run(bool isRunning)
    {
        if (isRunning)
            _accelerator = accelerator;
        else
            _accelerator = 0;
    }
    public void OnInteract()
    {
       // Pickup pickUpObject = inventory.GetPickupObject();

        if (ioActive != null)
            ioActive.OnInteract(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null)  { ioActive = io; }
    }
    private void OnTriggerExit(Collider other)
    {
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null) { ioActive = null; }
    }
}