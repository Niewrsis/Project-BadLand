using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace WallsSystem
{
    public class RotatingWall : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private float rotatingDuration;
        [SerializeField] private int offset;

        private void Start()
        {
            StartCoroutine(Rotate(offset));
        }
        private IEnumerator Rotate(int offset)
        {
            transform.DORotate(new Vector3(0, 0, transform.rotation.z + offset), rotatingDuration, RotateMode.LocalAxisAdd);
            yield return new WaitForSeconds(rotatingDuration);
            StartCoroutine(Rotate(offset));
        }
       /* private IEnumerator Counterclockwise()
        {
            transform.DORotate(new Vector3(0,0,transform.rotation.z - 180), rotatingDuration, RotateMode.LocalAxisAdd);
            yield return new WaitForSeconds(rotatingDuration);
            StartCoroutine(Counterclockwise());
        }*/
        private void OnDestroy()
        {
            StopAllCoroutines();
        }
    }
}