using UnityEngine;
using TMPro;

namespace InGame.Manager
{
    public class GameManager : MonoBehaviour
    {
        // 表示・非表示の管理
        [SerializeField] private GameObject panel;
        [SerializeField] private TextMeshProUGUI nameText;
        
        private void Start()
        {
            // 初期状態でパネルを非表示にする
            panel.SetActive(false);
            nameText.text = "あさめし";
        }
    }
}
