using UnityEngine;
using System.Collections;
using UnityEditor.Animations;

namespace Kima.Objects
{
    public static class ObjectAnimatorControllerSetter
    {
        public static void SetAniamtorController(GameObject gameObject, AnimatorController animatorController)
        {
            var animator = gameObject.GetComponent<Animator>() ?? gameObject.AddComponent<Animator>();

            animator.runtimeAnimatorController = (RuntimeAnimatorController)RuntimeAnimatorController.Instantiate(animatorController);
        }

        public static void SetAniamtorController(GameObject gameObject, string path)
        {
            var animator = gameObject.GetComponent<Animator>() ?? gameObject.AddComponent<Animator>();

            animator.runtimeAnimatorController = (RuntimeAnimatorController)RuntimeAnimatorController.Instantiate(Resources.Load<AnimatorController>(path));
        }
    }
}
