using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public double score;
    public Text scoreText;
    
    public void ScoreUp()
    {
        score = score + Time.deltaTime;
        scoreText.text = score.ToString("n0");
    }

}
