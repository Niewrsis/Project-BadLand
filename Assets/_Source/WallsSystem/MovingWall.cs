using UnityEngine;

namespace WallsSystem
{
    public class MovingWall : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private float offset;
        [SerializeField] private Vector2 startPosition;
        [SerializeField] private Vector2 endPosition;
        [SerializeField] private float speed;

        private int index;

        private void FixedUpdate()
        {
            MoveToTarget();
        }
        private void MoveToTarget()
        {
            if (index == 0)
            {
                transform.localPosition = Vector2.Lerp(transform.localPosition, endPosition, speed * Time.deltaTime);
                CheckPosition();
            }
            else
            {
                transform.localPosition = Vector2.Lerp(transform.localPosition, startPosition, speed * Time.deltaTime);
                CheckPosition();
            }
        }
        private void CheckPosition()
        {
            if(index == 0)
            {
                if(Vector2.Distance(transform.localPosition, endPosition) <= offset)
                {
                    index++;
                }
            }
            else if (index == 1)
            {
                if (Vector2.Distance(transform.localPosition, startPosition) <= offset)
                {
                    index--;
                }
            }
        }
    }
}