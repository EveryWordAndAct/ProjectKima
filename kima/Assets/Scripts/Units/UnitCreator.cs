﻿using Kima.Objects;
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

            Debug.Log(string.Format(UnitSettingPathFormat, name));
            var unitSetting = Resources.Load<UnitSetting>(string.Format(UnitSettingPathFormat, name));

            ObjectSpriteSetter.SetSprite(unitObject, unitSetting.Sprite);
            ObjectAnimatorControllerSetter.SetAniamtorController(unitObject, unitSetting.AnimatorController);

            return unitObject;
        }
    }
}
