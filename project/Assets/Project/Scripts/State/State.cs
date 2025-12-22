namespace Scripts.State {
    public abstract class State {
        public abstract void Update();
        public abstract void Entry();
        public abstract void Exit();
    }
}