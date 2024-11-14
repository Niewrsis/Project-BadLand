using UnityEngine;
using UnityEngine.UI;

namespace SceneSystem
{
    public class Pause : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Button pauseButton;
        [SerializeField] private Button continueButton;
        [SerializeField] private Button restartButton;
        [SerializeField] private GameObject pauseObj;

        private void Start()
        {
            pauseObj.SetActive(false);

            pauseButton.onClick.AddListener(PauseGame);
            continueButton.onClick.AddListener(ContinueGame);
            restartButton.onClick.AddListener(RestartGame);
        }
        private void ContinueGame()
        {
            Time.timeScale = GlobalValues.STANDART_GAME_TIME;
            pauseObj.SetActive(false);
        }
        private void PauseGame()
        {
            Time.timeScale = 0f;
            pauseObj.SetActive(true);
        }
        private void RestartGame()
        {
            Time.timeScale = GlobalValues.STANDART_GAME_TIME;
            PlayerPrefs.SetInt(GlobalValues.LEVEL_INDEX_PP, 1);
            pauseObj.SetActive(false);
            ReloadScene.RestartScene();
        }
    }
}