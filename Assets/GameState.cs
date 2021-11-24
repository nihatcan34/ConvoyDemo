using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Atackers atackers;
    public Score score;
    public Player player;
    public GameObject finishPanel;
    public Text finishScoreText;
    public string state;
    // Start is called before the first frame update
    void Start()
    {
        state = "start";
    }

    public void GameStateSelect()
    {
        if(state == "start")
        {
            state = "break";
        }
    }

    private void Update()
    {
        if (state == "start")
        {
            score.ScoreUp();
            Debug.Log("Start");
        }
        
        if (state == "break")
        {
            finishPanel.SetActive(true);
            StopCoroutine(atackers.SpawnAtackerCar());
            finishScoreText.text = "Score " + score.score.ToString("n0");
            state = "";
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
