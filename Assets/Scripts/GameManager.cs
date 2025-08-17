using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int playerScore = 0;

    private void Start()
    {
        instance = this;
        scoreText.text = playerScore.ToString();
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

}
