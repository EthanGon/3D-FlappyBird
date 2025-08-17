using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        rb.linearVelocity = new Vector3 (rb.linearVelocity.x, rb.linearVelocity.y, -moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.GetGameManager().AddScore(1);
        }
    }

    public void SetPipeSpeed(float speed)
    {
        this.moveSpeed = speed;
    }
}
