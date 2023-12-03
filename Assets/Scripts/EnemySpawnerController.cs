using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float x_position_generation; 
    void Start()
    {
        Invoke("CreateEnemy", 2);
    }
    void Update()
    {
        x_position_generation = Random.Range(-7.56f, 7.56f);
    }
    void CreateEnemy()
    {
        Instantiate(enemyPrefab,new Vector2(x_position_generation, 3.9f),enemyPrefab.transform.rotation);
        Invoke("CreateEnemy", 2);
    }
}
