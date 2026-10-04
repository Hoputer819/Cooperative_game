using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("이동 설정")]
    public float moveSpeed = 1.5f;
    public float jumpHeight = 3f;

    [Header("바닥 체크 설정")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.05f;
    public LayerMask groundLayer;

    private Vector2 moveInput;
    private Rigidbody2D rb;
    private bool isGrounded;
    private float jumpCooltime = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (jumpCooltime > 0)
        {
            jumpCooltime -= Time.deltaTime;
            isGrounded = false;
        }
        else
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        }       
 }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {

        if (value.isPressed == true && isGrounded) {
            rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, jumpHeight);
            jumpCooltime = 0.52f;
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, rb.linearVelocity.y);
    }
}
