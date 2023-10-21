using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanic : MonoBehaviour
{

    public GameObject obj;

    private void Start()
    { 
        Create();
    }

    private void Create()
    {

        for (int i = 0; i < 5;)
        {
            Invoke("Create", Random.Range(2f, 4f));
            GameObject EnemyObject = Instantiate(obj, new Vector2(0, 10), Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        }

    }

}
