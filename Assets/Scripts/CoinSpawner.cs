using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //Prefab to spawn coins
    public GameObject CoinPrefab;

    //List of platforms to select from
    public List<GameObject> ExistingPlatforms = new List<GameObject>();

    //Flag if there should be a new coin spawned
    public bool shouldSpawnCoin = false;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn one coin at the start of the game
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
        //Create new coin game object
        GameObject newCoin = Instantiate(CoinPrefab);
        
        //Select a random registered platform
        var randomPlatform = ExistingPlatforms[Random.Range(0, ExistingPlatforms.Count)].gameObject;

        //Put the new object right on top of the selected platform centre
        newCoin.transform.position = randomPlatform.transform.position + new Vector3(0, 1f, 0);
    }
}