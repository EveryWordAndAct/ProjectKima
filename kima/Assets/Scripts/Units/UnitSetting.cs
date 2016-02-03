using UnityEditor.Animations;
using UnityEngine;

namespace Kima.Units
{
    [CreateAssetMenu(fileName = "new Unit Setting", menuName = "UnitSetting")]
    public class UnitSetting : ScriptableObject
    {
        [SerializeField]
        private Sprite sprite;

        [SerializeField]
        private AnimatorController animatorController;

        public Sprite Sprite { get { return sprite; } }
        public AnimatorController AnimatorController { get { return animatorController; } }
    }
}
