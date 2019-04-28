using UnityEngine;

namespace _01
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private int speed = 1;
    
        void Update()
        {
            var position = transform.position;
            position = new Vector3(position.x + speed * Time.deltaTime, position.y, position.z);
       
            transform.position = position;
        }
    }
}
