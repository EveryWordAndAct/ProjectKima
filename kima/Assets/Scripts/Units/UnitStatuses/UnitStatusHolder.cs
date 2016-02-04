using UnityEngine;
using System.Collections;

namespace Kima.Units.Statuses
{
    public class UnitStatusHolder : MonoBehaviour
    {
        [SerializeField]
        private UnitHp unitHp;
        [SerializeField]
        private UnitMp unitMp;

        public UnitHp UnitHp { get { return unitHp; } }

        public void SetUnitStatusSetting(UnitStatusSetting unitStatusSetting)
        {
            unitHp = new UnitHp(unitStatusSetting.MaxHp);
            unitMp = new UnitMp(unitStatusSetting.MaxMp);
        }
    }
}
