using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuffsSystem
{
    public class Sizer : MonoBehaviour
    {
        [SerializeField] private bool isBigger;
        [SerializeField] private float sizeMultiplier;
        [SerializeField] private float massMultiplier;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(!collision.CompareTag("Player")) return;

            if (isBigger)
            {
                collision.transform.localScale = new Vector3(collision.transform.localScale.x + sizeMultiplier, collision.transform.localScale.y + sizeMultiplier, collision.transform.localScale.z + sizeMultiplier);
                collision.GetComponent<Rigidbody2D>().mass += massMultiplier;
                Destroy(gameObject);
            }
            else
            {
                collision.transform.localScale = new Vector3(collision.transform.localScale.x - sizeMultiplier, collision.transform.localScale.y - sizeMultiplier, collision.transform.localScale.z - sizeMultiplier);
                collision.GetComponent<Rigidbody2D>().mass -= massMultiplier;
                Destroy(gameObject);
            }
        }
    }
}