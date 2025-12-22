using UnityEngine;
using System;
namespace Scripts.Enemy {
    [Serializable]
    public class Movement {
        [SerializeField] private float _Speed;
        [SerializeField] private float _Move;

        private Transform _Target;

        private Rigidbody _Rb;

        public void Update() { }
    }
}