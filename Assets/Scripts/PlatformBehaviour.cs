using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Get CoinSpawner object on the scene
        CoinSpawner coinSpawnerObject = GameObject.FindAnyObjectByType<CoinSpawner>();

        //Add this platform to its list of platforms when it's first created
        coinSpawnerObject.ExistingPlatforms.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
