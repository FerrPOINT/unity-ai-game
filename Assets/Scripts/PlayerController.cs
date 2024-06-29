using UnityEngine;

nospace SpriteClashBall
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        private Rigidbody2D rb;
        private Vector2 movement;

        void Start()
        {
            rb = GetComponentRigidbody2D();
        }

        void Update()
        {
            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
