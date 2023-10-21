using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float initialSpawnInterval = 4.0f;
    public float minSpawnInterval = 0.6f;
    public float spawnIntervalDecrease = 0.1f;

    private float currentSpawnInterval;
    private float timer = 0.0f;

    private void Start()
<<<<<<< HEAD
    { 
        Create();
=======
    {
        currentSpawnInterval = initialSpawnInterval;
>>>>>>> 24ffdb10bef449fdadd027958ed022d1425396ac
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentSpawnInterval)
        {
<<<<<<< HEAD
            Invoke("Create", Random.Range(2f, 4f));
            GameObject EnemyObject = Instantiate(obj, new Vector2(0, 10), Quaternion.Euler(0f, 0f, 0f)) as GameObject;
=======
            GameObject newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(Random.Range(-8, 8), 10, 0);

            timer = 0.0f;

            if (currentSpawnInterval > minSpawnInterval)
            {
                currentSpawnInterval -= spawnIntervalDecrease;
            }
>>>>>>> 24ffdb10bef449fdadd027958ed022d1425396ac
        }
    }
}
