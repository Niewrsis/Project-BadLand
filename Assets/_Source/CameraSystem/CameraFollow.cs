using UnityEngine;

namespace CameraSystem
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private float followSpeed, yPosition;
        
        private Transform _target;

        public void Construct(Transform target)
        {
            _target = target;
        }
        private void Update()
        {
            transform.position = Vector3.Lerp(new Vector3(transform.position.x, yPosition, -10), new Vector2(_target.position.x, yPosition), followSpeed * Time.deltaTime);
        }
    }
}