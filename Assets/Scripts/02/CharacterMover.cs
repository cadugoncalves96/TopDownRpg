using UnityEngine;
using UnityEngine.Experimental.Input;

namespace _02
{
    public class CharacterMover : Mover
    {
        private Controls controls;
        private Vector2 speedV = new Vector2(100, 100);
        
        private void OnEnable()
        {
            controls.Player.Enable();
        }

        private void Awake()
        {
            base.Awake();
            
            controls = new Controls();

            controls.Player.Move.performed += OnMove;

            controls.Player.Move.cancelled += OnStop;
        }

        private void OnMove(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector2>();
            
            Move(speedV, direction);
        }

        private void OnStop(InputAction.CallbackContext context)
        {
            Move(speedV, Vector2.zero);
        }

        private void OnDisable()
        {
            controls.Player.Disable();
        }
    }
}