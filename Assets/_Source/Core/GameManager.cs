using System;
using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public Action OnPlayerDeath;

        [Header("References")]
        public GameObject player;
        [SerializeField] private GameObject[] startPrefabs;
        [SerializeField] private GameObject[] levelPrefabs;
        [SerializeField] private GameObject[] finishPrefabs;
        [SerializeField] private GameObject restartPrefab;

        [Header("Settings")]
        [SerializeField] private int levelLength;
        [SerializeField] private float playerOffsetY;
        [SerializeField] private float offsetX;
        [SerializeField] private Vector2 startSpawn;

        private int _randomStart;

        private void Awake()
        {
            if (Instance != null && Instance != this) 
                Destroy(this);
            else 
                Instance = this;

            _randomStart = UnityEngine.Random.Range(0, startPrefabs.Length);

            if (levelLength <= 0)
            {
                PlayerPrefs.SetInt(GlobalValues.LEVEL_INDEX_PP, levelLength);
            }
            else
            {
                levelLength = PlayerPrefs.GetInt(GlobalValues.LEVEL_INDEX_PP);
            }
            SpawnRandomLevel();
            SpawnPlayer();
        }
        private void Start()
        {
            OnPlayerDeath += GameOver;
        }
        private void SpawnPlayer()
        {
            player.transform.position = new Vector2(startSpawn.x, playerOffsetY);
        }
        private void SpawnRandomLevel()
        {
            if (startPrefabs == null) throw new Exception("Start prefabs is null");
            if (levelPrefabs == null) throw new Exception("Level prefabs is null");
            if (finishPrefabs == null) throw new Exception("Finish prefabs is null");

            Instantiate(startPrefabs[_randomStart], startSpawn, Quaternion.identity);
            Vector2 previuosPostition = startSpawn;

            for (int i = 0; i < levelLength; i++)
            {
                int randomLevel = UnityEngine.Random.Range(0, levelPrefabs.Length);
                previuosPostition = new Vector2(previuosPostition.x + offsetX, previuosPostition.y);
                Instantiate(levelPrefabs[randomLevel], previuosPostition, Quaternion.identity);
            }

            int randomFinish = UnityEngine.Random.Range(0, finishPrefabs.Length);
            previuosPostition = new Vector2(previuosPostition.x + offsetX, previuosPostition.y);
            Instantiate(finishPrefabs[randomFinish], previuosPostition, Quaternion.identity);
        }
        private void GameOver()
        {
            Instantiate(restartPrefab);
            Time.timeScale = 0f;
        }
        private void OnDisable()
        {
            OnPlayerDeath -= GameOver;
        }
    }
}