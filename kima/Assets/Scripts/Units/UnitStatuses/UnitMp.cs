using UnityEngine;
using System.Collections;

namespace Kima.Units.Statuses
{
    public class UnitMp
    {
        [SerializeField]
        private int maxMp;
        [SerializeField]
        private int currentMp;

        public UnitMp(int maxMp)
        {
            this.maxMp = maxMp;
            currentMp = maxMp;
        }

        public int MaxMp { get { return maxMp; } }
        public int CurrentMp { get { return currentMp; } }
    }
}
