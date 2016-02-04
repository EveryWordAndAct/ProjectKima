using UnityEngine;
using System.Collections;

namespace Kima.Units.Statuses
{
    public class UnitStatusHolder : MonoBehaviour
    {
        [SerializeField]
        private UnitHp unitHp;
        [SerializeField]
        private int maxMp = 0;

        public UnitHp UnitHp { get { return unitHp; } }

        public void SetUnitStatusSetting(UnitStatusSetting unitStatusSetting)
        {
            unitHp = new UnitHp(unitStatusSetting.MaxHp);
            maxMp = unitStatusSetting.MaxMp;
        }
    }
}
