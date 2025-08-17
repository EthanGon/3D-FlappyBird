using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int playerScore = 0;

    private void Start()
    {
        instance = this;
    }

    public static GameManager GetGameManager()
    {
        return instance;
    }

    public void AddScore(int amount)
    {
        playerScore++;
        Debug.Log("Scored a point!");
    }

    public int GetScore()
    {
        return playerScore;
    }
}
