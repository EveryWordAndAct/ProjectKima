using Kima.Objects;
using Kima.Units.Statuses;
using UnityEngine;

namespace Kima.Units
{
    public static class UnitCreator
    {
        private const string UnitPrefabPath = "Prefabs/Units/Unit";
        private const string UnitSettingPathFormat = "Datas/UnitSettings/{0}UnitSetting";

        public static GameObject CreateUnit()
        {
            return Object.Instantiate(Resources.Load<GameObject>(UnitPrefabPath));
        }

        public static GameObject CreateUnit(UnitNames name)
        {
            var unitObject = CreateUnit();
            
            var unitSetting = Resources.Load<UnitSetting>(string.Format(UnitSettingPathFormat, name));

            ObjectSpriteSetter.SetSprite(unitObject, unitSetting.Sprite);
            ObjectAnimatorControllerSetter.SetAniamtorController(unitObject, unitSetting.AnimatorController);
            SetUnitStatus(unitObject, unitSetting.UnitStatusSetting);

            return unitObject;
        }

        private static void SetUnitStatus(GameObject unitObject, UnitStatusSetting unitStatusSetting)
        {
            var unitStatusHolder = unitObject.GetComponent<UnitStatusHolder>() ?? unitObject.AddComponent<UnitStatusHolder>();
            unitStatusHolder.SetUnitStatusSetting(unitStatusSetting);
        }
    }
}
