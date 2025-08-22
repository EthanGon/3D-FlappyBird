using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject[] pipes;
    private static PipeSpawner instance;
    private float timer = 0;
    private float minSpawnTime = 3.0f;
    private float maxSpawnTime = 5.0f;
    private float maxY = 12.0f;
    private float minY = -8.0f;
    private static bool allowSpawning;
    [SerializeField] private float spawnTime = 3.0f;
    [SerializeField] private float pipeSpeed = 50.0f;
    [SerializeField] private float ySpeed = 3.0f;
    
    

    private void Start()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        allowSpawning = false;
        instance = this;
    }

    private void Update()
    {
        if (allowSpawning) 
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
    }

    private void SpawnPipe()
    {
        GameObject pipe = pipes[Random.Range(0, pipes.Length)];

        float randomYPos = Random.Range(maxY, minY);
        Vector3 pipeVector = new Vector3(transform.position.x, randomYPos, transform.position.z);

        GameObject newPipe = Instantiate(pipe, pipeVector, Quaternion.identity);
        newPipe.GetComponent<Pipe>().SetPipeSpeed(pipeSpeed);
        newPipe.GetComponent<Pipe>().SetYSpeed(ySpeed);


        Debug.Log(transform.position);
    }

    public static PipeSpawner GetPipeSpawner()
    {
        return instance;
    }

    public void SetActiveState(bool state)
    {
        allowSpawning = state;
    }

    public Vector3[] GetMinMaxY()
    {
        Vector3 min = new Vector3(transform.position.x, minY, transform.position.z);
        Vector3 max = new Vector3(transform.position.x, maxY, transform.position.z);
        Vector3[] minMaxPoint = { min, max };
        return minMaxPoint;

    }

}
