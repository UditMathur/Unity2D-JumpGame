using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool showTitleScreen = true;
    public bool gameOver = false;

    private UIManager _uiManager;

    void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    void Update()
    {
        StartScreen();
    }

    public void StartScreen()
    {
        if (showTitleScreen == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _uiManager.HideTitleScreen();
                showTitleScreen = false;
                _uiManager.ShowScore();
                _uiManager.HideGameOver();
                gameOver = false;
                Instantiate(_uiManager.player, Vector3.zero, Quaternion.identity);
                Instantiate(_uiManager.firstPatform, new Vector3(1.81f, -2.81f, 0), Quaternion.identity);
            }

        }
    }

}
