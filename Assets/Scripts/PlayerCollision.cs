using Unity;

public class PlayerCollision : MonoBehavious
{
void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Obstacle"))
    {
        // Logica pri stolknovenii s prep�atstviem
        Debug.Log("Stolknovenie s prep�atstviem!");
    }
}
}
