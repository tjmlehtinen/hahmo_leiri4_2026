using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput = new Vector2();
    private Rigidbody2D body;
    private float moveSpeed = 5f;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        body.linearVelocity = moveInput * moveSpeed;
    }
}
