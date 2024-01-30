using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject GemPrefab;
    public GameObject GreenGemPrefab;

    public float SpawnInterval = 1f;
    public float GreenSpawnChance = 0.1f;

    public Vector2 MinMaxPos;

    public bool isSpawning = false;
    public bool isTimesUp = false;

    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimesUp)
            return;

        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            float diceroll = Random.Range(0f, 100f);

            if (diceroll <= GreenSpawnChance)
            {
                GameObject.Instantiate(GreenGemPrefab, new Vector3(Random.Range(MinMaxPos.x, MinMaxPos.y), transform.position.y, transform.position.z),
                    Quaternion.Euler(0, 0, Random.Range(-360, 360)));
            }

            else
            {
                GameObject.Instantiate(GemPrefab, new Vector3(Random.Range(MinMaxPos.x, MinMaxPos.y), transform.position.y, transform.position.z),
                    Quaternion.Euler(0, 0, Random.Range(-360, 360)));
            }


            spawnTimer = SpawnInterval;
        }
    }
}
