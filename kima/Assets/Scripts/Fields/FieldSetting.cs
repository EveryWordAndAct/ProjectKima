using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Kima.Fields
{
    [CreateAssetMenu(fileName = "new Field Setting", menuName = "FieldSetting")]
    public class FieldSetting : ScriptableObject
    {
        [SerializeField]
        private int width;
        [SerializeField]
        private int height;

        [SerializeField]
        private Vector2 worldPosition;

        [SerializeField]
        private Sprite sprite;

        public int Width { get { return width; } }
        public int Height { get { return height; } }
        public Vector2 WorldPosition { get { return worldPosition; } }
        public Sprite Sprite { get { return sprite; } }
    }
}
