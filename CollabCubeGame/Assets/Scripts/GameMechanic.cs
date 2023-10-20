using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemySpawnInterval = 1.0f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, enemySpawnInterval);
    }

    private void SpawnEnemy()
    {
        GameObject Enemy = Instantiate(enemyPrefab, new Vector2(Random.Range(-6, 6), 10), Quaternion.identity);
    }
}