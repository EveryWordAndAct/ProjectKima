using UnityEngine;
using System.Collections;

namespace Kima.Units.Statuses
{
    public class UnitStatusHolder : MonoBehaviour
    {
        [SerializeField]
        private int maxHp = 0;
        [SerializeField]
        private int maxMp = 0;

        public void SetUnitStatusSetting(UnitStatusSetting unitStatusSetting)
        {
            maxHp = unitStatusSetting.MaxHp;
            maxMp = unitStatusSetting.MaxMp;
        }
    }
}
