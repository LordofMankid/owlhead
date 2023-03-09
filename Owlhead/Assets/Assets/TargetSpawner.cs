using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 3;
    public float heightOffset = 10;
    public float distOffset = 80;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnEnemy();
            timer = 0;
        }
    }

    void spawnEnemy()
    {
        float highestPoint = transform.position.y + heightOffset;
        float furthestPoint = transform.position.x + distOffset;;
        Instantiate(enemy, new Vector3(Random.Range(3, furthestPoint), Random.Range(1, highestPoint), Random.Range(3, furthestPoint)), transform.rotation);
    }
}
