using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float camZOffset = 5.0f;

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - camZOffset);
    }
}
