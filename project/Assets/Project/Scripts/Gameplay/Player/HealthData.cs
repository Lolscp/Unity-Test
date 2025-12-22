namespace Scripts.Player {
    [System.Serializable]
    public class HealthData {
        public float _CurrentHealth {  get; private set; }
        public float _maxHealth { get; private set; }

        public HealthData(float MaxHealth) {
            _maxHealth = MaxHealth;
            _CurrentHealth = _maxHealth;
        }

        public void Heal(float value) => _CurrentHealth += value;
        public void TakeDamage(float value) => _CurrentHealth -= value;
        public void SetHealthMax() => _CurrentHealth = _maxHealth;
    }
}