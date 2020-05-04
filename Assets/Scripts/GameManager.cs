using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text gameoverText;
    private bool gameover;
    void Start()
    {
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                PlayerPrefs.SetInt(ScorePrefs.SCORE, 0);
                PlayerPrefs.SetInt(ScorePrefs.PREVIOUS_SCORE, 0);
                SceneManager.LoadScene("Menu");
            }
        }
    }
    public void GameOver()
    {
        gameoverText.text = "Game Over";
        gameover = true;
        PlayerPrefs.SetInt(ScorePrefs.SCORE, PlayerPrefs.GetInt(ScorePrefs.PREVIOUS_SCORE));
    }
}
