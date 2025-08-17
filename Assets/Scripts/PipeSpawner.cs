using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject[] pipes;
    [SerializeField] private float spawnTime = 3.0f;
    [SerializeField] private float timer = 0;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Update()
    {
        if (timer <= spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = pipes[Random.Range(0, pipes.Length)];

        Instantiate(pipe, transform.position, Quaternion.identity);
       
        Debug.Log(transform.position);
    }

}
