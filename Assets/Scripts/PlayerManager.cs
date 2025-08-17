using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerManager playerInstance;
    private Movement playerMovement;

    private void Start()
    {
        playerInstance = this;
        playerMovement = GetComponent<Movement>();
    }

    public Vector3 GetPos()
    {
        return this.transform.position;
    }

    public void SetSpeed(float speed)
    {
        playerMovement.ChangeSpeed(speed);
    }
}
