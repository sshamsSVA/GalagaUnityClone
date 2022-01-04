using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy() 
    {
        float randomX = Random.Range(-9f, 9.0f);
        float randomY = Random.Range(-1.0f, 3.0f);
        Instantiate(enemyPrefab, new Vector2(randomX, -1.0f), Quaternion.identity);
    }
}
