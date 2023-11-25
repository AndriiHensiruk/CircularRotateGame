using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject prey;
    private float randomY, randomX;
    private Vector2 whereToSpawn;
    public float spawnDelay;
    private float nextSpawnEnemy =  0.0f;
    private float nextSpawnPrey = 0.1f;

    
    void Update()
    {
        if(Time.time > nextSpawnEnemy)
        {
            for(int i = 0; i < 3; i++)
            {
                Spawn(enemy);
            }
            Spawn(prey);
                  
        }
        
    }

    public void Spawn(GameObject _gmb)
    {
        nextSpawnEnemy = Time.time + spawnDelay;
        randomY = Random.Range(-1, 2);
        randomX = Random.Range(-5, -2);
        whereToSpawn = new Vector2(randomX, randomY);
        GameObject Object = Instantiate(_gmb, whereToSpawn, Quaternion.identity);
        Destroy(Object, 14f);        
    }

    
}
