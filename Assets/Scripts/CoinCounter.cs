using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;
    public GameObject coins;
    public TMPro.TextMeshProUGUI coinText;
    private int totalCoins;
    private int collectedCoins = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Destroying CoinCounter: " + name);
            Destroy(gameObject);
        }
        totalCoins = coins.transform.childCount;
        Debug.Log(totalCoins);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinText.text = "Kolikot: " + collectedCoins;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CoinCollected()
    {
        collectedCoins += 1;
        coinText.text = "Kolikot: " + collectedCoins;
        if (collectedCoins == totalCoins)
        {
            coinText.text = "Kaikki kerätty";
            Time.timeScale = 0;
        }
    }
}
