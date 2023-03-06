using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject npc;
    public Transform[] spawnLocation;
    public float spawnInterval = 5.0f;
    float timeUntilSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilSpawn = spawnInterval;
        spawnNPC();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            spawnNPC();
            timeUntilSpawn = spawnInterval;
        }
    }

    void spawnNPC()
    {
        int index = Random.Range(0, spawnLocation.Length);
        GameObject new_npc = Instantiate(npc, spawnLocation[index].position, Quaternion.identity);
    }
}
