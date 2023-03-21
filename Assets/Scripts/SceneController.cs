using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);
    private Vector3[] iguanaSpawnPoints;
    public float fireRate = 2.0f;
    private float nextFire = 0.0f;
    private int numberOfEnemies = 5;
    private GameObject[] enemies;
    [SerializeField] private WanderingIguana iguanaPrefab;
    private WanderingIguana iguana;
    private WanderingIguana[] iguanas;
    private int numberOfIguanas = 5;
    // Start is called before the first frame update
    void Start()
    {
        iguanaSpawnPoints = new Vector3[numberOfIguanas];
        enemies = new GameObject[numberOfEnemies];
        iguanas = new WanderingIguana[numberOfIguanas];
        iguanaSpawnPoints[0] = new Vector3(0, 0, 8.67f);
        iguanaSpawnPoints[1] = new Vector3(-23.35f, 0, 8.67f);
        iguanaSpawnPoints[2] = new Vector3(-23.35f, 0, 21.98f);
        iguanaSpawnPoints[3] = new Vector3(-17.83f, 0, 21.98f);
        iguanaSpawnPoints[4] = new Vector3(-11.63f, 0, 21.98f);
        for (int i = 0; i < numberOfIguanas; i++)
        {
            if (iguanas[i] == null)
            {
                iguana = Instantiate(iguanaPrefab);
                iguana.transform.position = iguanaSpawnPoints[i];
                float angle = Random.Range(0, 360);
                iguana.transform.Rotate(0, angle, 0);
                iguanas[i] = iguana;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < numberOfEnemies; i++)
        {
            if (enemies[i] == null)
            {
                enemy = Instantiate(enemyPrefab);
                enemy.transform.position = spawnPoint;
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);
                enemies[i] = enemy;
            }
        }
        
    }
}
