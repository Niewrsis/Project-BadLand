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
        [SerializeField] private PlayerRotating playerRotating;
        [SerializeField] private Player player;

        private void Start()
        {
            cameraFollow.Construct(GameManager.Instance.player.transform);
            playerRotating.Construct(player);
            inputListener.Construct(player, playerRotating);
        }
    }
}