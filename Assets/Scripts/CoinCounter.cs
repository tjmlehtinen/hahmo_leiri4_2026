using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public GameObject coins;
    private int totalCoins;

    void Awake()
    {
        totalCoins = coins.transform.childCount;
        Debug.Log(totalCoins);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
