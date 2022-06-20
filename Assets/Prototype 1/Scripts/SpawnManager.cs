using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerUpPrefab;
    public Transform playerSP;
    public Transform enemySP;
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        //Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
    }
    private void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
           // Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
         Instantiate(enemyPrefab, enemySP.transform.position/*GenerateSpawnPosition()*/, enemyPrefab.transform.rotation);
        }
    }
   
    public void Respawn(GameObject player)
    {
        player.transform.position = playerSP.position;
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(spawnRange, spawnRange);
        float spawnPosZ = Random.Range(spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
