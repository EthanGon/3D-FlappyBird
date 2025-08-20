using UnityEngine;

public class Pipe : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed = 2.0f;
    private float ySpeed = 5.0f;
    private bool moveYDir = false;
    private Vector3[] yPoints;
    private int currentDirIndex = 0;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveYDir = Random.value < 0.5f;
        yPoints = PipeSpawner.GetPipeSpawner().GetMinMaxY();

        if (moveYDir)
        {
            ySpeed = Random.value < 0.5f ? -ySpeed : ySpeed;

            if (ySpeed < 0)
            {
                currentDirIndex = 0;
            } 
            else
            {
                currentDirIndex = 1;
            }

        }
        
    }

    private void Update()
    {
        
        if (!moveYDir)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, -moveSpeed);
        } 
        else
        {
            
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, ySpeed, -moveSpeed);

            if (Mathf.Abs((transform.position.y - yPoints[currentDirIndex].y)) < .1f) 
            {
                Debug.Log("flip dir");
                currentDirIndex++;
                if (currentDirIndex >= yPoints.Length)
                {
                    currentDirIndex = 0;
                }
                ySpeed *= -1.0f;
            }

        }

        if (transform.position.z <= -25)
        {
            Destroy(this.gameObject);
            Debug.Log("Pipe Destroyed");
        }

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

    public void SetYSpeed(float speed)
    {
        this.ySpeed = speed;
    }
}
