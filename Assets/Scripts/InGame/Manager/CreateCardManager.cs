using UnityEngine;

namespace InGame.Manager
{
    public class CreateCardManager : MonoBehaviour
    {
        [SerializeField] private GameObject cardPrefab;
        [SerializeField] private Transform playerHandTransform;

        private void Start()
        {
            CreateCard(playerHandTransform);
        }
        
        /// <summary>
        /// カードの生成
        /// </summary>
        /// <param name="hand"></param>
        private void CreateCard(Transform hand)
        {
            Instantiate(cardPrefab, hand);
        }
    }
}
