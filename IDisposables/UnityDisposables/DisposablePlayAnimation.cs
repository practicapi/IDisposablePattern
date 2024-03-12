using System;
using UnityEngine;

namespace Utils.IDisposableUtils
{
    public class DisposablePlayAnimation : IDisposable
    {
        private readonly Animation _animation;
        private readonly Animator _animator;

        public DisposablePlayAnimation(Animation animation, AnimationClip animationClip)
        {
            _animation = animation;
            _animation.Play(animationClip.name);
        }
        
        public DisposablePlayAnimation(Animator animator, int stateNameHash)
        {
            _animator = animator;
            _animator.enabled = true;
            _animator.Play(stateNameHash);
        }

        public void Dispose()
        {
            if (_animation != null)
            {
                _animation.Stop();
            }

            if (_animator != null)
            {
                _animator.enabled = false;
            }
        }
    }
}