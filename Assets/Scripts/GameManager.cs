using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreTextLabel;
    [SerializeField] private GameObject startGameScreen;
    [SerializeField] private GameObject endGameScreen;
    [SerializeField] private GameObject highScoreTextLabel;
    [SerializeField] private TextMeshProUGUI highScoreText;
    
    private int playerScore = 0;
    public static bool gameOver = false;

    private void Start()
    {
        instance = this;
        endGameScreen.SetActive(false);
        scoreText.text = playerScore.ToString();
        scoreTextLabel.SetActive(false);

        highScoreText.text = PlayerPrefs.GetInt("MaxScore").ToString();

    }

    public static GameManager GetGameManager()
    {
        return instance;
    }

    public void AddScore(int amount)
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
        Debug.Log("Scored a point!");
    }

    public int GetScore()
    {
        return playerScore;
    }

    public void StartGame()
    {
        startGameScreen.SetActive(false);
        PlayerManager.GetInstance().SetPlayerMoveState(true);
        PipeSpawner.GetPipeSpawner().SetActiveState(true);
        scoreTextLabel.SetActive(true);
        highScoreTextLabel.SetActive(false);
    }

    public bool IsGameOver() 
    { 
        return gameOver;
    }

    public void SetGameOver(bool state)
    {
        gameOver = state;

        if (state) 
        { 
            endGameScreen.SetActive(true);
        }

        
    }


   

}
