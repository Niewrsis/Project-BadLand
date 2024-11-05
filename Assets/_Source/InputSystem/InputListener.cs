using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Player _player;
        private PlayerMovement _playerMovement;

        public void Construct(Player player)
        {
            _player = player;
        }

        private void Start()
        {
            _playerMovement = new();
        }

        private void Update()
        {
            ReadMoveInput();
            ReadJumpInput();
        }
        private void ReadMoveInput()
        {
            float xMove = Input.GetAxisRaw("Horizontal");
            _playerMovement.Move(xMove, _player);
        }
        private void ReadJumpInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _playerMovement.Jump(_player);
        }
    }
}