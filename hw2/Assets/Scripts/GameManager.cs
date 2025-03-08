using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int collectedCoins;
    public int totalNumberOfCoins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.totalNumberOfCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;
        Debug.Log("Coins To Find: " + totalNumberOfCoins);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.collectedCoins == this.totalNumberOfCoins)
        {
            Debug.Log("You won!");
            Debug.Break();
        }
    }

    public void CoinCollected()
    {
        this.collectedCoins++;
        Debug.Log("Coins Collected: " + this.collectedCoins + "/" + this.totalNumberOfCoins);

    }
}
