using UnityEngine;

namespace CameraSystem
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Transform target;

        [Header("Attributes")]
        [SerializeField] private float followSpeed, yPosition;

        private void Update()
        {
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, yPosition, -20), new Vector2(target.position.x, yPosition), followSpeed * Time.deltaTime);
        }
    }
}