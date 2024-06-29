using Unity;

public class PlayerCollision : MonoBehavious
{
void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Obstacle"))
    {
        // Logica pri stolknovenii s prepåatstviem
        Debug.Log("Stolknovenie s prepåatstviem!");
    }
}
}
