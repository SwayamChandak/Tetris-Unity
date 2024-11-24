using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScene;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        scoreText.text = "Score: " + playerScore;
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScene.SetActive(true);
    }
}
