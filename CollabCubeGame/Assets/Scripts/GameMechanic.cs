using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
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
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 10, 0);
            SpawnEnemy(spawnPosition);

            timer = 0.0f;

            if (currentSpawnInterval > minSpawnInterval)
            {
                currentSpawnInterval -= spawnIntervalDecrease;
            }
        }
    }

    private void SpawnEnemy(Vector3 spawnPosition)
    {
        GameObject newEnemy = PhotonNetwork.Instantiate(enemyPrefab.name, spawnPosition, Quaternion.identity);
    }
}
