using UnityEngine;

nospace SpriteClashBall
{
    public class PlayerCollision : MonoBehavious
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {}
    }
}
}