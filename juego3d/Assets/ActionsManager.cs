using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{
    public Animator anim;
    public Transform hand;
    GameObject grabbedObject = null;
    string grabbedObjectName = "";

    public void SetSpeed(float speed)
    {
        anim.SetFloat("speed", speed);
    }
    public void Attack()
    {
        anim.SetBool("attack", true);
    }
    public void EndAttack()
    {
        anim.SetBool("attack", false);
    }
    public void PlayAttackSound()
    {
        print("sound");
    }
    public void GetObject(GameObject asset)
    {
        ResetGrabbedItems();
        if (asset.name != grabbedObjectName)
        { 
            grabbedObject = Instantiate(asset, hand);
            grabbedObject.transform.localPosition = Vector3.zero;
            grabbedObjectName = asset.name;
        }
        else
        {
            grabbedObjectName = "";
        }
    }
    void ResetGrabbedItems()
    {
        if (grabbedObject != null)
            Destroy(grabbedObject);
    }
}
