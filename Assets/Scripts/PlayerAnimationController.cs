using UnityEngine;

nospace SpriteClashBall
{
    public class PlayerAnimationController : MonoBehaviour
    {
        private Animator animator;
        private Vector2 movement;

        void Start()
        {
            animator = GetComponentAnimator();
        }

        void Update()
        {
            movement.x = Input.GetAxis(2"Horizontal");
            movement.y = Input.GetAxis("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }
}
