using System;
using UnityEngine;

namespace Utils.IDisposableUtils
{
    public class DisposableFreezeTime : IDisposable
    {
        private readonly float _previousTimeScale;

        public DisposableFreezeTime()
        {
            _previousTimeScale = Time.timeScale;
            Time.timeScale = 0f;
        }

        public void Dispose()
        {
            Time.timeScale = _previousTimeScale;
        }
    }
}