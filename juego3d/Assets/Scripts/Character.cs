using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    [SerializeField] InteractiveObject ioActive = null;
    public Transform hand;

    public void Move(float rotationValue, float _vertical)
    {
        if(rotationValue != 0)
            transform.Rotate(Vector3.up * rotationValue * rotationSpeed * Time.deltaTime);

        Vector3 moveVector = (Vector3.forward * _vertical);
        if(moveVector != Vector3.zero)
            transform.Translate(moveVector * speed * Time.deltaTime);
    }
    public void OnInteract()
    {
        if (ioActive == null) return;
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
