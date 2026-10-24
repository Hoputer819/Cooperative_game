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
        speed = 2f + Mathf.Log(1 + Time.timeSinceLevelLoad * 0.1f);
        rb.linearVelocity = Vector2.down * speed;
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

        else if (other.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }


}
