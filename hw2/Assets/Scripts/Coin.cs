using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called when an object collides with the coin
    private void OnTriggerEnter(Collider otherObject)
    {
        //Debug.Log("An object entered the coin's trigger area");
        FindFirstObjectByType<GameManager>().CoinCollected();

        //Destroy the coin when the player collides with it (collect it)
        Destroy (this.gameObject);
    }
}
