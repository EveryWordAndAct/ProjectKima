using Kima.Units.Statuses;
using UnityEditor.Animations;
using UnityEngine;

namespace Kima.Units
{
    [CreateAssetMenu(fileName = "new Unit Setting", menuName = "ScriptableObjests/UnitSetting")]
    public class UnitSetting : ScriptableObject
    {
        [SerializeField]
        private Sprite sprite;

        [SerializeField]
        private AnimatorController animatorController;

        [SerializeField]
        private UnitStatusSetting unitStatusSetting;

        public Sprite Sprite { get { return sprite; } }
        public AnimatorController AnimatorController { get { return animatorController; } }
        public UnitStatusSetting UnitStatusSetting { get { return unitStatusSetting; } }
    }
}
