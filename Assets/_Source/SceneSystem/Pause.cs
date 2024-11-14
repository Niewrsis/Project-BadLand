using System.Collections;
using System.Collections.Generic;
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
            Time.timeScale = 1f;
            pauseObj.SetActive(false);
        }
        private void PauseGame()
        {
            Time.timeScale = 0f;
            pauseObj.SetActive(true);
        }
        private void RestartGame()
        {
            Time.timeScale = 1f;
            PlayerPrefs.SetInt("level_index", 1);
            pauseObj.SetActive(false);
            ReloadScene.RestartScene();
        }
    }
}