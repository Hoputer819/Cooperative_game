using UnityEngine;

public class Poop : MonoBehaviour
{
    [Header("떨어지는 속도")]
    public float speed = 2f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
        }

        else if(other.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
