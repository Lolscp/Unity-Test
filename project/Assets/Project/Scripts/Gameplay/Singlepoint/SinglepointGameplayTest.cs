using Scripts.Manager.Enemy.Factory;
using Scripts.Manager.Player;
using UnityEngine;

namespace Scripts.Singlepoint {
    public class SinglepointGameplayTest : MonoBehaviour {

        private void IntiAll() {
            IntiManager();
        }
        private void Awake() => IntiAll();

        private void IntiManager() {
            _factoryPlayer.Inti();
            _PlayerStateMono.Inti();
            _FactoryEnemyMono.Inti();
        }

        [SerializeField] private ManagerFactoryPlayer _factoryPlayer;
        [SerializeField] private ManagerPlayerStateMono _PlayerStateMono;
        [SerializeField] private ManagerFactoryEnemyMono _FactoryEnemyMono;
    }
}