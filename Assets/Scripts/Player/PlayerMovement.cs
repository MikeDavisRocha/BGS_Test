using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;    
    public float movementSpeed;
    public Vector2 movementInput;
    public bool isShooting;
    public bool isDead = false;
    public float Horizontal { get; set; }
    public float Vertical { get; set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Horizontal = horizontal;
        Vertical = vertical;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("NPC"))
        {            
            collision.GetComponent<ShopMenuController>().ShowShopMenuUI();
        }
        else if (collision.tag.Equals("MoneyBag"))
        {
            MoneyController.Instance.IncreaseMoney(collision.GetComponent<MoneyBag>().Value);
            FindObjectOfType<AudioManager>().Play("GetCoins");
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("NPC"))
        {
            collision.GetComponent<ShopMenuController>().HideShopMenuUI();
        }
    }
}
