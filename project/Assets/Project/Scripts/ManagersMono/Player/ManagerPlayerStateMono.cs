using Scripts.Player;
using UnityEngine;

namespace Scripts.Manager.Player {
    public class ManagerPlayerStateMono : MonoBehaviour {

        private void Awake() { }
        public void Inti() { }

        [Header("PlayerComponent")]
        [SerializeField] private PlayerMono _Player;
    }
}