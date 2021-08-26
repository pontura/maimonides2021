using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;
    public int id;
    public Character character;

    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical" + id);
        horizontalAxis = Input.GetAxis("Horizontal" + id);

        character.Move(horizontalAxis, verticalAxis);

        if(Input.GetButtonDown("Action" + id))
            character.OnInteract();

        if (Input.GetKey(KeyCode.LeftShift))
            character.Run(true);
        else
            character.Run(false);

    }
}
