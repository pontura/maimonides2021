using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameController gameController;
    public Text scoreField;
    public Slider slider;
    int score = 0;
    public float duration = 1;

    public void OnScore(int newScore)
    {
        score += newScore;
        scoreField.text = score.ToString();
    }

    float v = 0;
    private void Update()
    {
        v += Time.deltaTime / duration;
        if (v > 1)
        {
            gameController.BallChangeSize();
            v = 0;
        }
        slider.value = v;
    }
}
