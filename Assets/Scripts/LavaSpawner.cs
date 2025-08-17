using UnityEngine;

public class LavaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject lavaPrefab;
    [SerializeField] private Transform player;
    [SerializeField] private float playerDistancePoint;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpawnLavaPlane();
        }
    }

    private void SpawnLavaPlane()
    {
        Vector3 nextLavaPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.z);
        Instantiate(lavaPrefab, nextLavaPos, Quaternion.identity);

    }
    

}
