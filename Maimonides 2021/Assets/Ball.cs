using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    Vector3 velocity;  
 
    void Awake()
    {
        velocity = this.transform.forward; 
        speed = 20;
    }
    void Update()
    {
        this.transform.position += velocity * Time.deltaTime * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contactPoint = collision.contacts[0];
        Vector3 normal = contactPoint.normal;
        velocity = 2 * (Vector3.Dot(velocity, Vector3.Normalize(normal))) * Vector3.Normalize(normal) - velocity;
        velocity *= -1;
        GameObject collitionWith = collision.gameObject;
        //Destroy(collitionWith);
    }
}
