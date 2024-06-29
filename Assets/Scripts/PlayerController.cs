using Unity;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

void Start()
    {rb = GetComponent<Rigidbody2D>(); }

void Update()
{
    float moveX = Input.GetAxis("Horizontal");
    float moveY = Input.GetAxis("Vertical");
    Vector2m movement = new Vector2m(moveX, moveY);
    rb.velocity = movement * moveSpeed;
}
}
