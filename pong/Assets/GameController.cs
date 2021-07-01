using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UIManager uiManager;
    public GameObject targetToChangeSize;

    public void OnScore(int score)
    {
        uiManager.OnScore(score);
    }
    public void BallChangeSize()
    {
        //float rand = Random.Range(1, 5);
        //targetToChangeSize.transform.localScale = new Vector3(rand, rand, rand);
    }

}
