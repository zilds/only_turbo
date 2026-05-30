using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;

    private Rigidbody2D rb;
    private float moveY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveY = Keyboard.current.wKey.isPressed ? 1 :
                Keyboard.current.sKey.isPressed ? -1 : 0;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, moveY * playerSpeed);
    }
}