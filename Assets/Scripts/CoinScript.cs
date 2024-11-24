using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Check if the coin collided with a Player object
        if (col.gameObject.name == "Player")
        {
            //Increase score
            GameState.Score++;

            //Let CoinSpawner know that the coin was just collected and it should spawn a new one
            CoinSpawner coinSpawnerObject = GameObject.FindAnyObjectByType<CoinSpawner>();
            coinSpawnerObject.shouldSpawnCoin = true;

            //Destroy this coin object
            Destroy(gameObject);
        }
    }
}
