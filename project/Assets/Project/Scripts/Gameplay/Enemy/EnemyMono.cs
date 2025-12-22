using UnityEngine;

namespace Scripts.Enemy {
    public abstract class EnemyMono : MonoBehaviour {
        [SerializeField] private Movement _movement;

        private void Update() {
            _movement.Update();
        }
        public void Inti() { }
    }
}
