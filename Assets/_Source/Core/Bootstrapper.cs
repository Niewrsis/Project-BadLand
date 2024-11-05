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

        private void Awake()
        {
            _inputListener.Construct(_player);
        }
    }
}