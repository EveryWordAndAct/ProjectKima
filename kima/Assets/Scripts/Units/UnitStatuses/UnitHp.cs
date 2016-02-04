using UnityEngine;
using System.Collections;

namespace Kima.Units.Statuses
{
    public class UnitHp
    {
        [SerializeField]
        private int maxHp;
        [SerializeField]
        private int currentHp;

        public UnitHp(int maxHp)
        {
            this.maxHp = maxHp;
            currentHp = maxHp;
        }

        public int MaxHp { get { return maxHp; } }
        public int CurrentHp { get { return currentHp; } }
    }
}
