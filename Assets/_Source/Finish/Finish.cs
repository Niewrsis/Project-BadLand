using SceneSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Finish
{
    public class Finish : MonoBehaviour
    {
        private ReloadScene _reloadScene = new();
        private int _levelIndex;
        private void Start()
        {
            _levelIndex = PlayerPrefs.GetInt("level_index");
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.CompareTag("Player")) return;

            _levelIndex++;
            PlayerPrefs.SetInt("level_index", _levelIndex);
            _reloadScene.RestartScene();
        }
    }
}