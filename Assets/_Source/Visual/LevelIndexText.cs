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
            levelIndexText.text = PlayerPrefs.GetInt(GlobalValues.LEVEL_INDEX_PP).ToString();
        }
    }
}