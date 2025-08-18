using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject startGameScreen;
    [SerializeField] private GameObject scoreTextLabel;
    private int playerScore = 0;

    private void Start()
    {
        instance = this;
        scoreText.text = playerScore.ToString();
        scoreTextLabel.SetActive(false);

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
    }

   

}
