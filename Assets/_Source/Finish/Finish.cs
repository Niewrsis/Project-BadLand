using SceneSystem;
using UnityEngine;

namespace Finish
{
    public class Finish : MonoBehaviour
    {
        private int _levelIndex;
        private void Start()
        {
            _levelIndex = PlayerPrefs.GetInt(GlobalValues.LEVEL_INDEX_PP);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag(GlobalValues.PLAYER_TAG)) return;

            _levelIndex++;
            PlayerPrefs.SetInt(GlobalValues.LEVEL_INDEX_PP, _levelIndex);
            ReloadScene.RestartScene();
        }
    }
}