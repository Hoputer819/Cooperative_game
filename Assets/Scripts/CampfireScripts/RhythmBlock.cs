using Unity.VisualScripting;
using UnityEngine;

public class RhythmBlock : MonoBehaviour
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
        rb.linearVelocity = new Vector2(0, -speed);
    }

    void Update()
    {
        if(rb.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
