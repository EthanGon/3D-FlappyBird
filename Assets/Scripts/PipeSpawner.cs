using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject[] pipes;
    [SerializeField] private float spawnTime = 3.0f;
    private float minSpawnTime = 3.0f;
    private float maxSpawnTime = 5.0f;
    [SerializeField] private float pipeSpeed = 50.0f;
    [SerializeField] private float maxY = 12.0f;
    [SerializeField] private float minY = -8.0f;
    private float timer = 0;

    private void Start()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    private void Update()
    {
        if (timer <= spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = pipes[Random.Range(0, pipes.Length)];

        float randomYPos = Random.Range(maxY, minY);
        Vector3 pipeVector = new Vector3(transform.position.x, randomYPos, transform.position.z);

        GameObject newPipe = Instantiate(pipe, pipeVector, Quaternion.identity);
        newPipe.GetComponent<Pipe>().SetPipeSpeed(pipeSpeed);
       
       
        Debug.Log(transform.position);
    }

}
