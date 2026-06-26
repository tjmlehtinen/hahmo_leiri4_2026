using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        CoinCounter.Instance.CoinCollected();
        Destroy(gameObject);
    }
}
