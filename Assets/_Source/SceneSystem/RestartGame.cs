using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SceneSystem
{
    public class RestartGame : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private Button restartButton;

        private void Start()
        {
            ScoreText();
            restartButton.onClick.AddListener(Restart);
        }
        private void ScoreText()
        {
            scoreText.text = PlayerPrefs.GetInt(GlobalValues.LEVEL_INDEX_PP).ToString();
        }
        private void Restart()
        {
            PlayerPrefs.SetInt(GlobalValues.LEVEL_INDEX_PP, 1);
            ReloadScene.RestartScene();
            Time.timeScale = GlobalValues.STANDART_GAME_TIME;
        }
    }
}