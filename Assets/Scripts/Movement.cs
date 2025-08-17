using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float sideSpeed = 5.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
        }

        float dirX = Input.GetAxis("Horizontal");
        

        rb.linearVelocity = new Vector3(dirX * sideSpeed, rb.linearVelocity.y, speed);
    }

    public void ChangeSpeed(float speed)
    {
        this.speed = speed;
    }
    

}
