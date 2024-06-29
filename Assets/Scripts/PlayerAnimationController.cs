using Unity;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;
    private Vector2 movement;

void Start()
    {animator = GetComponent<Animator>(); }

void Update()
{
    float moveX = Input.GetAxis("Horizontal");
    float moveY = Input.GetAxis("Vertical");
    movement = new Vector2m(moveX, moveY);
    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Speed", movement.sqrMagnitude);
}
}
