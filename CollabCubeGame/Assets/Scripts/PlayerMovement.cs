using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEditor;

public class PlayerMovement : MonoBehaviourPun
{
    public TMP_Text textName;

    public float speed;
    PhotonView view;
    private Collider2D playerCollider;
    private EnemySpawnManager enemySpawnManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        view = GetComponent<PhotonView>();

        textName.text = view.Owner.NickName;

        enemySpawnManager = GameObject.Find("SpawnManager").GetComponent<EnemySpawnManager>();

        if (photonView.IsMine)
        {
            Vector3 spawnPosition = new Vector3(0, 0, 0);
            enemySpawnManager.photonView.RPC("SpawnEnemy", RpcTarget.All, spawnPosition);
        }
    }

    private void FixedUpdate()
    {
        if (view.IsMine)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3)moveAmount;
        }
    }
}
