using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 20;
    public GameObject winText;
    public GameObject gameOverText;
    public GameObject ball;
    public PlayerController player;

    public TextMeshProUGUI timerText;

    bool gameOver = false;
    bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft >= 0 && !win)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("f1");
        }

        if(timeLeft <= 0 && !win)
        {
            GameOver();
        }
    }

    public void GameWin()
    {
        win = true;
        winText.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        player.enabled = false;
        gameOver = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
