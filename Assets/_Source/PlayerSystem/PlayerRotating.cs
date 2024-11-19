using UnityEngine;

namespace PlayerSystem
{
    public class PlayerRotating : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private LayerMask groundMask;
        [SerializeField] private float groundRadius;

        [Header("Attrubutes")]
        [SerializeField] private float rotationStep;

        private const float _circleDegrees = 360;
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
            if (DoMathAngle(_player.Rb.rotation) > 0)
            {
                _player.Rb.SetRotation(DoMathAngle(_player.Rb.rotation) - rotationStep);
            }
            else
            {
                _player.Rb.SetRotation(DoMathAngle(_player.Rb.rotation) + rotationStep);
            }

            if (_player.Rb.rotation <= rotationStep & _player.Rb.rotation >= -rotationStep) _player.Rb.SetRotation(0);
        }
        private float DoMathAngle(float num)
        {
            int a = Mathf.RoundToInt(num / _circleDegrees);
            return (float)(num - _circleDegrees * a);
        }
    }
}