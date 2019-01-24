using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public GameObject titleScreen;

    public GameObject gameOverScreen;

    public GameObject player;

    public GameObject firstPatform;

    public GameObject scoreBoard;

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void ShowTitleScreen()
    {
        titleScreen.SetActive(true);
    }

    public void HideTitleScreen()
    {
        titleScreen.SetActive(false);
        scoreText.text = "Score: ";
    }

    public void ShowGameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void HideGameOver()
    {
        gameOverScreen.SetActive(false);
    }

    public void ShowScore()
    {
        scoreBoard.SetActive(true);
    }

    public void HideScore()
    {
        scoreBoard.SetActive(false);
    }

}
