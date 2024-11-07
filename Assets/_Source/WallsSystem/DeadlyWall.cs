using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player")) return;

        //TODO: Restart logic
        Time.timeScale = 0f;
    }
}
