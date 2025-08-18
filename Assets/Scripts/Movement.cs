using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private bool canMove;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float sideSpeed = 5.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        canMove = false;
    }

    private void Update()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
            }

            float dirX = Input.GetAxis("Horizontal");
            rb.linearVelocity = new Vector3(dirX * sideSpeed, rb.linearVelocity.y, rb.linearVelocity.z);
        }
        else
        {
            rb.linearVelocity = Vector3.zero;
            if (Input.GetKey(KeyCode.Space))
            {
                GameManager.GetGameManager().StartGame();
            }
        }

    }

    public void SetCanMove(bool state)
    {
        canMove = state;
    }

    
    

}
