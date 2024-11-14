using Core;
using UnityEngine;

public class DeadlyWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag(GlobalValues.PLAYER_TAG)) return;

        GameManager.Instance.OnPlayerDeath?.Invoke();
    }
}
