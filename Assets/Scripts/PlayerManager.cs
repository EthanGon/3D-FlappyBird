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

}
