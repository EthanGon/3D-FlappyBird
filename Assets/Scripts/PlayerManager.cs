using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager playerInstance;
    private Movement playerMovement;

    private void Start()
    {
        playerInstance = this;
        playerMovement = GetComponent<Movement>();
    }

    public static PlayerManager GetInstance()
    {
        return playerInstance;
    }

    public Vector3 GetPos()
    {
        return this.transform.position;
    }

    public void SetPlayerMoveState(bool state)
    {
        playerMovement.SetCanMove(state);
    }

    private void OnCollisionEnter(Collision collision)
    {
        SetPlayerMoveState(false);
        GameManager.GetGameManager().SetGameOver(true);
        GetComponent<Collider>().enabled = false;
        Debug.Log("Player Died");

        if (GameManager.GetGameManager().GetScore() > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", GameManager.GetGameManager().GetScore());
        }
    }

}
