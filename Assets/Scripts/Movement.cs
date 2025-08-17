using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float speed = 5.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
        }

        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, speed);
    }

    public void ChangeSpeed(float speed)
    {
        this.speed = speed;
    }

}
