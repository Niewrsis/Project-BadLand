using InputSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Player _player;
        [SerializeField] private InputListener _inputListener;
        [SerializeField] private PlayerRotating _playerRotating;

        private void Awake()
        {
            _inputListener.Construct(_player, _playerRotating);
            _playerRotating.Construct(_player);
        }
    }
}