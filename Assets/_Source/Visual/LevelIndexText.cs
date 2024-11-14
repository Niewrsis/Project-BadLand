using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Visual
{
    public class LevelIndexText : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI levelIndexText;
        private void Start()
        {
            levelIndexText.text = PlayerPrefs.GetInt("level_index").ToString();
        }
    }
}