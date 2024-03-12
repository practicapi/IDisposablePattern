using System;

namespace Utils.IDisposableUtils
{
    public class DisposableGeneric : IDisposable
    {
        private readonly Action _onEndAction;

        public DisposableGeneric(Action onStartAction, Action onEndAction)
        {
            onStartAction?.Invoke();
            _onEndAction = onEndAction;
        }

        public void Dispose()
        {
            _onEndAction?.Invoke();
        }
    }
}