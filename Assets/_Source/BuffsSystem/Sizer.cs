using UnityEngine;

namespace BuffsSystem
{
    public class Sizer : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private bool isBigger;
        [SerializeField] private float sizeMultiplier;
        [SerializeField] private float massMultiplier;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(!collision.CompareTag(GlobalValues.PLAYER_TAG)) return;

            if (isBigger)
            {
                collision.transform.localScale = new Vector3(collision.transform.localScale.x + sizeMultiplier, 
                                                                collision.transform.localScale.y + sizeMultiplier, 
                                                                collision.transform.localScale.z + sizeMultiplier);
                collision.GetComponent<Rigidbody2D>().mass += massMultiplier;
                Destroy(gameObject);
            }
            else
            {
                collision.transform.localScale = new Vector3(collision.transform.localScale.x - sizeMultiplier, 
                                                                collision.transform.localScale.y - sizeMultiplier, 
                                                                collision.transform.localScale.z - sizeMultiplier);
                collision.GetComponent<Rigidbody2D>().mass -= massMultiplier;
                Destroy(gameObject);
            }
        }
    }
}