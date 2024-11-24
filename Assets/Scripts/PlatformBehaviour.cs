using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CoinSpawner coinSpawnerObject = GameObject.FindObjectOfType<CoinSpawner>();
        coinSpawnerObject.ExistingPlatforms.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
