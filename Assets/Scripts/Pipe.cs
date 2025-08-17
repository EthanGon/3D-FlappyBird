using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.0f;

    private void Start()
    {
        

    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveSpeed) * Time.deltaTime;
    }



    private void OnTriggerEnter(Collider other)
    {
        GameManager.GetGameManager().AddScore(1);
    }

    public void SetPipeSpeed(float speed)
    {
        this.moveSpeed = speed;
    }
}
