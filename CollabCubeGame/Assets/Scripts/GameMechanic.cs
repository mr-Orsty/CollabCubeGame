using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float initialSpawnInterval = 3.0f;
    public float minSpawnInterval = 0.2f;
    public float spawnIntervalDecrease = 0.2f;

    private float currentSpawnInterval;
    private float timer = 0.0f;

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentSpawnInterval)
        {
            GameObject newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(Random.Range(-8, 8), 10, 0);

            timer = 0.0f;

            if (currentSpawnInterval > minSpawnInterval)
            {
                currentSpawnInterval -= spawnIntervalDecrease;
            }
        }
    }
}
