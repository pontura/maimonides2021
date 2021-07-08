using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    Transform originalParent;
    bool grabbed;

    private void Start()
    {
        originalParent = transform.parent;
    }
    public void OnGrab(Transform grabContainer)
    {
        if (!grabbed)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Collider>().enabled = false;
            transform.SetParent(grabContainer);
            transform.localPosition = Vector3.zero;
        }
        else // lo deja:
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Collider>().enabled = true;
            transform.SetParent(originalParent);
        }
        grabbed = !grabbed;
    }
}
