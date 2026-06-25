using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("kolikkoon osui jotain");
        Destroy(gameObject);
    }
}
