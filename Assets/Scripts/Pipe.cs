using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.GetGameManager().AddScore(1);
    }
}
