using System;
using UnityEngine;

namespace Utils.IDisposableUtils
{
    public class DisposableEnableComponent : IDisposable
    {
        private readonly Behaviour _component;
        private readonly bool _isStartingEnabled;

        public DisposableEnableComponent(Behaviour component, bool isStartingEnabled = true)
        {
            _component = component;
            _isStartingEnabled = isStartingEnabled;
            _component.enabled = _isStartingEnabled;
        }

        public void Dispose()
        {
            _component.enabled = !_isStartingEnabled;
        }
    }
}