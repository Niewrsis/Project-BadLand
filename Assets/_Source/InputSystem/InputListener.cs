using PlayerSystem;
using SceneSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Player _player;
        private PlayerMovement _playerMovement;
        private PlayerRotating _playerRotataing;
        private Pause _pause;
        public void Construct(Player player, PlayerRotating playerRotating)
        {
            _player = player;
            _playerRotataing = playerRotating;
        }

        private void Start()
        {
            _playerMovement = new();
        }

        private void Update()
        {
            ReadJumpInput();
            ReadRestartInput();
        }
        private void FixedUpdate()
        {
            ReadMoveInput();
        }
        private void ReadMoveInput()
        {
            float xMove = Input.GetAxisRaw("Horizontal");
            _playerMovement.Move(xMove, _player);
        }
        private void ReadJumpInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerMovement.Jump(_player);
                _playerRotataing.RotateAfterJump();
            }
        }
        private void ReadRestartInput()
        {
            if (Input.GetKeyDown(KeyCode.R))
                ReloadScene.RestartScene();
        }
    }
}