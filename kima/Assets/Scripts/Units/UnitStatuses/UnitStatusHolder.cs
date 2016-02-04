using UnityEngine;
using System.Collections;
using Kima.Parameter;

namespace Kima.Units.Statuses
{
    public class UnitStatusHolder : MonoBehaviour
    {
        [SerializeField]
        private ExpendParameter hp;
        [SerializeField]
        private ExpendParameter mp;

        public ExpendParameter Hp { get { return hp; } }
        public ExpendParameter Mp { get { return mp; } }

        public void SetUnitStatusSetting(UnitStatusSetting unitStatusSetting)
        {
            hp = new ExpendParameter(unitStatusSetting.MaxHp);
            mp = new ExpendParameter(unitStatusSetting.MaxMp);
        }
    }
}
