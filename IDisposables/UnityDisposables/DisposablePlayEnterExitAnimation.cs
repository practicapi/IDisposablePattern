using System;
using UnityEngine;

namespace Utils.IDisposableUtils
{
    public class DisposablePlayEnterExitAnimation : IDisposable
    {
        private readonly Animation _animation;
        private readonly Animator _animator;
        private readonly AnimationClip _exitAnimationClip;
        private readonly int _exitStateNameHash;

        public DisposablePlayEnterExitAnimation(Animation animation, AnimationClip enterAnimationClip, AnimationClip exitAnimationClip)
        {
            _animation = animation;
            _exitAnimationClip = exitAnimationClip;
            _animation.Play(enterAnimationClip.name);
        }
        
        public DisposablePlayEnterExitAnimation(Animator animator, int enterStateNameHash, int exitStateNameHash)
        {
            _animator = animator;
            _exitStateNameHash = exitStateNameHash;
            _animator.Play(enterStateNameHash);
        }

        public void Dispose()
        {
            if (_animation != null)
            {
                _animation.Play(_exitAnimationClip.name);
            }

            if (_animator != null)
            {
                _animator.Play(_exitStateNameHash);
            }
        }
    }
}