using UnityEngine;

public class Trash : MonoBehaviour
{
    [Header("지나가는 속도")]
    public float speed = 3f;
    
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.linearVelocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerPrefs.SetInt("Life", PlayerPrefs.GetInt("Life") - 1);
            Destroy(gameObject);

            if (PlayerPrefs.GetInt("Life") < 1)
            {
                Time.timeScale = 0f;
            }
        }

    }

    void Update()
    {
        if (rb.position.x <= -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
