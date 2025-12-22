using System;
using System.Collections.Generic;

namespace Scripts.State {
    public abstract class Context {
        private State _state;

        public Context() {

        }

        private Dictionary<Type, State> States;

        public void AddState<T>(State state) where T : State {

        }
        public void CreateState<T>(State state) where T : State { } // “ут тоже.
        public Type GetTypeState() => _state.GetType();
    }
}
