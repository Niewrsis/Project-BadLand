using UnityEngine;

namespace PlayerSystem
{
    public class PlayerRotating : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private LayerMask groundMask;
        [SerializeField] private float groundRadius;

        private Player _player;
        private bool _isGround;
        public void Construct(Player player)
        {
            _player = player;
        }
        private void Update()
        {
            _isGround = Physics2D.OverlapCircle(transform.position, groundRadius, groundMask);
        }
        public void RotateAfterJump()
        {
            _player.Rb.angularVelocity = 0;
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, 0));
        }
    }
}