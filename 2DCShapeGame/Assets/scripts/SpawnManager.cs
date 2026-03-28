//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject Enemy1Prefabs;
    //public GameObject Enemy2Prefabs;

    public GameObject[] Enemy3prefabs;

    public Point[] Points =
    {
        new Point(-7,2),
        new Point(-7,5),
        new Point(-7,8),
        new Point(7,2),
        new Point(7,5),
        new Point(7,8),
    };



    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy(Enemy1Prefabs , new Vector3(7f, 7f, 0f));
        //SpawnEnemy(Enemy2Prefabs, new Vector3(-7f, 7f, 0f));
    }

    public void SpawnEnemy(GameObject prefabs, Vector3 _position)
    {
        GameObject enemy = Instantiate(prefabs);
        enemy.transform.position = _position;

        enemy.GetComponent<Enemy>().Move();
    }

    public void SpawnEnemy()
    {
        //GameObject prefab = Itemprefabs[Random.Range(0, Itemprefabs.Length)];

        //Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        //SpawnItem(prefab, pos);
        //Invoke("SpawnRandom", 1f);

        GameObject prefab = Enemy3prefabs[Random.Range(0, Enemy3prefabs.Length)];
        Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        SpawnEnemy(prefab, pos);
        Invoke("SpawnEnemy", 0.5f);
    }
}
