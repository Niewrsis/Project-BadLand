using UnityEngine;

namespace CameraSystem
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Transform target;

        [Header("Attributes")]
        [SerializeField] private float followSpeed;

        private void Update()
        {
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, 0, -20), new Vector2(target.position.x, 0), followSpeed * Time.deltaTime);
        }
    }
}