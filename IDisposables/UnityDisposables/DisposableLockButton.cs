using System;
using UnityEngine.UI;

namespace Utils.IDisposableUtils
{
    public class DisposableLockButton : IDisposable
    {
        private readonly Button _button;
        private readonly bool _isStartingLocked;

        public DisposableLockButton(Button button , bool isStartingLocked = true)
        {
            _button = button;
            _isStartingLocked = isStartingLocked;
            _button.enabled = !_isStartingLocked;
        }

        public void Dispose()
        {
            _button.enabled = _isStartingLocked;
        }
    }
}