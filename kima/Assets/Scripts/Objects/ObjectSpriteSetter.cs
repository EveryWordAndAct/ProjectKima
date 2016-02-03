using UnityEngine;

namespace Kima.Objects
{
    public static class ObjectSpriteSetter
    {
        public static void SetSprite(GameObject gameObject, Sprite sprite)
        {
            var spriteRenderer = gameObject.GetComponent<SpriteRenderer>() ?? gameObject.AddComponent<SpriteRenderer>();

            spriteRenderer.sprite = sprite;
        }

        public static void SetSprite(GameObject gameObject, string path)
        {
            var spriteRenderer = gameObject.GetComponent<SpriteRenderer>() ?? gameObject.AddComponent<SpriteRenderer>();

            spriteRenderer.sprite = Resources.Load<Sprite>(path);
        }
    }
}
