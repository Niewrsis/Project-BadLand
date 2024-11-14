using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SceneSystem
{
    public class RestartGame : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private Button restartButton;

        private void Start()
        {
            ScoreText();
            restartButton.onClick.AddListener(Restart);
        }
        private void ScoreText()
        {
            scoreText.text = PlayerPrefs.GetInt("level_index").ToString();
        }
        private void Restart()
        {
            PlayerPrefs.SetInt("level_index", 1);
            ReloadScene.RestartScene();
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }
}