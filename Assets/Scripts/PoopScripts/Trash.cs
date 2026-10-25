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
        if (transform.position.x > 0)
        {
            rb.linearVelocity = new Vector2(-speed, 0);
        }

        else
        {
            rb.linearVelocity = new Vector2(speed, 0);
        }
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
        if (rb.position.x <= -5.8f)
        {
                Destroy(gameObject);
        }

        else if(rb.position.x >= 5.8f)
        {
                Destroy(gameObject);
        }
    }
}
