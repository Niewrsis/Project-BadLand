using CameraSystem;
using InputSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private InputListener inputListener;
        [SerializeField] private CameraFollow cameraFollow;
        [SerializeField] private PlayerRotating _playerRotating;
        [SerializeField] private Player _player;

        private void Awake()
        {   
            cameraFollow.Construct(GameManager.Instance.player.transform);
            _playerRotating.Construct(_player);
            inputListener.Construct(_player, _playerRotating);
        }
    }
}