using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CollectedCoins;
    public int TotalNumberOfCoins;
    public TextMeshProUGUI CoinCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.TotalNumberOfCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;
        Debug.Log("Total number of coins to collect: " + this.TotalNumberOfCoins);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CollectedCoins >= this.TotalNumberOfCoins)
        {
            Debug.Log("You won!");
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void CoinCollected()
    {
        this.CollectedCoins = this.CollectedCoins + 1;
        Debug.Log("Collected " + this.CollectedCoins + " / " + this.TotalNumberOfCoins + " coins.");
        CoinCounter.text = "Coins: " + this.CollectedCoins + " / " + this.TotalNumberOfCoins;
    }
}