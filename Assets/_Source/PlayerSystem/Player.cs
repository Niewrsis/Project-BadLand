using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [Header("Attributes")]
        public float MoveSpeed;
        public float JumpForce;
        public float RotationSpeed;

        private Rigidbody2D _rb;
        private Transform _transform;
        public Transform Transform => _transform;
        public Rigidbody2D Rb => _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _transform = GetComponent<Transform>();
        }
    }
}