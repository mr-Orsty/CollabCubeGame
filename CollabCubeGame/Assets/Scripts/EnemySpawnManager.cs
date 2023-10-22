using Photon.Pun;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviourPun
{
    [SerializeField] private GameObject enemyPrefab;

    [PunRPC]
    void SpawnEnemy(Vector3 spawnPosition)
    {
        PhotonNetwork.Instantiate(enemyPrefab.name, spawnPosition, Quaternion.identity);
    }
}
