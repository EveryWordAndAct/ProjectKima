using UnityEngine;

namespace Kima.Units.Statuses
{
    [CreateAssetMenu(fileName = "new Unit Setting", menuName = "ScriptableObjests/UnitStatusSetting")]
    public class UnitStatusSetting : ScriptableObject
    {
        [SerializeField]
        private int maxHp;

        [SerializeField]
        private int maxMp;

        public int MaxHp { get { return maxHp; } }
        public int MaxMp { get { return maxMp; } }
    }
}
