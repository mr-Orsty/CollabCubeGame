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

    public TMP_Text statusText;
    private bool waitingForPlayers = true;

    private float currentSpawnInterval;
    private float timer = 0.0f;

    private void Start()
    {
        currentSpawnInterval = initialSpawnInterval;

        statusText = GameObject.Find("StatusText").GetComponent<TMP_Text>();
        UpdateStatusText();
    }

    private void UpdateStatusText()
    {
        if (waitingForPlayers)
        {
            if (PhotonNetwork.InRoom)
            {
                if (PhotonNetwork.CurrentRoom.PlayerCount < 2)
                {
                    statusText.text = "Waiting For Other Players...";
                }
                else
                {
                    statusText.text = "";
                    waitingForPlayers = false;
                }
            }
        }
    }

    public void OnPlayerJoinedRoom(Player newPlayer)
    {
        UpdateStatusText();
    }

    public void OnPlayerLeftRoom(Player otherPlayer)
    {
        UpdateStatusText();
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
