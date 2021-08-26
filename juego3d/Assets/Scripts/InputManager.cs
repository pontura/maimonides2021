using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float verticalAxis;
    public float horizontalAxis;
    public int id;
    public Character character;
    public GameObject cameraPivot;

    public float filterX;
    public float filterY;

    public float offsetRotationY;
    public Vector2 limitsY;

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

        if (Input.GetKeyDown(KeyCode.Space))
            character.actions.Attack();

        float _y = (Input.mousePosition.y) * filterY;
        float _x = (Input.mousePosition.x - Screen.width / 2) * filterX;

        print(_y);
        if (_y < limitsY.x) _y = limitsY.x;
        else  if (_y > limitsY.y) _y = limitsY.y;

        _y += offsetRotationY;
        cameraPivot.transform.localEulerAngles = new Vector3(_y, 0,  0);
        Vector3 rot = character.transform.localEulerAngles;
        rot.y = _x;
        character.transform.localEulerAngles = rot;
    }
}
