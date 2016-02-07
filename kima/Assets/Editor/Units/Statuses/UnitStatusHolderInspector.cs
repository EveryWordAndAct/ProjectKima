using UnityEngine;
using UnityEditor;
using Kima.Units.Statuses;

namespace Kima.Editor.Units.Statuses
{
    [CustomEditor(typeof(UnitStatusHolder))]
    public class UnitStatusHolderInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var unitStatusHolder = target as UnitStatusHolder;

            EditorGUILayout.LabelField(
                "HP",
                unitStatusHolder.Hp.Current.ToString()
                + " / "
                + unitStatusHolder.Hp.Max.ToString());

            EditorGUILayout.LabelField(
                "MP",
                unitStatusHolder.Mp.Current.ToString()
                + " / "
                + unitStatusHolder.Mp.Max.ToString());
        }
    }
}
