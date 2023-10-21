using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 15.0f;

    private void Update()
    {
        if (transform.position.y <= -10)
        {
            Debug.Log("Destroying Enemy at Y position: " + transform.position.y);
            Destroy(gameObject);
        }
    }
}
