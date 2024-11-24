using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    public List<GameObject> ExistingPlatforms = new List<GameObject>();
    public bool shouldSpawnCoin = false;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawnCoin)
        {
            shouldSpawnCoin = false;
            SpawnCoin();
        }
    }

    void SpawnCoin()
    {
        GameObject newCoin = Instantiate(CoinPrefab);
        var randomPlatform = ExistingPlatforms[Random.Range(0, ExistingPlatforms.Count)].gameObject;
        newCoin.transform.position = randomPlatform.transform.position + new Vector3(0, 1f, 0);
    }
}