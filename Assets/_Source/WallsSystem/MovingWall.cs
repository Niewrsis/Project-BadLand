using UnityEngine;

namespace WallsSystem
{
    public class MovingWall : MonoBehaviour
    {
        [SerializeField] private float offset;
        [SerializeField] private Vector2 startPosition;
        [SerializeField] private Vector2 endPosition;
        [SerializeField] private float speed;
        [SerializeField] private bool isDeadly;

        private int index;

        private void FixedUpdate()
        {
            MoveToTarget();
        }
        private void MoveToTarget()
        {
            if (index == 0)
            {
                transform.position = Vector2.Lerp(transform.position, endPosition, speed * Time.deltaTime);
                CheckPosition();
            }
            else
            {
                transform.position = Vector2.Lerp(transform.position, startPosition, speed * Time.deltaTime);
                CheckPosition();
            }
        }
        private void CheckPosition()
        {
            if(index == 0)
            {
                if(Vector2.Distance(transform.position, endPosition) <= offset)
                {
                    index++;
                }
            }
            else if (index == 1)
            {
                if (Vector2.Distance(transform.position, startPosition) <= offset)
                {
                    index--;
                }
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (isDeadly == false) return;
            if (!collision.collider.CompareTag("Player")) return;

            //TODO: Restart logic
            Time.timeScale = 0f;
        }
    }
}