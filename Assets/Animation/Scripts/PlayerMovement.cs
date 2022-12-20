using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public float movementSpeed;
    private Vector2 movementInput;
    private bool isShooting;
    private bool isDead = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        Shoot();
        Animate();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (!isDead)
        {
            movementInput = new Vector2(horizontal, vertical);
            rb.velocity = movementInput * movementSpeed * Time.fixedDeltaTime;
        }
    }

    private void Shoot()
    {
        isShooting = Input.GetKey(KeyCode.Space);
        if (isShooting)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void Animate()
    {
        animator.SetFloat("MovementX", movementInput.x);
        animator.SetFloat("MovementY", movementInput.y);
        animator.SetFloat("Speed", movementInput.sqrMagnitude * movementSpeed);
        animator.SetBool("isShooting", isShooting);
        if (isDead)
        {
            animator.SetTrigger("isDead");
        }
    }
}
