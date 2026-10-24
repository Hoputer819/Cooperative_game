using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("이동 설정")]
    public float moveSpeed = 3f;
    public float jumpHeight = 5f;

    [Header("바닥 체크 설정")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.05f;
    public LayerMask groundLayer;

    private PlayerInput playerInput;
    private InputAction crouchAction;
    public Vector2 originalSize;
    public Vector2 originalOffset;
    private bool isCrouching;

    private float leftScreen;
    private float rightScreen;
    private float halfBody;
    private float clampedX;

    private Vector2 moveInput;
    private Rigidbody2D rb;
    private CapsuleCollider2D col;
    private bool isGrounded;
    private float jumpCooltime = 0f;

    public Timer timer;
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent <CapsuleCollider2D>();
        playerInput = GetComponent<PlayerInput>();
        anim = GetComponent<Animator>();
        crouchAction = playerInput.actions["Crouch"];

        originalOffset = col.offset;
        originalSize = col.size;

        halfBody = (originalSize.x / 2) * 3;
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

        bool wantCrouch = crouchAction.IsPressed();
        if(wantCrouch != isCrouching)
        {
            SetCrouch(wantCrouch);
        }

    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (isCrouching) return;

        if (value.isPressed == true && isGrounded && anim.GetCurrentAnimatorStateInfo(0).IsName("Walk")) {
            anim.SetTrigger("Jump");
            rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, jumpHeight);
            jumpCooltime = 0.52f;
        }
    }

    public void SetCrouch(bool crouch)
    {

        if (crouch)
        {
            anim.SetBool("IsCrouching", crouch);
            col.offset = new Vector2(originalOffset.x, originalOffset.y - originalSize.y / 4);
            col.size = new Vector2(originalSize.x / 2, originalSize.y / 2);
            isCrouching = true;
        }

        else
        {
            anim.SetBool("IsCrouching", crouch);
            col.offset = originalOffset;
            col.size = originalSize;
            isCrouching = false;
        }
    }

    private void FixedUpdate()
    {
        leftScreen = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightScreen = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        float max = rightScreen - halfBody;
        float min = leftScreen + halfBody;

        if (isCrouching)
        {
            moveSpeed = 1f;
        }
        else
        {
            moveSpeed = 3f;
        }

        float moveX = moveInput.x * moveSpeed;

        if (rb.position.x >= max && moveX > 0)
            moveX = 0;
        if (rb.position.x <= min && moveX < 0)
            moveX = 0;

        rb.linearVelocity = new Vector2(moveX, rb.linearVelocity.y);

        clampedX = Mathf.Clamp(rb.position.x, min, max);
        rb.position = new Vector2(clampedX, rb.position.y);
    }
}
