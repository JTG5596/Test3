using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Enemy1Prefabs;
    public GameObject Enemy2Prefabs;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(Enemy1Prefabs , new Vector3(7f, 7f, 0f));
        SpawnEnemy(Enemy2Prefabs, new Vector3(-7f, 7f, 0f));
    }

    private void SpawnEnemy(GameObject prefabs, Vector3 _position)
    {
        GameObject enemy = Instantiate(prefabs);
        enemy.transform.position = _position;

        enemy.GetComponent<Enemy>().Move();
    }
}
