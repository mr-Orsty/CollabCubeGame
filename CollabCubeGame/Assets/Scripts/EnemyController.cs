using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector2 detectionSize = new Vector2(2.0f, 1.0f);

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, detectionSize, 0);
    }
}
