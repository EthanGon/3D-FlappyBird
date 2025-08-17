using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float camZOffset = 5.0f;
    [SerializeField] private float camYOffset = 5.0f;
    [SerializeField] private float camXOffset = 5.0f;


    [SerializeField] private float camXMin = 2.0f;
    [SerializeField] private float camXMax = 2.0f;


    private void Update()
    {
        

        if (player.position.x <= camXMax && player.position.x >= camXMin)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + camYOffset, player.transform.position.z + camZOffset);
        }

    }
}
