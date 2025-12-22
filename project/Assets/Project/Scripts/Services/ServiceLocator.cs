using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Services {
    public class ServiceLocator {
        private Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public void Recording<T>(T service) where T : class  {
            var Type = typeof(T);
            if (_services.ContainsKey(Type)) Debug.Log($"Сервис типа {Type} уже зарегистрирован. Перезапись существующего сервиса.");
            _services[Type] = service;

        }
        public T get<T>() where T : class {
            var Type = typeof(T);
            if (_services.TryGetValue(Type, out var service)) {
                return service as T;
            }
            Debug.Log($"Сервис типа {Type} не зарегистрирован.");
            return null;
        }
        public void Remove<T>(T service) where T : class  {
            var Type = typeof(T);
            if (_services.ContainsKey(Type)) {
                _services.Remove(Type);
            }
            else Debug.LogWarning($"Сервис типа {Type} не зарегистрирован. Удалить регистрацию невозможно.");

        }
    }
}