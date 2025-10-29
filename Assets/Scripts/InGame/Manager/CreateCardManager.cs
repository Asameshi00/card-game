using UnityEngine;

namespace InGame.Manager
{
    public class CreateCardManager : MonoBehaviour
    {
        [SerializeField] private GameObject cardPrefab;
        [SerializeField] private Transform cardsParent;

        private void Start()
        {
            Instantiate(cardPrefab, cardsParent);
        }
    }
}
