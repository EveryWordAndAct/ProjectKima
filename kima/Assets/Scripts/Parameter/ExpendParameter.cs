using UnityEngine;
using System.Collections;

namespace Kima.Parameter
{
    public class ExpendParameter
    {
        private int max;
        private int current;

        public ExpendParameter(int max)
        {
            SetMaxAndCurrent(max, max);
        }

        public ExpendParameter(int max, int current)
        {
            SetMaxAndCurrent(max, current);
        }

        public int Max { get { return max; } }
        public int Current { get { return current; } }

        private void SetMaxAndCurrent(int max, int current)
        {
            this.max = max;
            this.current = current;
        }
    }
}
