using Scripts.Player;
using UnityEngine;

namespace Scripts.Manager.Player {
    public sealed class ManagerFactoryPlayer : MonoBehaviour {
        public void Inti() { }


        private void CreatePlayer() {
        }


        [Header("Player")]
        [SerializeField] private PlayerMono _playerEmpty;
    }
}