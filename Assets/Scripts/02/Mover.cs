using UnityEngine;

namespace _02
{
    public class Mover : MonoBehaviour
    {
        protected SpriteRenderer sprite;
        protected Rigidbody2D rigidbody;

        protected void Awake()
        {
            sprite = GetComponentInChildren<SpriteRenderer>();
            rigidbody = GetComponent<Rigidbody2D>();
        }

        protected void Move(Vector2 speed, Vector2 direction)
        {
            rigidbody.velocity = speed * direction * Time.deltaTime;
        }
    }
}