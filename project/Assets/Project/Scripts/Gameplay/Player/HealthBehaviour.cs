using System;

namespace Scripts.Player {
    public class HealthBehaviour {
        private HealthData _Health;

        private void Heal(float Heal) {
            _Health.Heal(Heal);
            if (CurrentHealth < HealthMax) _Health.SetHealthMax();
        }
        private void TakeDamage(float Damage) {
            _Health.TakeDamage(Damage);
            if (CurrentHealth <= 0) DiePlayer?.Invoke();
        }
        public HealthBehaviour(float MaxHealth) {
            _Health = new HealthData(MaxHealth);
        }

        public event Action DiePlayer;

        public float CurrentHealth => _Health._CurrentHealth;
        public float HealthMax => _Health._maxHealth;
    }
}