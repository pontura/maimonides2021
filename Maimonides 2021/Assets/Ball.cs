using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10;
    public Character character;
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
        foreach (ContactPoint contact  in collision.contacts)
        {
            velocity = 2 * (Vector3.Dot(velocity, Vector3.Normalize(contact.normal))) * Vector3.Normalize(contact.normal) - velocity;
            velocity *= -1;
        }
    }    
}
