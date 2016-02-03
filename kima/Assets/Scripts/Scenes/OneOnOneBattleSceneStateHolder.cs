using UnityEngine;
using Kima.Units;
using Kima.Objects;

namespace Kima.Scenes
{
    public class OneOnOneBattleSceneStateHolder : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            UnitCreator.CreateUnit(UnitNames.Bo);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
