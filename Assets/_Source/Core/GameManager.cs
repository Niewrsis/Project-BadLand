using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        [Header("References")]
        public GameObject player;
        [SerializeField] private GameObject[] startPrefabs;
        [SerializeField] private GameObject[] levelPrefabs;
        [SerializeField] private GameObject[] finishPrefabs;

        [Header("Settings")]
        [SerializeField] private int levelLength;
        [SerializeField] private float playerOffsetY;
        [SerializeField] private float offsetX;
        [SerializeField] private Vector2 startSpawn;

        public int LevelIndex { get; private set; }

        private int _randomStart;

        private void Awake()
        {
            if (Instance != null && Instance != this) 
                Destroy(this);
            else 
                Instance = this;

            _randomStart = UnityEngine.Random.Range(0, startPrefabs.Length);

            SpawnRandomLevel();
            SpawnPlayer();
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
    }
}