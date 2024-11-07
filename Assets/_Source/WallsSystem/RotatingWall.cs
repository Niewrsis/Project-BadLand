using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace WallsSystem
{
    public class RotatingWall : MonoBehaviour
    {
        [SerializeField] private float rotatingDuration;
        [SerializeField] private bool isClockwise;

        private void Start()
        {
            if (isClockwise)
            {
                StartCoroutine(Clockwise());
            }
            else
            {
                StartCoroutine(Counterclockwise());
            }
        }
        private IEnumerator Clockwise()
        {
            transform.DORotate(new Vector3(0, 0, transform.rotation.z + 180), rotatingDuration, RotateMode.LocalAxisAdd);
            yield return new WaitForSeconds(rotatingDuration);
            StartCoroutine(Clockwise());
        }
        private IEnumerator Counterclockwise()
        {
            transform.DORotate(new Vector3(0,0,transform.rotation.z + 180), rotatingDuration, RotateMode.LocalAxisAdd);
            yield return new WaitForSeconds(rotatingDuration);
            StartCoroutine(Counterclockwise());
        }
    }
}