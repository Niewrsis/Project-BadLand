using UnityEngine;

namespace WallsSystem
{
    [RequireComponent(typeof(SpriteRenderer), typeof(BoxCollider2D))]
    public class DestoyableWall : MonoBehaviour
    {
        [SerializeField] private Color color;

        private BoxCollider2D _boxCollider;
        private SpriteRenderer _sr;
        private void Start()
        {
            _sr = GetComponent<SpriteRenderer>();
            _boxCollider = GetComponent<BoxCollider2D>();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.collider.CompareTag("Player"))
            {
                _sr.color = color;
                _boxCollider.enabled = false;
            }
        }
    }
}