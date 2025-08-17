using UnityEngine;

public class LavaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject lavaPrefab;
    private Transform player;
    [SerializeField] private float playerDistancePoint;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void Update()
    {
        if (player.position.z >= transform.position.z + playerDistancePoint) ;
    }

    

}
