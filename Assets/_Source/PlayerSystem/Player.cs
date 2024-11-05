using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [Header("Attributes")]
        public float MoveSpeed;
        public float JumpForce;

        private Rigidbody2D _rb;
        public Transform Transform => transform;
        public Rigidbody2D Rb => _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    }
}