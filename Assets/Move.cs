using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public float moveSpeed = 100f;

    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    private bool isFacingRight = true;
    private float lastHorizontalInput = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        float horizontal = -Input.GetAxisRaw("Vertical");
        float vertical = Input.GetAxisRaw("Horizontal");

        moveInput = new Vector3(horizontal, 0f, vertical).normalized;
        moveVelocity = moveInput * moveSpeed;

        if (animator != null)
        {


            animator.SetFloat("Speed", moveVelocity.magnitude);


        }

        if (spriteRenderer != null)
        {
            if (Mathf.Abs(horizontal) > 0.1f) // Only flip if the horizontal input is significant
            {
                if (horizontal > 0.1f && !isFacingRight) // Moving right
                {
                    spriteRenderer.flipX = false;
                    isFacingRight = true;
                }
                else if (horizontal < -0.1f && isFacingRight) // Moving left
                {
                    spriteRenderer.flipX = true;
                    isFacingRight = false;
                }
            }

            // Track the last horizontal input to handle small fluctuations in direction


        }
        lastHorizontalInput = horizontal;
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}