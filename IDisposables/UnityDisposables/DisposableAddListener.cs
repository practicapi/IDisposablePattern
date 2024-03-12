using System;
using UnityEngine.Events;

namespace Utils.IDisposableUtils
{
    public class DisposableAddListener : IDisposable
    {
        private readonly UnityEvent _eventHandler;
        private readonly UnityAction _eventAction;

        public DisposableAddListener(UnityEvent eventHandler, UnityAction eventAction)
        {
            _eventHandler = eventHandler;
            _eventAction = eventAction;
            _eventHandler.AddListener(_eventAction);
        }
        
        public DisposableAddListener(UnityEvent eventHandler, Action eventAction)
        {
            _eventHandler = eventHandler;
            _eventAction = new UnityAction(eventAction);
            _eventHandler.AddListener(_eventAction);
        }

        public void Dispose()
        {
            _eventHandler.RemoveListener(_eventAction);
        }
    }
}